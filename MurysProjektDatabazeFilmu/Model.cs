using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurysProjektDatabazeFilmu
{
    public static class Model
    {
        public static BindingList<Film> Films { get; set; } =
            new BindingList<Film>();
    }
}
