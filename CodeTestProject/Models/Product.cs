using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTestProject.Models {
    public class Product {

        public int ProductID { get; set; }

        public string Name { get; set; }

        public ICollection<OfferProduct> OfferProducts { get; set; }
    }
}
