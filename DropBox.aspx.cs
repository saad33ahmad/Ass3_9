using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropBox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ListBox1.Items.Add(new ListItem("Faris", "1"));
            ListBox1.Items.Add(new ListItem("Muhamad", "93"));
            ListBox1.Items.Add(new ListItem("Muhanad", "22"));
            ListBox1.Items.Add(new ListItem("Ahmad", "10"));
            ListBox1.Items.Add(new ListItem("Hassan", "19"));
        }
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = "name:" + ListBox1.SelectedItem.Text + ",id:" + ListBox1.SelectedValue;
    }
}