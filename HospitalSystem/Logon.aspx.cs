using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace HospitalSystem
{
    public partial class Logon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

           //HospitalSystemEntities dbcontext = new HospitalSystemEntities();

            ///var user = (from userdata in dbcontext.Users
             //           where userdata.UserLoginName.Equals(Login1.UserName)
             //           where userdata.UserLoginPass.Equals(Login1.Password)
             //           select userdata).First;

            //if (true)
            //{
            //    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
            //}
        }
    }
}