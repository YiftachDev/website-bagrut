<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditPassword.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageTitle" runat="Server">
    <h1>שינוי סיסמא</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageContent" runat="Server">

<form id="editUserForm" action="" method="post">
    <table style="width: 20%; border-collapse: collapse;">
        <tr>
            <td>
                <label for="uNameEdit">שם משתמש</label>
            </td>
            <td>
                <input type="text" id="uNameEdit" name="uNameEdit" />
            </td>
        </tr>

        <tr>
            <td>
                <label for="oldPassEdit">סיסמה נוכחית</label>
            </td>
            <td>
                <input type="password" id="oldPassEdit" name="oldPassEdit" />
            </td>
        </tr>

        <tr>
            <td>
                <label for="newPassEdit">סיסמה חדשה</label>
            </td>
            <td>
                <input type="password" id="newPassEdit" name="newPassEdit" />
            </td>
        </tr>
        
        <tr>
            <td>
                <label for="newPassConfirmEdit">אימות סיסמה </label>
            </td>
            <td>
                <input type="password" id="newPassConfirmEdit" name="newPassConfirmEdit" />
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <input type="submit" id="submitEdit" name="submitEdit" value="עדכן" />
            </td>
        </tr>
    </table>
</form>

</asp:Content>

