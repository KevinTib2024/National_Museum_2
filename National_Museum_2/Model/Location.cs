﻿using Microsoft.Identity.Client;
using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Location
    {
        public int locationId { get; set; }

        public required string name { get; set; }

        public List <ArtRoom> artRooms { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
