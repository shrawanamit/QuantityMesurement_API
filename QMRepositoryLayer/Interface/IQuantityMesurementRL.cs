//-----------------------------------------------------------------------
// <copyright file="IQuantityMesurementRL.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Amit kumar</author>
//-----------------------------------------------------------------------

using QMCommanLayer;
using System.Collections.Generic;

namespace QMRepositoryLayer.Interface
{
    public interface IQuantityMesurementRL
    {
        /// <summary>
        /// Add quantity
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns>Conversion of units</returns>
        QuantityMesurement AddQuantity(QuantityMesurement quantity);

        /// <summary>
        ///  Delete data
        /// </summary>
        /// <param name="Id">Delete data</param>
        /// <returns>delete data by ID</returns>
        IEnumerable<QuantityMesurement> DeleteQuntity(int Id);

        /// <summary>
        ///  get all quantity detail
        /// </summary>
        IEnumerable<QuantityMesurement> GetAllQuantity();

    }
}
