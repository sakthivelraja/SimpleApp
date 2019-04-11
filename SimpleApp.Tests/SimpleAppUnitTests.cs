using System;
using Xunit;
using SimpleApp.Controllers;
using SimpleApp.Repositories;
using SimpleApp.Services;
using SimpleApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Tests
{
    public class SimpleAppUnitTests
    {
        AppController _controller;
        ISimpleAppService _service;
        ISimpleAppRepository _repository;

        public SimpleAppUnitTests()
        {
            _repository = new SimpleAppRepository();
            _service = new SimpleAppService(_repository);
            _controller = new AppController(_service);
            
        }

        [Fact]
        public void TestGetReturnsOkResult()
        {
            var okResult = _controller.Get();

            Assert.IsType<OkObjectResult>(okResult.Result);
            
        }

        [Fact]
        public void TestGetDateTimeReturnsDateRecordType()
        {
            var output = _controller.Get().Result as OkObjectResult;

            Assert.IsType<DateRecord>(output.Value);
           
        }
    }
}
