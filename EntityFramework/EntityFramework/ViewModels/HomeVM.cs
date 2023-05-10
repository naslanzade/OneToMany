using EntityFramework.Models;
using System.Collections;

namespace EntityFramework.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Features> Features { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }

        public IEnumerable<Projects> Projects { get; set; }

        public IEnumerable<Services> Services { get; set; }

        public About About { get; set; }

        public IEnumerable<AboutSecond> AboutSecond { get; set; }

        public IEnumerable<Expert> Experts { get; set; }

        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
