using FronToBack.Models;
using System.Collections.Generic;

namespace FronToBack.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderContent SliderContent { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<FiorelloMiddle> FiorelloMiddles { get; set; }
    }
}
