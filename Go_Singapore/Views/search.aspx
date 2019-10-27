<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Go_Singapore.Views.search1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Search Page
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="topHeader" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="homeContent" runat="server">
    <div class="row">
        <div class="col-md-9">
    <h1>Search Results</h1>
            </div>
        <div class="col-md-3 align-content-center text-center">
            Currency : 
            <asp:DropDownList Width="100%" ID="DDLCurrency" CssClass="btn btn-danger btn-sm" runat="server"></asp:DropDownList>
        </div>
    </div>





    

	

</asp:Content>
