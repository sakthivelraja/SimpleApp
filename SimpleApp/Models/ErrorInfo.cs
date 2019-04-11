using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Models
{
    public class ErrorInfo
    {
        private const string errMsg = "An error occured while processing your request. Please contact tech support with the following details";
        public string MessageToUser
        {
            get { return errMsg; }
        }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }
}
