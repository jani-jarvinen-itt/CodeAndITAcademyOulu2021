﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OmaController : ControllerBase
    {
        public int Luku() {
            return 123;
        }
    }
}
