using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;

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
        public async Task<ActionResult<CartDto>> AddBooking(CartDto cart) { 
            Schedule sche = await ctx.Schedules!.Include(x=>x.Route).Include(x=>x.Train).FirstOrDefaultAsync(x=>x.Id== cart.ScheduleId);
            if (sche == null) { 
                return BadRequest(); 
            }
            sche.Route.StartStation = await ctx.Stations.FirstOrDefaultAsync(x =>x.Id == sche.Route.StartStationId);
            sche.Route.EndStation = await ctx.Stations.FirstOrDefaultAsync(x =>x.Id == sche.Route.EndStationId);
            string title = sche.Train.Code + " " + sche.Route.StartStation.Code + " - " + sche.Route.EndStation.Code;
            cart.Title = title;
            cart.StartAt = sche.Departure;
            try { 
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
            return Ok(cart);
        } 
    }
}
