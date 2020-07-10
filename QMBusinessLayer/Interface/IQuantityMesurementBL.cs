//-----------------------------------------------------------------------
// <copyright file="IQuantityMesurementBL.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Amit kumar</author>
//-----------------------------------------------------------------------

using QMCommanLayer;
using QMCommanLayer.Models;
using System;
using System.Collections.Generic;
using static QMBusinessLayer.Service.Enum;

namespace QMBusinessLayer.Interface
{
    public interface IQuantityMesurementBL
    {
        /// <summary>
        /// Method to Perform Conversion.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns>Conversion of units</returns>
        QuantityMesurement ConvertQuantity(QuantityMesurement quantity);

        /// <summary>
        ///  API for Delete data
        /// </summary>
        /// <param name="Id">Delete data</param>
        /// <returns>delete data by ID</returns>
        IEnumerable<QuantityMesurement> DeleteQuntity(int Id);

        /// <summary>
        ///  API for get all emplyee details
        /// </summary>
        IEnumerable<QuantityMesurement> GetAllQuantity();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="compare"></param>
        /// <returns></returns>
        QuantityMesurementCompare AddComparison(QuantityMesurementCompare compare);
        IEnumerable<QuantityMesurementCompare> DeleteQuntityCompare(int Id);
        IEnumerable<QuantityMesurementCompare> GetAllQuantityCompare();
    }
}
