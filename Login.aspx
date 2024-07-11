<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="pageTitle" runat="Server">
    <h1>דף התחברות</h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="pageContent" runat="Server">
    <div class="container">
        <form method="post" id="loginForm" name="loginForm">
            <table>
                <tr>
                    <td class="form-group">
                        <label for="username">שם משתמש</label>
                    </td>
                    <td class="form-group">
                        <input class="form-control" type="text" name="username" id="username" placeholder="שם משתמש" />
                    </td>
                </tr>
                <tr>
                    <td class="form-group">
                        <label for="password">סיסמא</label>
                    </td>
                    <td class="form-group">
                        <input class="form-control" type="password" name="password" id="password" placeholder="סיסמא" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <button type="submit" class="btn btn-primary" name="submit">התחברות</button>
                    </td>
                </tr>
            </table>
        </form>
    </div>
</asp:Content>
