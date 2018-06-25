using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Memberships.Models
{
    public class DataAccessLayer
    {
        private String CS = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;

    }
}