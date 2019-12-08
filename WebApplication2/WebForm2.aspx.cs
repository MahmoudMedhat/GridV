using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridEntities gridEntities = new GridEntities();
            string Name = TextBox1.Text;

            if (!string.IsNullOrEmpty(Name.TrimStart()))
            {
                Dep dep = new Dep()
                {
                    Name = Name
                };
                gridEntities.Deps.Add(dep);
                gridEntities.SaveChanges();
                this.GridView1.DataBind();
            }
            else
            {
                Label1.Text = "U cannt enter Null Value";
            }





        }
    }
}