using portfolio005.Models;

namespace portfolio005.ViewModel
{
    public class IndexVM
    {
        

        public About about { get; set; }
        public IEnumerable <Education> education { get; set; }
        public Facts facts { get; set; }
        public IEnumerable< Service> service{ get; set; }
        public IEnumerable<Skill> skill { get; set; }
        public Social social { get; set; }
        public IEnumerable <Testimonial> testimonial { get; set; }

    }
}
