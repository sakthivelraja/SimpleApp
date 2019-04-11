using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleApp.Controllers;
using SimpleApp.Repositories;
using SimpleApp.Services;
using SimpleApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.MsTests
{
    [TestClass]
    public class SimpleAppMsTests
    {
        AppController _controller;
        ISimpleAppService _service;
        ISimpleAppRepository _repository;

        public SimpleAppMsTests()
        {
            _repository = new SimpleAppRepository();
            _service = new SimpleAppService(_repository);
            _controller = new AppController(_service);

        }

        [TestMethod]
        public void TestGetReturnsOkResult()
        {
            var okResult = _controller.Get();
           
            Assert.IsInstanceOfType(okResult.Result, typeof(OkObjectResult));

        }

        [TestMethod]
        public void TestGetDateTimeReturnsDateRecordType()
        {
            var output = _controller.Get().Result as OkObjectResult;

            Assert.IsInstanceOfType(output.Value, typeof(DateRecord));

        }


    }
}
