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
            [FromForm(Name = "ScheduleId")] int scheduleId,
            [FromForm(Name = "CoachId")] int coachId,
            [FromForm(Name ="Seat")] int seat,
            [FromForm(Name = "StartAt")] string startAt,
            [FromForm(Name = "EndAt")] string endAt,
            [FromForm(Name = "Cabin")] int cabin,
            [FromForm(Name = "CoachCount")] int coachCount,
            [FromForm(Name = "FromStation")] int from,
            [FromForm(Name = "ToStation")] int to


            )
        {
            CartDto cart = new CartDto { 
                ScheduleId = scheduleId, 
                CoachId = coachId, 
                Seat = seat,
                StartTime = DateTime.Parse(startAt), 
                EndTime = DateTime.Parse(endAt) ,
                Cabin = cabin,
                CoachCount = coachCount,
                FromStation = from,
                ToStation = to
            };
            Station startStation = await ctx.Stations.FindAsync(from);
            Station endStation = await ctx.Stations.FindAsync(to);
            Schedule sche = await ctx.Schedules.FindAsync(scheduleId);
            string title = sche.Name + "  " + startStation.Code+ " - " + endStation.Code;
            string seatDetail = cart.Cabin==0? "Coach " + cart.CoachCount + " Seat: "+cart.Seat: "Coach " + cart.CoachCount + " Cabin: "+cart.Cabin+"/ Seat: " + cart.Seat;
            cart.Title = title;
            cart.StartAt = cart.StartTime.ToString("HH:mm dd/MM");
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
        [HttpGet]
        [Route("clearCart")]
        public ActionResult<bool> ClearCart()
        {
            try { 
                string? jsonListcart = HttpContext.Session.GetString("listCart");
                if (jsonListcart != null)
                {
                    HttpContext.Session.Remove("listCart");
                }
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
