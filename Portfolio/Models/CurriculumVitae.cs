using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class CurriculumVitae
    {

        public int CurriculumVitaeID { get; set; }
        [Required(ErrorMessage = "Обязательно подпишите портфолио, cделав в этом поле заметку. Это поле не будет отображаться при печати")]
        public string ОписаниеПортфолиоЗаметка { get; set; }

        //Основные
        public string Желаемая_должность { get; set; }
        public Decimal Желаемая_зарплата { get; set; }
        public string Тип_работы { get; set; }
        public string Место_работы { get; set; }
        public string Дополнительная_информация_основная { get; set; }

        //Личные данные

        [Required(ErrorMessage = "Пожалуйста напишите своё имя")]
        public string Имя { get; set; }
        [Required(ErrorMessage = "Пожалуйста напишите свою фамилию")]
        public string Фамилия { get; set; }
        public string Отчество { get; set; }
        public string Пол { get; set; }
        public DateTime Дата_рождения { get; set; }
        [Required(ErrorMessage = "Пожалуйста напишите своё образование")]
        public string Образование { get; set; }
        public string Город_проживания { get; set; }
        public string Дополнительная_информация_личная { get; set; }

        //Опыт работы
        public DateTime Период_работы_c { get; set; }
        public DateTime Период_работы_по { get; set; }
        public string Должность { get; set; }
        public string Организация { get; set; }
        public string Должностные_обязаности { get; set; }
        public string Отличился { get; set; }
        public string Дополнительная_информация_опыт { get; set; }

        //Образование
        public string Учебное_заведение { get; set; }
        public DateTime Дата_окончания_образования { get; set; }
        public string Уровень_образования { get; set; }
        public string Факультет { get; set; }
        public string Специальность { get; set; }
        public string Форма_обучения { get; set; }
        public string Проявил_себя_в { get; set; }
        public string Дополнительная_информация_образование { get; set; }

        //Курсы и тренинги 
        public string Название { get; set; }
        public string Место_проведения { get; set; }
        public DateTime Дата_окончания { get; set; }
        public string Особенно_хорош_в { get; set; }
        public string Дополнительная_информация_курсы { get; set; }

        //Навыки и умения
            //Языки

            [Required(ErrorMessage = "Пожалуйста напишите на каком языке вы говорите")]
            public string Язык { get; set; }

            [Required(ErrorMessage = "Пожалуйста напишите, что он ваш родной язык")]
            public string Уровень { get; set; }
            public string Больше_даётся { get; set; }
            public string Дополнительная_информация_языки { get; set; }

            //Навыки
            public string Навык { get; set; }

        //Дополнительная информация
        public string Плохие_личные_качества { get; set; }
        public string Хорошие_личные_качества { get; set; }
        public string Дополнительная_информация_качествах { get; set; }

        //А так же
        public string Общие_дополнительные_сведенья { get; set; }

        // ------------------------------------------------------------------------------------------//

        public int Номер_резюмэ { get; set; }
        public DateTime Дата_создания { get; set; }
        public string Ссылка_на_резюмэ { get; set; }


    }
}