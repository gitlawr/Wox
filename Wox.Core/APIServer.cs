﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wox.Core
{
    public static class APIServer
    {
        private static string BaseAPIURL = "http://api.getwox.com";
        public static string ErrorReportURL = BaseAPIURL + "/error/";
        public static string LastestReleaseURL = BaseAPIURL + "/release/latest/";
    }
}
