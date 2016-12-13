using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GETnPOST
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string requestType = HttpContext.Current.Request.HttpMethod;

            lblRequestType.Text = requestType + "--> On page load";
           
        }

        protected void btnClickHere_Click(object sender, EventArgs e)
        {

            string requestType = HttpContext.Current.Request.HttpMethod;

            lblRequestType.Text = requestType + " --> When button is clicked / or an event is triggered within the page";
        }
    }
}