using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol;
using Railway_Group01.Data;
using Railway_Group01.Models;
using System.Collections.Generic;

namespace Railway_Group01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RailwayAjaxController : ControllerBase
    {
        public RailwayDbContext ctx;
        public RailwayAjaxController(RailwayDbContext ctx)
        {
            this.ctx = ctx;
        }
        [HttpGet]
        [Route("listtrain")]
        public async Task<ActionResult<IEnumerable<Train>?>> GetListTrain()
        {
            IEnumerable<Train> train = await ctx.Trains.ToListAsync();
            return Ok(train);
        }
        [HttpPost]
        [Route("addcart")]
        public async Task<ActionResult<List<CartDto>>> AddCart(
            [FromForm(Name = "ScheduleId")] int ScheduleId,
            [FromForm(Name = "CoachId")] int CoachId,
            [FromForm(Name ="Seat")] int Seat
            )
        {
            CartDto cart = new CartDto { ScheduleId = ScheduleId, CoachId = CoachId, Seat = Seat };
            Schedule? sche = await ctx.Schedules!.Include(x => x.Route).Include(x => x.Train).FirstOrDefaultAsync(x => x.Id == cart.ScheduleId);
            Coach? coa = await ctx.Coachs!.FirstOrDefaultAsync(x => x.Id == cart.CoachId);
            if (sche == null ||coa ==null)
            {
                return BadRequest();
            }
            sche.Route.StartStation = await ctx.Stations.FirstOrDefaultAsync(x =>x.Id == sche.Route.StartStationId);
            sche.Route.EndStation = await ctx.Stations.FirstOrDefaultAsync(x =>x.Id == sche.Route.EndStationId);
            string title = sche.Train.Name + " " + sche.Route.StartStation.StationCode + " - " + sche.Route.EndStation.StationCode;
            cart.Title = title;
            cart.StartAt = sche.StartAt.ToString("HH:mm dd/MM");
            cart.SeatDetail = seatDetail;
            Console.WriteLine(HttpContext.Session.GetString("listCart"));
            List<CartDto> list;
            try
            {
                string? jsonListcart = HttpContext.Session.GetString("listCart");
                if (jsonListcart != null)
                {
                    list = JsonConvert.DeserializeObject<List<CartDto>>(jsonListcart);
                }
                else
                {
                    list = new List<CartDto>();
                }
                list.Add(cart);
                string toJson = JsonConvert.SerializeObject(list);
                HttpContext.Session.SetString("listCart", toJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
            return Ok(list);
        }
        [HttpPost]
        [Route("removeitem")]
        public async Task<ActionResult<List<CartDto>?>> RemoveItem(
            [FromForm(Name = "ScheduleId")] int ScheduleId,
            [FromForm(Name = "CoachId")] int CoachId,
            [FromForm(Name = "Seat")] int Seat
            )
        {
            List<CartDto> list;
            try
            {
                string? jsonListcart = HttpContext.Session.GetString("listCart");
                if (jsonListcart != null)
                {
                    list = JsonConvert.DeserializeObject<List<CartDto>>(jsonListcart);
                }
                else
                {
                    return Ok(null);
                }
                CartDto cart = list.FirstOrDefault(x => x.ScheduleId == ScheduleId && x.CoachId == CoachId && x.Seat == Seat);
                list.Remove(cart);
                string toJson = JsonConvert.SerializeObject(list);
                HttpContext.Session.SetString("listCart", toJson);
                return Ok(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}
