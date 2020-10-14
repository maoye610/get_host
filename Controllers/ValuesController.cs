using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace GetHostApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            string userIP;
            HttpRequest Request = HttpContext.Current.Request;
            if (Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != "")
                userIP = Request.ServerVariables["REMOTE_ADDR"];
            else
                userIP = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (userIP == null || userIP == "")
                userIP = Request.UserHostAddress;

            return userIP;
        }
    }
}
