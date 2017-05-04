using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;


public partial class ConvertToJson : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack ==false)
        {
            List<UserInfo> mylist = new List<UserInfo>();
            mylist = GetList();
            Response.Write(JsonConvert.SerializeObject(mylist,Formatting.Indented));
        }
    }

    private List<UserInfo> GetList()
    {
        return
         new List<UserInfo>() { new UserInfo("Karen", "Chen", "email", "abd address", "helen chen")
         , new UserInfo("Karen", "Chen", "email", "abd address", "helen chen") };

    }
}