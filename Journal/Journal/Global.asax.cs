using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Journal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            string conStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try {
                    conn.Open(); // throws if invalid
                    System.Diagnostics.Debug.WriteLine("DB connection is success");
                }
                catch (SqlException sqe)
                {
                    System.Diagnostics.Debug.WriteLine("DB connection is invalid: ", sqe.Message);
                }
                finally
                {
                    try
                    {
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("DB connection error message: ", ex.Message);
                    }
                }
            }
            
           
        }
    }
}
