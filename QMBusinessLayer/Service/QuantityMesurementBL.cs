//-----------------------------------------------------------------------
// <copyright file="QuantityMesurementBL.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Amit kumar</author>
//-----------------------------------------------------------------------

using QMBusinessLayer.Interface;
using QMCommanLayer;
using QMRepositoryLayer.Interface;
using System;
using System.Collections.Generic;

namespace QMBusinessLayer.Service
{
    public class QuantityMesurementBL : IQuantityMesurementBL
    {
        private readonly IQuantityMesurementRL quantityMesurementRL;

        public QuantityMesurementBL(IQuantityMesurementRL dataRepository)
        {
            quantityMesurementRL = dataRepository;
        }


        public QuantityMesurement ConvertQuantity(QuantityMesurement quantity)
        {
            try
            {
                quantity.Result = CalculateConvesionValue(quantity);
                if (quantity.Result >= 0)
                {
                    return quantityMesurementRL.AddQuantity(quantity);
                }
                return quantity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        ///  API for Delete data
        /// </summary>
        /// <param name="Id">Delete data</param>
        /// <returns></returns>
        public IEnumerable<QuantityMesurement> DeleteQuntity(int Id)
        {
            try
            {
                return quantityMesurementRL.DeleteQuntity(Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        ///  API for get all details
        /// </summary>
        public IEnumerable<QuantityMesurement> GetAllQuantity()
        {
            try
            {
                return quantityMesurementRL.GetAllQuantity();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public double CalculateConvesionValue(QuantityMesurement quantity)
        {
            try
            {
                string operation = quantity.ConversionType;
                double value = quantity.Value;
                double result = quantity.Result;
                const double INCH_FEET_CONSTANT = 12;
                const double INCH_YARD_CONSTANT = 36;
                const double FEET_YARD_CONSTANT = 3;
                const double CM_INCH_CONSTANT = 2.5;
                const double WEIGHT_CONSTANT = 1000;
                const double GALLON_TO_LITRE_CONSTANT = 3.78;
                const double VOLUME_CONSTANT = 1000;
                string InchToFeet = "InchToFeet";
                string FeetToInch = "FeetToInch";
                string InchToYard = "InchToYard";
                string YardToInch = "YardToInch";
                string YardToFeet = "YardToFeet";
                string FeetToYard = "FeetToYard";
                string CentimeterToInch = "CentimeterToInch";
                string InchToCentimeter = "InchToCentimeter";
                string KilogramsToGrams = "KilogramsToGrams";
                string GramsToKilograms = "GramsToKilograms";
                string KilogramsToTonnes = "KilogramsToTonnes";
                string TonnesToKilograms = "TonnesToKilograms";
                string GallonToLitter = "GallonToLitter";
                string LitterToGallon = "LitterToGallon";
                string MililiterToLiter = "MililiterToLiter";
                string LiterToMililiter = "LiterToMililiter";
                string FahrenheitToCelsius = "FahrenheitToCelsius";
                string CelsiusToFahrenheit = "CelsiusToFahrenheit";

                if (operation.Equals(InchToFeet))
                {
                    result = value / INCH_FEET_CONSTANT;
                }
                else if (operation.Equals(FeetToInch))
                {
                    result = value * INCH_FEET_CONSTANT;
                }
                else if (operation.Equals(InchToYard))
                { 
                    result = value / INCH_YARD_CONSTANT;
                }
                else if (operation.Equals(YardToInch))
                {
                    result = value * INCH_YARD_CONSTANT;
                }
                else if (operation.Equals(YardToFeet))
                {
                    result = value * FEET_YARD_CONSTANT;
                }
                else if (operation.Equals(FeetToYard))
                {
                    result = value / FEET_YARD_CONSTANT;
                }
                else if (operation.Equals(CentimeterToInch))
                {
                    result = value / CM_INCH_CONSTANT;
                }
                else if (operation.Equals(InchToCentimeter))
                {
                    result = value * CM_INCH_CONSTANT;
                }
                else if (operation.Equals(GramsToKilograms))
                {
                    result = value / WEIGHT_CONSTANT;
                }
                else if (operation.Equals(KilogramsToGrams))
                {
                    result = value * WEIGHT_CONSTANT;
                }
                else if (operation.Equals(TonnesToKilograms))
                {
                    result = value * WEIGHT_CONSTANT;
                }
                else if (operation.Equals(KilogramsToTonnes))
                {
                    result = value / WEIGHT_CONSTANT;
                }
                else if (operation.Equals(GallonToLitter))
                {
                    result = value * GALLON_TO_LITRE_CONSTANT;
                }
                else if (operation.Equals(LitterToGallon))
                {
                    result = value / GALLON_TO_LITRE_CONSTANT;
                }
                else if (operation.Equals(MililiterToLiter))
                {
                    result = value / VOLUME_CONSTANT;
                }
                else if (operation.Equals(LiterToMililiter))
                {
                    result = value * VOLUME_CONSTANT;
                }
                else if (operation.Equals(FahrenheitToCelsius))
                {
                    result = (value - 32) * 5 / 9;
                }
                else if (operation.Equals(CelsiusToFahrenheit))
                {
                    result = (value * 9 / 5) + 32;
                }
                return Math.Round(result, 2);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
