<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleCalculator.aspx.cs" Inherits="Simple_Calculator.SimpleCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1>SIMPLE CALCULATOR</h1>
            <h4>First Value:
                <asp:TextBox ID="firstValue" runat="server"></asp:TextBox>
            </h4>
            <h4>Second Value:
                <asp:TextBox ID="secondValue" runat="server"></asp:TextBox>
            </h4>
        </div>
        <asp:Button ID="Add" runat="server" BorderColor="Black" BorderStyle="Solid" Height="30px" OnClick="Add_Click" style="background-color: #669999" Text="+" Width="40px" />
&nbsp;<asp:Button ID="Subtract" runat="server" BorderColor="Black" BorderStyle="Solid" Height="30px" OnClick="Subtract_Click" style="background-color: #CCFFFF" Text="-" Width="40px" />
&nbsp;<asp:Button ID="Multiply" runat="server" BorderColor="Black" BorderStyle="Solid" Height="30px" OnClick="Multiply_Click" style="background-color: #669999" Text="*" Width="40px" />
&nbsp;<asp:Button ID="Divide" runat="server" BorderColor="Black" BorderStyle="Solid" Height="30px" OnClick="Divide_Click" style="background-color: #CCFFFF" Text="/" Width="40px" />
        <h4>Result =
            <asp:Label ID="valueResult" runat="server" style="background-color: #C0C0C0"></asp:Label>
        </h4>
    </form>
</body>
</html>
