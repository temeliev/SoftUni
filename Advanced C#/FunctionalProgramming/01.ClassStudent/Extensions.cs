using System.Collections.Generic;
using System.Linq;

namespace _01.ClassStudent
{
    public static class Extensions
    {
        public static List<Student> WeakStudents(this List<Student> list)
        {
            return list.Where(x => x.Marks.Count(y => y == 2) == 2).ToList();
        }
    }
}
