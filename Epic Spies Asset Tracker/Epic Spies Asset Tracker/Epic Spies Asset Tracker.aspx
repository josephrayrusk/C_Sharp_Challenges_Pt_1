<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Epic Spies Asset Tracker.aspx.cs" Inherits="Epic_Spies_Asset_Tracker.Epic_Spies_Asset_Tracker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 199px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
            <br />
            Asset Performance Tracker <br />
            <br />
            Asset Name:
            <asp:TextBox ID="assetName" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections Rigged:
            <asp:TextBox ID="electionsRigged" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:
            <asp:TextBox ID="actsPerformed" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addAsset" runat="server" OnClick="Button1_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
