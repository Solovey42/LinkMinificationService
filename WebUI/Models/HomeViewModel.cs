using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class IndexViewModel
    {
        public List<Link> Links { get; set; }

        [Required(ErrorMessage = "Не была введена ссылка!")]
        [RegularExpression(@"(https?:\/\/|ftps?:\/\/|www\.)((?![.,?!;:()]*(\s|$))[^\s]){2,}", ErrorMessage = "Некорректный адрес")]
        public string LongAddress { get; set; }

        public int? SelectedProductId { get; set; }

        public IndexViewModel(List<Link> links)
        {
            Links = links;
        }
        public IndexViewModel()
        {
        }
    }
}
