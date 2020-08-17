using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCodeAPI.BusinessLogic.Order;
using DotNetCodeAPI.BusinessObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNetCodeAPI.Controllers_Order
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET: api/Order
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Order/5
        [HttpGet]
        [Route("Get/{companyCode}/{branchCode}/{orderNo}")]
        public IActionResult Get(string companyCode, string branchCode, int orderNo)
        {
            ErrorVM error = new ErrorVM();
            OrderMasterVM om = new OrderBL().GetOrderInfo(companyCode, branchCode, orderNo, out error);
            if (error != null)
            {
                return Content(JsonConvert.SerializeObject(error, Formatting.Indented));
            }
            return Ok(om);
        }

        // POST: api/Order
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
