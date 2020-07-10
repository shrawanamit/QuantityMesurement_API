//-----------------------------------------------------------------------
// <copyright file="QMController.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Amit kumar</author>
//-----------------------------------------------------------------------

namespace QuantityMesurement_API.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using QMBusinessLayer.Interface;
    using QMCommanLayer;
    using QMCommanLayer.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class QMController : ControllerBase
    {
        private readonly IQuantityMesurementBL _dataBL;

        public QMController(IQuantityMesurementBL dataRepository)
        {
            _dataBL = dataRepository;
        }

        [HttpPost]
        public IActionResult Convert(QuantityMesurement quantityMesurement)
        {
            try
            {
                var result = _dataBL.ConvertQuantity(quantityMesurement);
                //if entry is not equal to null
                if (!result.Equals(null))
                {
                    var Success = "True";
                    var Message = "New Entry Added Sucessfully";
                    return this.Ok(new { Success, Message, data = result });
                }
                else                                              //Entry is not added
                {
                    var Success = "False";
                    var Message = "New Entry is not Added";
                    return this.BadRequest(new { Success, Message, data = quantityMesurement });
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(new { Success = false, Message = e.Message });
            }
        }

        /// <summary>
        ///  API for Delete data
        /// </summary>
        /// <param name="Id">Delete data</param>
        /// <returns>delete data by ID</returns>
        [HttpDelete("{QuantityId}")]
        public IActionResult DeleteQuntity(int QuantityId)
        {
            try
            {
                var result = _dataBL.DeleteQuntity(QuantityId);
                //if result is not equal to zero then details Deleted sucessfully
                if (!result.Equals(null))
                {
                    var Success = "True";
                    var Message = "Data deleted Sucessfully of Data equal to Id";
                    return this.Ok(new { Success, Message, DataId = QuantityId });
                }
                else                                           //Data is not deleted 
                {
                    var Success = "False";
                    var Message = "Data is not deleted Sucessfully";
                    return this.BadRequest(new { Success, Message, Data = QuantityId });
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(new { Success = false, Message = e.Message });
            }
        }

        /// <summary>
        ///  API for get all emplyee details
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<QuantityMesurement>> GetAllQuantity()
        {
            try
            {
                var result = _dataBL.GetAllQuantity();
                if (!result.Equals(null))
                {
                    var Success = "True";
                    var Message = "All Conversion Data";
                    return this.Ok(new { Success, Message, Data = result });
                }
                else                                           //Data is not found
                {
                    var Success = "False";
                    var Message = "Data is not found";
                    return this.BadRequest(new { Success, Message, Data = result });
                }

            }
            catch (Exception e)
            {
                return this.BadRequest(new { Success = false, Message = e.Message });
            }
        }

        [HttpPost]
        [Route("compare")]
        public IActionResult AddComparison([FromBody] QuantityMesurementCompare compare)
        {
            try
            {
                var result = _dataBL.AddComparison(compare);
                //if entry is not equal to null
                if (!result.Equals(null))
                {
                    var Success = "True";
                    var Message = "New Entry Added Sucessfully";
                    return this.Ok(new { Success, Message, data = result });
                }
                else                                              //Entry is not added
                {
                    var Success = "False";
                    var Message = "New Entry is not Added";
                    return this.BadRequest(new { Success, Message, data = compare });
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(new { Success = false, Message = e.Message });
            }
        }

        /// <summary>
        ///  API for Delete data
        /// </summary>
        /// <param name="Id">Delete data</param>
        /// <returns>delete data by ID</returns>
        //[HttpDelete("{QuantityId}")]
        //[Route("compare")]
        //public IActionResult DeleteCompare(int QuantityId)
        //{
        //    try
        //    {
        //        var result = _dataBL.DeleteQuntityCompare(QuantityId);
        //        //if result is not equal to zero then details Deleted sucessfully
        //        if (!result.Equals(null))
        //        {
        //            var Success = "True";
        //            var Message = "Data deleted Sucessfully of Data equal to Id";
        //            return this.Ok(new { Success, Message, DataId = QuantityId });
        //        }
        //        else                                           //Data is not deleted 
        //        {
        //            var Success = "False";
        //            var Message = "Data is not deleted Sucessfully";
        //            return this.BadRequest(new { Success, Message, Data = QuantityId });
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return this.BadRequest(new { Success = false, Message = e.Message });
        //    }
        //}

        /// <summary>
        ///  API for get all emplyee details
        /// </summary>
        [HttpGet]
        [Route("compare")]
        public ActionResult<IEnumerable<QuantityMesurementCompare>> GetAllQuantityCompare()
        {
            try
            {
                var result = _dataBL.GetAllQuantityCompare();
                if (!result.Equals(null))
                {
                    var Success = "True";
                    var Message = "All Compare Data";
                    return this.Ok(new { Success, Message, Data = result });
                }
                else                                           //Data is not found
                {
                    var Success = "False";
                    var Message = "Data is not found";
                    return this.BadRequest(new { Success, Message, Data = result });
                }

            }
            catch (Exception e)
            {
                return this.BadRequest(new { Success = false, Message = e.Message });
            }
        }



    }
}
