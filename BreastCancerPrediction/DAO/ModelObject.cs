using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreastCancerPrediction.DAO
{
    
        public class ModelObject
        {
        public string error { get; set; }
        public string model { get; set; }
        public string message { get; set; }
        public float Benign { get; set; }
        public float InSitu { get; set; }
        public float Invasive { get; set; }
        public float Normal { get; set; }
        public string result { get; set; }
        public float accuracy { get; set; }
    
}
    
}
