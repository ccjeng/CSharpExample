<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
/*
 * for loop
*/
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
	
		#region for loop
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
