﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Data.Entities
{
    public class Veterinarian
    {

        [Key]
        public int VetID { get; set; }

        [StringLength(50)]
        public string LicenseNumber { get; set; }





        // Foreign Key
        [ForeignKey("Clinic")]
        public int ClinicID { get; set; }


        // Navigation property to Clinic entity
        public Clinic Clinic { get; set; }


        // Navigation properties list

        public List<PetHealthRecords>? PetHealthRecords { get; set; }
        public List<User>? Users { get; set; }

    }
}
