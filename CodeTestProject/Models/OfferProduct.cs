using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTestProject.Models {
    public class OfferProduct {
        public int OfferProductID { get; set; }
        public string OfferName { get; set;  }
        public int ProductID { get; set; }

        public Offer Offer { get; set; }
        public Product Product { get; set; }

    }
}
