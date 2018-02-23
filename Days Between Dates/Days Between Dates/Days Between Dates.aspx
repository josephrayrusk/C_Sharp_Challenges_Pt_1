<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Days Between Dates.aspx.cs" Inherits="Days_Between_Dates.Days_Between_Dates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How may days have elapsed?<br />
            <br />
            Choose a Date:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            Choose a Second Date<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <br />
        </div>
        <asp:Button ID="daysButton" runat="server" OnClick="Button1_Click" Text="Days Elsapsed" />
        <br />
        <br />
        <asp:Label ID="elapsedDays" runat="server"></asp:Label>
    </form>
</body>
</html>
