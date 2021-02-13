using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTestProject.Models {
    public interface IProductSearchService {
        Task<List<Offer>> GetOffersWithProduct(ICollection<Offer> offers, string prodSearchString);
    }

    public class ProductSearchService : IProductSearchService {
        
        public async Task<List<Offer>> GetOffersWithProduct(ICollection<Offer> offers, string prodSearchString) {
            List<Offer> retVal = new List<Offer>();

            foreach(Offer o in offers) {
                foreach(var op in o.OfferProducts) {
                    if (op.Product.Name.Contains(prodSearchString))
                        retVal.Add(o);
                }
            }

            return retVal;
        }
    }

}
