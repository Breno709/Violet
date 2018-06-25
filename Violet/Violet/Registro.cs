using System;
using System.Collections.Generic;
using System.Text;

namespace Violet
{
    public class Registro
    {
        public Registro()
        {
            Nome = "";
            Data = DateTime.Now.Date;
            Hora = DateTime.Now.TimeOfDay;
            verificado = false;
            Obs = "";
        }

        public Registro(string nome, DateTime data, TimeSpan hora, bool verificado)
        {
            Nome = nome;
            Data = data;
            Hora = hora;
            this.verificado = verificado;
            Obs = "";
        }

        public Registro(string nome, DateTime data, TimeSpan hora, bool verificado, string obs) : this(nome, data, hora, verificado)
        {
            Obs = obs;
        }

        public string Nome { get; private set; }
        public DateTime Data { get; private set; }
        public TimeSpan Hora { get; private set; }
        public bool verificado { get; private set; }
        public string Obs { get; set; }

    }
}
