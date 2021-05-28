﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.EntityFramework
{
    public class HomePage
    {
        [Key]
        public int ID { get; set; }
        public string Heading { get; set; }
        public int Description { get; set; }
    }
}