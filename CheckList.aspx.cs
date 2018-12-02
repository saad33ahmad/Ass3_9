using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CheckBoxList1.Items.Add(new ListItem("Faris", "1"));
            CheckBoxList1.Items.Add(new ListItem("Muhamad", "93"));
            CheckBoxList1.Items.Add(new ListItem("Muhanad", "22"));
            CheckBoxList1.Items.Add(new ListItem("Ahmad", "10"));
            CheckBoxList1.Items.Add(new ListItem("Hassan", "19"));
        }
    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = "name:" + CheckBoxList1.SelectedItem.Text + ",id:" + CheckBoxList1.SelectedValue;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String items = "";
        foreach (ListItem item in CheckBoxList1.Items)
        {
            if (item.Selected)
            {
                items = items + ", text:" + item.Text + ", value" + item.Value;
            }
        }
        Label1.Text = items;
    }
}