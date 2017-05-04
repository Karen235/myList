using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }

    }


    void BindGrid()
    {

        GridView1.DataSource = GetDataTable();
        GridView1.DataBind();
    }

    public List<UserInfo> GetDataTable()
    {
        return new List<UserInfo>() {
              new UserInfo("Lorem","ipsum","lorem@techbrij.com","Main Street","1234567890"),
              new UserInfo("Jai","Singh","jai@techbrij.com","Jai Street","9875461230"),
              new UserInfo("Suresh","Sharma","suresh@techbrij.com","Suresh Street","8844669950"),
              new UserInfo("Ram","Kashyap","ram@techbrij.com","Ram Street","1112223330"),
              new UserInfo("Lokesh","Viswa","lokesh@techbrij.com","Lokesh Street","1234567890"),
              new UserInfo("Jojo","Nath","jojo@techbrij.com","JoJo Street","2225558690"),
              new UserInfo("John","Doe","john@techbrij.com","John Street","3216549870"),
              new UserInfo("Jasmine","Yo","jasmine@techbrij.com","Jasmine Street","9874561230")
      };
    }
}