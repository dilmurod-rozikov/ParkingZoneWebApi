﻿using ParkingZoneWebApi.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingZoneWebApi.Models
{
    [Table("ParkingSlot")]
    public class ParkingSlot
    {
        [Key]
        public int Id { get; set; }

        public uint No { get; set; }

        public bool IsAvailable { get; set; }

        [Required]
        public ParkingZone? ParkingZone { get; set; }

        [ForeignKey(nameof(ParkingZone))]
        public int ParkingZoneId { get; set; }

        [Required]
        [EnumDataType(typeof(Category))]
        public Category Category { get; set; }

        public ICollection<Reservation>? Reservations { get; set; }
    }
}
