using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTATA.ViewModel
{
    public class TextToCountWordsViewModel
    {
        [Display(Name = "Texto")]
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        [StringLength(10000)]
        public string Text { get; set; }

        [Display(Name = "Palabra que desea contar")]
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Word { get; set; }

        [Display(Name = "Resultado:")]
        public string Result { get; set; }
    }
}
