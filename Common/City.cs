using System.Collections.Generic;

namespace Project1.Education
{
    public class City
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public List<Street> Street { get; set; }
    }
}