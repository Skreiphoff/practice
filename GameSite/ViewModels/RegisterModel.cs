using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSite.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Не указан никнейм")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Не указан любимый жанр")]
        public string Love_tag { get; set; }

        [Required(ErrorMessage = "Не указана дата рождения")]
        public DateTime Date_of_issue { get; set; }

        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указан Эмейл")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string PasswordConfirm { get; set; }
    }
}
