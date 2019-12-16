using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.Entity;

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
            HospitalSystemEntities1 entities = new HospitalSystemEntities1();

            string givenUser = Login1.UserName;
            string givenPass = Login1.Password;

            List<User> potentialUsers = (
                from user in entities.Users
                where
                    user.UserLoginName == givenUser &&
                    user.UserLoginPass == givenPass
                select user).ToList();

            if (potentialUsers.Count > 0)
            {
                Session["user"] = givenUser;

                string type = potentialUsers[0].UserLoginType.Trim();
                
                if (type == "doctor")
                {
                    Response.Redirect("~/Doctor/DoctorHome.aspx");
                    return;
                } else if (type == "patient")
                {
                    Response.Redirect("~/Patient/PatientHome.aspx");
                    return;
                }
            }
        }
    }
}