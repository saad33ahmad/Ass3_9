using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calculate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double n1 = Convert.ToDouble(txtn1.Text);
        double n2 = Convert.ToDouble(txtn2.Text);
        laresult.Text = (n1 + n2).ToString();
    }
}