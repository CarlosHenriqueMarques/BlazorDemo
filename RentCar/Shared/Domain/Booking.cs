using System;

namespace RentCar.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public virtual Customer Customer { get; set; }
        public int CostumerId { get; set; }

    }
}