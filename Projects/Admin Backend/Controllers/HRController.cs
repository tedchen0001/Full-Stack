using System.Collections.Generic;
using Admin_Backend.Data;
using Admin_Backend.Models;
using DI.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    [Route("api/EmpInfo")]
    [ApiController]
    public class HRController : ControllerBase
    {
        private readonly IHRRepo _repository;

        public HRController(IHRRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockAdvWorksRepo _repository = new MockAdvWorksRepo();

        [HttpGet]

        public ActionResult<IEnumerable<Employee>> GetAllEmpInfo()
        {
            var employeeItem = _repository.GetAllEmpInfo();

            return Ok(employeeItem);
        }


    }
}