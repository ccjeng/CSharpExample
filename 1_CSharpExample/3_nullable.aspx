<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
/*
 * null
 * 
 */
    protected void Page_Load(object sender, EventArgs e)
    {      /*
        int? x = null; //x can be null  
        x = 10;
        
        if (x.HasValue)
        {
            Response.Write(x.Value);
        }
        else
        {
            Response.Write("X is null <br/>");
        }
        */
        
          /*
        DateTime? y = null;
        if (!y.HasValue)
        {
            Response.Write("Y is null <br/>");
        }  
             */


        int? nx = null;
        Response.Write("<br>");
        Response.Write(nx ?? -1);
        nx = 10;
        Response.Write("<br>");
        Response.Write(nx ?? -1);
        
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
