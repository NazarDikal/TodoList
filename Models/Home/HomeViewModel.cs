using System.ComponentModel.DataAnnotations;
using TodoList.Domain.Entities;

namespace TodoList.Models.Home
{
    public class HomeViewModel
    {
        [Required(ErrorMessage ="Дане поле є обов'язковим")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "Дане поле є обов'язковим")]
        public DateTime? DateTime { get; set; }

        public IEnumerable<TaskApp>? Tasks { get; set; }
    }
}
