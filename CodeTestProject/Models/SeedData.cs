using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTestProject.Models;

namespace CodeTestProject.Models {
    public class SeedData {

        public static void Initialize(CodeTestContext context) {

            if (!context.Offer.Any()) {
                context.Offer.AddRange(new Offer[] {
                    new Offer {OfferName = "Offer 1" },
                    new Offer {OfferName = "Offer 2" }
                });

                context.SaveChanges();
            }

            if (!context.Product.Any()) {
                context.Product.AddRange(
                    new Product { Name = "Trash Bag" },
                    new Product { Name = "Trash Can"},
                    new Product { Name = "Diapers"},
                    new Product { Name = "Tin Foil" },
                    new Product { Name = "Paper" }
                );

                context.SaveChanges();
            }

            if (!context.OfferProduct.Any()) {

                context.OfferProduct.AddRange(
                    new OfferProduct { OfferName = "Offer 1", ProductID = 1 },
                    new OfferProduct { OfferName = "Offer 1", ProductID = 2 },
                    new OfferProduct { OfferName = "Offer 1", ProductID = 3 },
                    new OfferProduct { OfferName = "Offer 2", ProductID = 2 },
                    new OfferProduct { OfferName = "Offer 2", ProductID = 4 },
                    new OfferProduct { OfferName = "Offer 2", ProductID = 5 }
                );

                context.SaveChanges();
            }
            

    //        if (!context.Pr)
    //        ,  new Product[] {
    //                    new Product { ProductID = 1, Name = "Hair Gel" },
    //                    new Product { ProductID = 2, Name = "Diapers" },
    //                    new Product { ProductID = 3, Name = "Trash Bags" } }
    //new Product[] {
    //                    new Product { ProductID = 4, Name = "Hair Brush" },
    //                    new Product { ProductID = 2, Name = "Diapers" },
    //                    new Product { ProductID = 7, Name = "Trash Cans" }}
        }
    }
}
