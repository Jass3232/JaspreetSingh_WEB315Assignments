using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesSports.Models
{
    public class Sports
    {
        public int ID { get; set; }
        public string Name_of_Game { get; set; }

        [DataType(DataType.Date)]
        public string Uniform_Color { get; set; }
        public int Number_of_Player { get; set; }
        public decimal First_Price { get; set; }
    }
}