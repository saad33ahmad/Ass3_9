using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("Faris", "1"));
            DropDownList1.Items.Add(new ListItem("Muhamad", "93"));
            DropDownList1.Items.Add(new ListItem("Muhanad", "22"));
            DropDownList1.Items.Add(new ListItem("Ahmad", "10"));
            DropDownList1.Items.Add(new ListItem("Hassan", "19"));
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = "name:" + DropDownList1.SelectedItem.Text + ",id:" + DropDownList1.SelectedValue;
    }
}