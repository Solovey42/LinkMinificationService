using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class IndexViewModel
    {
        public List<Link> Links { get; set; }

        [Required(ErrorMessage = "�� ���� ������� ������!")]
        [RegularExpression(@"(https?:\/\/|ftps?:\/\/|www\.)((?![.,?!;:()]*(\s|$))[^\s]){2,}", ErrorMessage = "������������ �����")]
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
