//-----------------------------------------------------------------------
// <copyright file="QMController.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Amit kumar</author>
//-----------------------------------------------------------------------

namespace QuantityMesurement_API.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class QMController : ControllerBase
    {
        // GET: api/<QMCantroller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<QMCantroller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QMCantroller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QMCantroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QMCantroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
