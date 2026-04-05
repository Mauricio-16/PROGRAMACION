using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTech
{
    class CitaMedica: IPrioritario
    {
        public string Paciente { get; set;  }
        public Especialidad Especialidad { get; set; }
        public double CostoBase { get; set; }

        public CitaMedica(string paciente, Especialidad especialidad, double costoBase)
        {
            Paciente = paciente;
            Especialidad = especialidad;
            CostoBase = costoBase;
        }
        public double AplicarDescuento()
            {
                double descuento = 0.0;
                switch (Especialidad)
                {
                    case Especialidad.Pediatria:
                        descuento = 0.20; 
                        break;
                    default:
                        descuento = 0.0;
                        break;
            }
                return CostoBase * (1 - descuento);
        }
    }
}
