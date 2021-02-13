using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeTestProject.Models {
    public class Offer {

        
        [Key]
        public string OfferName { get; set; }

        ICollection<OfferProduct> _validProducts;

        [Display(Name = "Products")]
        public ICollection<OfferProduct> OfferProducts {
            get { return _validProducts ?? (_validProducts = new List<OfferProduct>()); }
            set { _validProducts = value; }
        }

      
    }
}
