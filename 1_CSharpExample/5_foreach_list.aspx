<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
/*
 * for each loop : list
*/
	protected void Page_Load(object sender, EventArgs e)
	{
		// Use a string array to loop over.
		List<string> list = new List<string>();
		list.Add("A");
		list.Add("B");
		list.Add("C");
		list.Add("D");
		
		// Loop over list elements using foreach loop.
		foreach (string element in list)
		{
			Response.Write(element);
			Response.Write("<br/>");
		}

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
