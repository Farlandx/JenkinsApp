﻿using JenkinsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace JenkinsApp.Controllers
{
    public class HelloController : ApiController
    {
        public APITestModel Get()
        {
            var result = new APITestModel()
            {
                Message = "Auto deploy",
                Version = "1.0.2"
            };
            return result;
        }
    }
}
