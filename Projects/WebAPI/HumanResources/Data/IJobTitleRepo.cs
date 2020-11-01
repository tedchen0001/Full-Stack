using System.Collections.Generic;
using HumanResources.Models;

namespace HumanResources.Data
{
    public interface IJobTitleRepo
    {
        IEnumerable<JobTitle> GetAll();
    }
}