﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATaxi.DL
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        [Required]
        public string CarNumber { get; set; }
        public string CarModel { get; set; }
        public string CarDriverFIO { get; set; }
        public bool CarReady { get; set; }
    }
}
