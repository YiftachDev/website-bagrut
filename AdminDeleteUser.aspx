<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminDeleteUser.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageTitle" runat="Server">
    <h1>מחיקת משתמש</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageContent" runat="Server">
    <form id="form" runat="server" action="" method="post">
        <table border="0" style="width: 20%">
            <tr>
                <td>
                    <h3>תעודת זהות: </h3>
                </td>
                <td>
                    <input type="text" name="id1" />
                </td>
            </tr>

            <tr>
                <td>
                    <input type="submit" name="submit" />

                    <br />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>

