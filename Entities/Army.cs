﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandConquest.Entities
{
    public class Army
    {
        [Required]
        [Column("player_id")]
        [StringLength(16)]
        public string PlayerId { get; set; }

        [Required]
        [Column("army_id")]
        [StringLength(16)]
        public string ArmyId { get; set; }

        [Column("army_size_current")]
        public int ArmySizeCurrent { get; set; }

        [Required]
        [Column("army_type")]
        public int ArmyType { get; set; }

        [Column("army_archers_count")]
        public int ArmyArchersCount { get; set; }

        [Column("army_infantry_count")]
        public int ArmyInfantryCount { get; set; }

        [Column("army_horseman_count")]
        public int ArmyHorsemanCount { get; set; }

        [Column("army_siegegun_count")]
        public int ArmySiegegunCount { get; set; }

        [Column("local_land_id")]
        public int LocalLandId { get; set; }
    }
}