using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureDescription { get; set; }
    }
}