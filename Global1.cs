using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace OdeToFood
{
    public static class Global1
    {
        public static void InitializeDatabaseConnection()
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", 
                "UserProfile", "UserId", "UserName", autoCreateTables: true);
        }
    }
}