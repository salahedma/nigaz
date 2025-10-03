using InfraStractur.DB_Context;
using InfraStractur.Migrations;
using Microsoft.AspNetCore.SignalR;
using Models.Model;

namespace SignalR_exist
{
    public class exist:Hub
    {
        private readonly Context context;

        public exist(Context context )
        {
            this.context = context;
        }
        public async Task ReserveSeat(int seatNumber,string userId,string CategoryId)
        {
            Console.WriteLine($"Seat {seatNumber} reserved.");
            await Clients.All.SendAsync("SeatReserved", seatNumber,userId,CategoryId);
            var UserId = userId;
            var x = new Models.Model.UserCatigory()
            {
                UserId = UserId,
                CatigoryId=CategoryId,
            };
            await context.userCatigories.AddAsync(x);

            var seats=new Seats() { Index_Seats=seatNumber,UserId = userId ,CatigoryId= CategoryId };

            await context.seats.AddAsync(seats);

            await context.SaveChangesAsync();
        }
    }
}
