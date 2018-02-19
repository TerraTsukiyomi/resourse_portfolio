using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        //Основные
        public string Тип { get; set; }

        [Required(ErrorMessage = "Пожалуйста напишите Название")]
        public string НазваниеПортфолио  { get; set; }
        public string Автор { get; set; }
        public string Цель { get; set; }

        [Required(ErrorMessage = "Пожалуйста напишите ключевые слова")]
        public string Характеристика { get; set; }

        public string Описание { get; set; }

        public DateTime Дата_создания { get; set; }
        public string Работа { get; set; }
        public string Раздел { get; set; }
    }
}