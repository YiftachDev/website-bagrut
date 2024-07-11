<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchUser.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        table {
            margin: auto;
            border-collapse: collapse;
            width: 50%;
        }

        table, th, td {
            border: 1px solid #ddd;
        }

        th, td {
            padding: 12px;
        }

        th {
            background-color: #f2f2f2;
        }

        input[type="text"], input[type="submit"] {
            padding: 8px;
            margin: 5px 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageTitle" runat="Server">
    <h1>חיפוש משתמש</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageContent" runat="Server">
        <form action="" method="post">
        <table>
            <tr>
                <th colspan="2">כל המשתמשים</th>
            </tr>
            <tr>
                <td colspan="2">
                    <input type="submit" value="חיפוש" name="search-all"></td>
            </tr>
        </table>
    </form>
    <form action="" method="post">
        <table>
            <tr>
                <th colspan="2">חיפוש משתמשים לפי שם משתמש</th>
            </tr>
            <tr>
                <td>
                    <label for="username">שם משתמש:</label></td>
                <td>
                    <input type="text" id="username" name="username" placeholder="הזן שם משתמש"></td>
            </tr>
            <tr>
                <td colspan="2">
                    <input type="submit" value="חיפוש" name="search-by-username"></td>
            </tr>
        </table>
    </form>

    <form action="" method="post">
        <table>
            <tr>
                <th colspan="2">חיפוש משתמשים לפי דוא"ל</th>
            </tr>
            <tr>
                <td>
                    <label for="email">דוא"ל:</label></td>
                <td>
                    <input type="text" id="email" name="email" placeholder="הזן כתובת דואל"></td>
            </tr>
            <tr>
                <td colspan="2">
                    <input type="submit" value="חיפוש" name="search-by-email"></td>
            </tr>
        </table>
    </form>
    <form action="" method="post">
        <table>
            <tr>
                <th colspan="2">חיפוש משתמשים לפי מגדר</th>
            </tr>
            <tr>
                <td><label for="gender">מגדר:</label></td>
                <td>
                    <select id="gender" name="gender">
                        <option value="" disabled selected>בחר מגדר</option>
                        <option value="male">זכר</option>
                        <option value="female">נקבה</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2"><input type="submit" value="חיפוש" name="search-by-gender"></td>
            </tr>
        </table>
    </form>
    <%=strSearch%>

</asp:Content>

