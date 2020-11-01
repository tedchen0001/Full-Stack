using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using HumanResources.Data;
using HumanResources.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HumanResources.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobTitleController : ControllerBase
    {
        private readonly IJobTitleRepo _jobTitleService;
        public JobTitleController(IJobTitleRepo jobTitleService)
        {
            _jobTitleService = jobTitleService;
        }
        // GET api/placeinfo
        [HttpGet]
        public IEnumerable<JobTitle> GetAll() =>_jobTitleService.GetAll();





    }
}