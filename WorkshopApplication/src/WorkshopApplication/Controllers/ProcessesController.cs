using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WorkshopApplication.Models;
using System.Diagnostics;
using System.Linq;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkshopApplication.Controllers
{
    [Route("api/[controller]")]
    public class ProcessesController : Controller
    {
        [HttpGet]
        public IEnumerable<ProcessInfo> Get()
        {
            var processList = Process.GetProcesses().OrderBy(p => p.ProcessName).ToList();

            return processList.Select(p => new ProcessInfo() { Name = p.ProcessName });
        }
    }
}
