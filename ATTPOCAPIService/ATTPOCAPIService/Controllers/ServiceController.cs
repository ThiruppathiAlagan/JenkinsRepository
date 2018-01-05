using ATTPOCAPIService.Mock;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ATTPOCAPIService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ServiceController : ApiController
    {
        // GET api/service/NER-RVWV-11-00994      
        public object Get(string id)
        {
            AtollData atoll = new AtollData();
            var resp = atoll.getSearchRings(id);         
            JsonConvert.SerializeObject(resp);
            return Request.CreateResponse(HttpStatusCode.OK, resp);        
            
        }
        // GET api/service/     
        public object Get()
        {
            AtollData atoll = new AtollData();
            var resp = atoll.getSearchRings();
            JsonConvert.SerializeObject(resp);
            return Request.CreateResponse(HttpStatusCode.OK, resp); 
        }

        [HttpGet]
        [Route("api/Sarf/Get/{sarf}")]
        public HttpResponseMessage PostSarf(string sarf)
        {
            return null;

        }

        // POST api/service
        public void Post([FromBody]string value)
        {
        }

        // PUT api/service/5
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE api/service/5
        public void Delete(int id)
        {
        }
        
    }
}
