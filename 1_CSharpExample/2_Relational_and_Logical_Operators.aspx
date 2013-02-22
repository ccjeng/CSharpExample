<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = 20;
        int y = 10;

        Response.Write("<br>x == 20:");
        Response.Write(x == 20);

        Response.Write("<br>x == 30:");
        Response.Write(x == 30);

        Response.Write("<br>x != 20:");
        Response.Write(x != 20);

        Response.Write("<br>x != 30:");
        Response.Write(x != 30);

        Response.Write("<br>x > y:");
        Response.Write(x > y);
        
        Response.Write("<br>y > x:");
        Response.Write(y > x);

        Response.Write("<br>x >= y:");
        Response.Write(x >= y);
        
        Response.Write("<br>y >= x:");
        Response.Write(y >= x);
        
        Response.Write("<br>x < y:");
        Response.Write(x < y);

        Response.Write("<br>y < x:");
        Response.Write(y < x);
        
        Response.Write("<br>x <= y:");
        Response.Write(x <= y);
        
        Response.Write("<br>y <= x:");
        Response.Write(y <= x);
        
        //&& AND 兩個運算式都為true時結果才為true
        Response.Write("<br>(x == 20) && (y == 30)");
        Response.Write((x == 20) && (y == 30));

        //& AND 兩個運算式都為true時結果才為true
        //前後兩個判斷都會執行
        Response.Write("<br>(x == 20) & (y == 30)");
        Response.Write((x == 20) & (y == 30));

        //|| OR 至少一個運算式為true時結果才為true
        Response.Write("<br>(x == 20) || (y == 30):");
        Response.Write((x == 20) || (y == 30));

        //| OR 至少一個運算式為true時結果才為true
        Response.Write("<br>(x == 20) | (y == 30):");
        Response.Write((x == 20) | (y == 30));

        //^ XOR 兩個運算式的結果不同時結果才為true
        Response.Write("<br>(x == 20) ^ (y == 30):");
        Response.Write((x == 20) ^ (y == 30));
        
        Response.Write("<br>!(x == 30):");
        Response.Write(!(x == 30));

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
