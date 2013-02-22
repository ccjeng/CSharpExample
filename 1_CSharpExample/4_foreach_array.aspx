<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
/*
 * for each loop : array
*/
	protected void Page_Load(object sender, EventArgs e)
	{
		// Use a string array to loop over.
		string[] array =
		{
			"A",
			"B",
			"C",
			"D"
		};
		// Loop with the foreach keyword.
		foreach (string value in array)
		{
			Response.Write(value);
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
