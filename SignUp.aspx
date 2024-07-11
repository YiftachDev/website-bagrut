<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="pageTitle" runat="Server">
    <h1>דף הרשמה</h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="pageContent" runat="Server">
    <div class="container">
        <form method="post" id="signUpForm" name="signUpForm">
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
                        <label for="password1">סיסמא</label>
                    </td>
                    <td class="form-group">
                        <input class="form-control" type="password" name="password1" id="password1" placeholder="סיסמא" />
                    </td>
                </tr>
                <tr>
                    <td class="form-group">
                        <label for="email">מייל</label>
                    </td>
                    <td class="form-group">
                        <input class="form-control" type="email" name="email" id="email" placeholder="מייל" />
                    </td>
                </tr>
                <tr>
                    <td class="form-group">
                        <label for="id1">תעודת זהות</label>
                    </td>
                    <td class="form-group">
                        <input class="form-control" type="text" name="id1" id="id1" placeholder="תעודת זהות" />
                    </td>
                </tr>
                <tr>
                    <td class="form-group">
                        <label for="birthYear">שנת לידה</label>
                    </td>
                    <td class="form-group">
                        <input class="form-control" type="number" name="birthYear" id="birthYear" placeholder="שנת לידה" />
                    </td>
                </tr>
                <tr>
                    <td class="form-group">
                        <label>מגדר</label>
                    </td>
                    <td class="form-group">
                        <input class="form-control" type="radio" name="gender" id="male" value="male" />
                        <label class="form-check-label" for="male">זכר</label>
                        <input class="form-control" type="radio" name="gender" id="female" value="female" />
                        <label class="form-check-label" for="female">נקבה</label>
                    </td>
                </tr>
                <tr>
                    <td class="form-group">
                        <label for="favoriteSport">ספורט אהוב</label>
                    </td>
                    <td class="form-group">
                        <select class="form-control" id="favoriteSport" name="favoriteSport">
                            <option value="" disabled selected>בחר ספורט</option>
                            <option value="football">כדורגל</option>
                            <option value="basketball">כדורסל</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class="form-group form-check">
                        <label class="form-check-label" for="verify">אימות</label>
                    </td>
                    <td class="form-group form-check">
                        <input class="form-check-input" type="checkbox" name="verify" id="verify" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <button type="submit" name="submit"class="btn btn-primary">שליחה</button>
                    </td>
                </tr>
            </table>
        </form>
    </div>
</asp:Content>
