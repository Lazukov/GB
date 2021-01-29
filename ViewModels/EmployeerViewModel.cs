using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGB.ViewModels
{
    //Обычно дублирует модель
    public class EmployeerViewModel
    {
        [Range(0,100,ErrorMessage ="Ошибка!")]
        [Display(Name="ИД")]
        public int ID { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage ="Фамилия обязательно")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Недопустимая длинна")]
        public string Surname { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя обязательно")]
        public string Name { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}
