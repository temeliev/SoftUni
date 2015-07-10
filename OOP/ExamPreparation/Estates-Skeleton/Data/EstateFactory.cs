﻿using Estates.Engine;
using Estates.Interfaces;
using System;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new ExtendedEstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment: return new Apartment();
                case EstateType.Office: return new Office();
                case EstateType.House: return new House();
                case EstateType.Garage: return new Garage();
            }

            return new Estate(type);
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Sale: return new SaleOffer();
                case OfferType.Rent: return new RentOffer();
            }

            return new Offer(type);
        }
    }
}
