using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurysProjektDatabazeFilmu
{
    public class Film
    {
        public string Name { get; set; }

        public string Director { get; set; }

        public string Genre { get; set; }

        public int YearOfRelease { get; set; }

        public int LenghtInMin { get; set; }

        public override string ToString()
        {
            return $"Name of the film: {Name}, Director: {Director}, Genre: {Genre}, Released in: {YearOfRelease}, Lenght int minutes: {LenghtInMin}";
        }
    }
}
