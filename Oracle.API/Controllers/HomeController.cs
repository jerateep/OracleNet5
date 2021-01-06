using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oracle.DB.Models.Oracle;
using Oracle.DB.Data;
namespace Oracle.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly OracleContext _ent;
        public HomeController(OracleContext ent)
        {
            _ent = ent;
        }
        [HttpGet]
        public List<TBL_PERSON> GetPerson()
        {
            List<TBL_PERSON> LstData = new List<TBL_PERSON>();
            LstData = _ent.TBL_PERSON.ToList();
            return LstData;
        }
    }
}
