<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageTitle" Runat="Server">
    <h1>דף בית</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageContent" Runat="Server">
     <div class="container">
         <div class="text">
             <h2>שם התלמיד: יפתח אלפסי</h2>
             <h2>שם הפרוייקט: חדשות הספורט הישראלי</h2>
             <img src="images/schoolLogo.png"/>
             <h3><a href="WhyIChose.aspx">מדוע בחרתי בנושא זה</a></h3>
         </div>
     </div>
</asp:Content>

