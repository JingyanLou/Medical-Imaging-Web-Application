﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_MyProject.Models
{
    public class Report
    {

        //pk
        public int id { get; set; }
        public DateTime ReportTime { get; set; }
        public string ReportContent { get; set; }

        //appointment fk
        [Required]
        public int AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public virtual Appointment Appointment { get; set; }


    }
}