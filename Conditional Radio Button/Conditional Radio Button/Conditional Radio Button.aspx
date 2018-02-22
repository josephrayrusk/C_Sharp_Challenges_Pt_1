<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conditional Radio Button.aspx.cs" Inherits="Conditional_Radio_Button.Conditional_Radio_Button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Your Note Taking Preferences</h3>
        </div>
        <asp:RadioButton ID="Pencil" runat="server" GroupName="notes" Text="Pencil" />
        <br />
        <asp:RadioButton ID="Pen" runat="server" GroupName="notes" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Pen" />
        <br />
        <asp:RadioButton ID="Phone" runat="server" GroupName="notes" Text="Phone" />
        <br />
        <asp:RadioButton ID="Tablet" runat="server" GroupName="notes" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="SUBMIT" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <p>
            <asp:Image ID="resultImage" runat="server" />
        </p>
    </form>
</body>
</html>
