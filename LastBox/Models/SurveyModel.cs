using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LastBox.Models
{
    public class SurveyModel
    {
        public int ID { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public int Money { get; set; }
        public bool Alcohol { get; set; }
        public bool Appearance { get; set; }
        public bool Books { get; set; }
        public bool Candles { get; set; }
        public bool Candy { get; set; }
        public bool Clothes { get; set; }
        public bool Coffee { get; set; }
        public bool Fitness { get; set; }
        public bool Games { get; set; }
        public bool Movies { get; set; }
        public bool Music { get; set; }
        public bool Sports { get; set; }
        public int Active { get; set; }
        public int Candle { get; set; }
        public int Entertainment { get; set; }
        public int foodORdrink { get; set; }
        public int Looks { get; set; }
        public static Box Box { get; set; }


    }
}