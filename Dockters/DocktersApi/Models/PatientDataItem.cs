using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class PatientDataItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Measurement> Measurements { get; set; }
    }

    public class Measurement
    {
        public double Temperature { get; set; }
        public int Systole { get; set; }
        public int Diastole { get; set; }
        public DateTime Timestamp { get; set; }
    }
}