using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }  
        
        public string Local { get; set; }

        public int NumP {  get; set; }
        public int Custa { get; set; }
        public int Custo { 
            get 
            {
                return Custa * NumP;
            }
        }

        public int Duracao
        {
            get
            {
               TimeSpan Dur = Fim - Inicio;
                return Dur.Days;
            }


        }
    }
}
