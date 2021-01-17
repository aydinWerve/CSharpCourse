using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class CourseManager//internal ile o proje içinde istediğimiz noktadan çağırabiliriz
    {
        public void Add()
        {
            Course course = new Course();
        }
    }
}
