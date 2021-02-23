using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionsLib;

namespace BusesLib
{
    public abstract class Bus
    {
        private int[] occupiedPlaces = new int[4] { 0, 0, 0, 0 };
        public int FreePlacesQuantity { get; set; }
        public string Type { get; set; }
        public double PricePerKilometer { get; set; }

        public Bus(int freePlacesQuantity, string type, double pricePerKilometer)
        {
            Type = type;
            PricePerKilometer = pricePerKilometer;
            FreePlacesQuantity = freePlacesQuantity;
        }

        private bool FreePlaceChecking(int departurePoint, int arrivalPoint, int quantity)
        {
            var flag = true;
            for (var i = departurePoint; i <= arrivalPoint; i++)
                if (occupiedPlaces[i] + quantity > FreePlacesQuantity)
                    flag = false;
            return flag;
        }

        public double PriceCalculating(int distance, int quantity)
        {
            return distance * PricePerKilometer * quantity;
        }

        public double TicketBuying(int departurePoint, int arrivalPoint, int quantity, int distance)
        {
            double price = 9;
            if (FreePlaceChecking(departurePoint, arrivalPoint - 1, quantity))
            {
                for (var i = departurePoint; i <= arrivalPoint - 1; i++)
                    occupiedPlaces[i] += quantity;
                price = PriceCalculating(distance, quantity);
            }
            else
                throw new NoFreeSeatsException();
            return price;
        }

        public int OutputInfo(int departurePoint, int arrivalPoint)
        {
            var quantity = 0;
            for (var i = departurePoint; i <= arrivalPoint - 1; i++)
                if (occupiedPlaces[i] > quantity)
                    quantity = occupiedPlaces[i];
            return FreePlacesQuantity - quantity;
        }

        public void EditInfo(int departurePoint, int arrivalPoint, int places)
        {
            for (var i = departurePoint; i <= arrivalPoint - 1; i++)
                occupiedPlaces[i] = FreePlacesQuantity - places;
        }
    }
}
