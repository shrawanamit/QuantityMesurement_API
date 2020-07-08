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
    using QMRepositoryLayer.Interface;
    using static QMBusinessLayer.Service.Enum;

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
    }
}
