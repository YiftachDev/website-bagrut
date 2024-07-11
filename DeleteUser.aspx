<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DeleteUser.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageTitle" Runat="Server">
    <h1>מחק את המשתמש שלך</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageContent" Runat="Server">
    <form method="post" id="loginForm" name="loginForm">
    <table>
        <tr>
            <td colspan="2">
                <button type="submit" class="btn btn-primary" name="submit">מחיקה</button>
            </td>
        </tr>
    </table>
</form>
</asp:Content>

