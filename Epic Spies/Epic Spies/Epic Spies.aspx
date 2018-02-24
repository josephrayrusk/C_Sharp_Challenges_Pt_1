<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Epic Spies.aspx.cs" Inherits="Epic_Spies.Epic_Spies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>
                <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
                <br />
                New Assignment Form</h3>
            Spy Code Name:
            <asp:TextBox ID="spyName" runat="server"></asp:TextBox>
            <br />
            New Assignment Name:
            <asp:TextBox ID="assignmentName" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            Start Date of New Assignment<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <br />
            <br />
            Projected End Date of New Assignment<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
        </div>
        <asp:Button ID="assignSpy" runat="server" OnClick="assignSpy_Click" Text="Assign" />
        <p>
            <asp:Label ID="assignment" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
