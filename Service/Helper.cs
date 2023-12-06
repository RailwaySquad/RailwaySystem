using Railway_Group01.Data;

namespace Railway_Group01.Service
{
    public static class Helper
    {
        public static decimal CalculatePrice(int travelDistance, int routeDistance, decimal routePrice)
        {
            if (travelDistance > routeDistance)
                throw new Exception("Travel distance cannot bigger route distance");
            var price = routePrice * travelDistance / routeDistance;
            price = Math.Round(price, 2);
            return price;
        }
    }
}
