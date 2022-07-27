using System;

namespace Domain.Sodas.DTOs
{
    public class SodaDTO
    {
        public String Name { get; set; }
        public int Available { get; set; }
        public double Price { get; set; }
        public String Currency { get; set; }

        public SodaDTO()
        {
            this.Name = String.Empty;
            this.Available = 0;
            this.Price = 0;
            this.Currency = "₡";
        }

        public SodaDTO(string Name, int Available, double Price, String Currency)
        {
            this.Name=Name;
            this.Available=Available;
            this.Price=Price;
            this.Currency=Currency;
        }
    }
}
