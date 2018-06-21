using System;
using System.Collections.Generic;
using System.Text;

namespace Violet
{
    public class Registro
    {
        public Registro()
        {
            ID = new Guid();
            Data = DateTime.Now.Date;
            Hora = DateTime.Now.TimeOfDay;
            verificado = false;
            Obs = "";
        }

        public Registro(Guid iD, DateTime data, TimeSpan hora, bool verificado)
        {
            ID = iD;
            Data = data;
            Hora = hora;
            this.verificado = verificado;
            Obs = "";
        }

        public Registro(Guid iD, DateTime data, TimeSpan hora, bool verificado, string obs) : this(iD, data, hora, verificado)
        {
            Obs = obs;
        }

        public Guid ID { get; private set; }
        public DateTime Data { get; private set; }
        public TimeSpan Hora { get; private set; }
        public bool verificado { get; private set; }
        public string Obs { get; private set; }

    }
}
