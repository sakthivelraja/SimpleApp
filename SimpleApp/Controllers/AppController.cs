using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleApp.Services;
using SimpleApp.Models;
using System.Net.Http;
using System.Web.Http;

namespace SimpleApp.Controllers
{
    
    [ApiController]
    public class AppController : ControllerBase
    {
        #region "Private Declarations"

        ISimpleAppService _service;

        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor with dependecy injection
        /// </summary>
        /// <param name="service"></param>
        public AppController(ISimpleAppService service)
        {
            _service = service;
        }

        #endregion

        #region "Controller Methods"
        /// <summary>
        /// This GET method gets the current date and time
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/dateChecker/getDate")]
        public ActionResult<DateRecord> Get()
        {
            try
            {

                DateRecord currentDate = new DateRecord();
                currentDate.CurrentTime = _service.GetCurrentDateTime();
                return Ok(currentDate);

            }
            catch (Exception ex)
            {
                return StatusCode(500,new ErrorInfo() { StackTrace = ex.StackTrace, ErrorMessage = ex.Message});
               
            }
        }
        #endregion

    }
}