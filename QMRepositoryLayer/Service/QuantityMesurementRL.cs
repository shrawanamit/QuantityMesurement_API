//-----------------------------------------------------------------------
// <copyright file="QuantityMesurementRL.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Amit kumar</author>
//-----------------------------------------------------------------------
using QMCommanLayer;
using QMCommanLayer.Models;
using QMRepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QMRepositoryLayer.Service
{
    public class QuantityMesurementRL: IQuantityMesurementRL
    {

        readonly QuantityMesurementContext _QuantityMesurementContext;

        public QuantityMesurementRL(QuantityMesurementContext quantityMesurementContext)
        {
            _QuantityMesurementContext = quantityMesurementContext;
        }

        /// <summary>
        /// Method to Add Conversion Detail to Database.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns>Conversion result</returns>
        public QuantityMesurement AddQuantity(QuantityMesurement quantity)
        {
            try
            {
                //add Data in database
                _QuantityMesurementContext.QuantityMesurementTable.Add(quantity);
                //saves all changes in database
                _QuantityMesurementContext.SaveChanges();
                return quantity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Method to Add Conversion Detail to Database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Conversion result</returns>
        public IEnumerable<QuantityMesurement> DeleteQuntity(int Id)
        {
            try
            {
                List<QuantityMesurement> quantity = _QuantityMesurementContext.QuantityMesurementTable.ToList();
                var itemToRemove = quantity.SingleOrDefault(x => x.Id==Id);
                if (itemToRemove != null)
                {
                    //Remove Data in database
                    _QuantityMesurementContext.QuantityMesurementTable.Remove(itemToRemove);
                    //saves all changes in database
                    _QuantityMesurementContext.SaveChanges();
                }
                return quantity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Method To Get All Convserion Details.
        /// </summary>
        public IEnumerable<QuantityMesurement> GetAllQuantity()
        {
            try
            {
                return _QuantityMesurementContext.QuantityMesurementTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
