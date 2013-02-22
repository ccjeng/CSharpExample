<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
/*
 *  x ?: y : z
 *  ??
*/
    protected void Page_Load(object sender, EventArgs e)
	{
        int i = 60;
        //Response.Write("x ?: y : z");
        
        if (i >= 60) 
        {
            Response.Write("Pass");
        }
        else 
        {
            Response.Write("Fail");
        }
        
        Response.Write("<br/>");
        
        //x ?: y : z
        Response.Write(i >= 60 ? "Pass" : "Fail");

        Response.Write("<br/>");
        Response.Write("<br/>");


	}
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
