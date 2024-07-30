﻿using ParkingZoneWebApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ParkingZoneWebApi.DTOs
{
    public class ParkingZoneDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        public DateTimeOffset CreatedDate { get; set; }

        public ParkingZoneDto(int id, string title, string address, DateTimeOffset createdDate)
        {
            Id = id;
            Title = title;
            Address = address;
            CreatedDate = createdDate;
        }

        public ParkingZone MapToModel()
        {
            return new()
            {
                Id = Id,
                Title = Title,
                Address = Address,
                CreatedDate = CreatedDate,
            };
        }
    }
}