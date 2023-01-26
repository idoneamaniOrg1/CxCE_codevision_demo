using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CxCE_Demo
{

<<<<<<< HEAD

class PasswordExample
{
    public static string GetPassword()
    {
        return ConfigurationManager.AppSettings["password"];
    }
}

    class Constants
    {
        public static string DB_PASSWORD = PasswordExample.GetPassword();
=======
    class Constants
    {
       public static string DB_PASSWORD = "Checkmarx123!";
>>>>>>> 5ec232b84ef098890790b34df1ce489b18601000
    }
}
