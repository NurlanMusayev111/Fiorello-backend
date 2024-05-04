using FiorelloSlider_OneToMany.Models;

namespace FiorelloSlider_OneToMany.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
    }
}
