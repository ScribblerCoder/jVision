﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using jVision.Server.Data;
using jVision.Shared;
using Microsoft.AspNetCore.SignalR;
using jVision.Shared.Models;
using jVision.Server.Models;
using jVision.Server.Hubs;

namespace jVision.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BoxController : ControllerBase
    {
        private readonly JvisionServerDBContext _context;
        private readonly IHubContext<BoxHub, IBoxClient> _hubContext;
        //HUB CONTEXt
        public BoxController(JvisionServerDBContext context, IHubContext<BoxHub, IBoxClient> hubContext)
        {
            _context = context;
            _hubContext = hubContext;

        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoxDTO>>> GetBox()
        {
            return await _context.Boxes
                //maybe convert service to dto?
                //fix this whole thing
                .Include(c => c.Services)
                .Select(box => new BoxDTO
                {
                    BoxId = box.BoxId,
                    UserId = box.UserId,
                    UserName = _context.Users.Where(s => s != null && s.Id == box.UserId).Select(l => l.UserName).FirstOrDefault(),
                    Ip = box.Ip,
                    Hostname = box.Hostname,
                    State = box.State,
                    Comments = box.Comments,
                    Standing = box.Standing,
                    Os = box.Os,
                    Cidr = box.Cidr,
                    Subnet = box.Subnet,
                    Refs = box.BoxId.ToString(),
                    Services = box.Services.Where(s => s!= null).Select(x => ServiceToDTO(x)).ToList()
                    //(ICollection<ServiceDTO>)box.Services
                }).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<BoxDTO>>> PostBox(IEnumerable<BoxDTO> bto)
        {
            //async vs sync?
            await _context.Boxes.AddRangeAsync(bto.Select(b => new Box
            {
                //UserId = b.UserId,
                Ip = b.Ip,
                //just use b.UserName?
                User = _context.Users?.Where(l => l.UserName.Equals(b.UserName)).FirstOrDefault(),
                Hostname = b.Hostname,
                State = b.State,
                Comments = b.Comments,
                Standing = b.Standing,
                Os = b.Os,
                Cidr = b.Cidr,
                Subnet = b.Subnet,
                Services = b.Services?.Select(x => DTOToService(x)).ToList()
            }));
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.BoxAdded("added");

            return StatusCode(200);
        }

        [HttpPut]
        public async Task<IActionResult> PutBox(BoxDTO boxdto)
        {

            var box = await _context.Boxes.FindAsync(boxdto.BoxId);
            if (box == null)
            {
                return NotFound();
            }
            box.Ip = boxdto.Ip;
            box.User = _context.Users.Where(l => l.UserName.Equals(boxdto.UserName)).FirstOrDefault();
            box.Hostname = boxdto.Hostname;
            box.State = boxdto.State;
            box.Comments = boxdto.Comments;
            box.Standing = boxdto.Standing;
            box.Os = boxdto.Os;
            box.Cidr = boxdto.Cidr;
            box.Subnet = boxdto.Subnet;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!BoxExists(boxdto.BoxId))
            {
                return NotFound();
            }
            await _hubContext.Clients.All.BoxUpdated(boxdto);
            Console.WriteLine("PLEASE");
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBox()
        {
            _context.Boxes.RemoveRange(_context.Boxes);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool BoxExists(int id)
        {
            return _context.Boxes.Any(e => e.BoxId == id);
        }
        /**

        **/
        private static Service DTOToService(ServiceDTO s) =>
            new Service
            {
                Port = s.Port,
                Protocol = s.Protocol,
                State = s.State,
                Name = s.Name,
                Version = s.Version,
                Script = s.Script
            };
        private static BoxDTO BoxToDTO(Box box)
        {
            return new BoxDTO
            {
                BoxId = box.BoxId,
                UserId = box.UserId,
                UserName = box.User?.UserName,
                Ip = box.Ip,
                Hostname = box.Hostname,
                State = box.State,
                Comments = box.Comments,
                Standing = box.Standing,
                Os = box.Os,
                Cidr = box.Cidr,
                Subnet = box.Subnet,
                Refs = box.BoxId.ToString(),
                Services = box.Services?.Select(x => ServiceToDTO(x)).ToList()
                //(ICollection<ServiceDTO>)box.Services
            };
        }

        private static ServiceDTO ServiceToDTO(Service s) =>
            new ServiceDTO
            {
                BoxId = s.BoxId,
                ServiceId = s.ServiceId,
                Port = s.Port,
                Protocol = s.Protocol,
                State = s.State,
                Name = s.Name,
                Version = s.Version,
                Script = s.Script
            };

    }
}

