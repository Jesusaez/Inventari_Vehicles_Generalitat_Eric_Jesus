using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventari_Vehicles_Generalitat.CLASSES
{
    public class Vehicle
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipusDret { get; set; }
        public DateTime DataAltaInv { get; set; }
        public string Denominacio { get; set; }  
        public string tipusCombustible { get; set; }
    }

}
