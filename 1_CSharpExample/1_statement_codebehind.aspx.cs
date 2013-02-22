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
        // Array of testing.
        string[] array =
	   {
			"A",
			"B",
			"C",
			"D"
		};

        #region for-loop
        // Loop through string array with a for loop.
        Response.Write("For loop example <br/>");
        for (int i = 0; i < array.Length; i++)
        {
            Response.Write(array[i] + "<br/>");
        }

        #endregion

        // switch
        #region switch
        Response.Write("switch example <br/>");
        int value = 5;
        switch (value)
        {
            case 1:
                Response.Write(1);
                break;
            case 5:
                Response.Write(5);
                break;
        }
        #endregion
    }
}