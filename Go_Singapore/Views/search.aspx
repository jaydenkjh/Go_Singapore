<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Go_Singapore.Views.search1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Search Page
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="topHeader" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="homeContent" runat="server">
    <div class="row">
        <div class="col-md-8">
            <h1>Search Results</h1>
        </div>
        <div class="col-md-2 align-content-center text-center">
            Travel Style : 
            <asp:DropDownList Width="100%" ID="DDLStyle" CssClass="btn btn-danger btn-sm" runat="server">
                <asp:ListItem>Budget</asp:ListItem>
                <asp:ListItem>Mid-Range</asp:ListItem>
                <asp:ListItem>Luxury</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-md-2 align-content-center text-center">
            Currency : 
            <asp:DropDownList Width="100%" ID="DDLCurrency" CssClass="btn btn-danger btn-sm" runat="server" AutoPostBack="True" OnTextChanged="DDLCurrency_TextChanged"></asp:DropDownList>
        </div>
    </div><br />
        <style>
         .weatherBox{
             height:200px;border:1px solid black;
         }
         .weatherBox i{
             font-size:120px;
         }
         .weatherBox .boxTitle
         {
             font-size:15px;
             font-weight:bold;
         }
         .weatherBox .cost
         {
             font-size:16px;
             color:darkblue;
            
         }
     </style>

    
        <div class="row ftco-animate align-content-center text-center">
          <div class="col-md-12 heading-section ftco-animate">
            <h2 class="mb-4"><strong>Average Cost</strong> a day</h2>
          </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Accommodation</p>
               <i class="fas fa-home"></i><br />
               <asp:Label ID="lblCost1" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Transportation</p>
               <i class="fas fa-train"></i><br />
               <asp:Label ID="lblCost2" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Food</p>
               <i class="fas fa-utensils"></i><br />
               <asp:Label ID="lblCost3" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Entertainment</p>
               <i class="fas fa-ticket-alt"></i><br />
               <asp:Label ID="lblCost4" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Water</p>
               <i class="fas fa-water"></i><br />
               <asp:Label ID="lblCost5" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Overall</p>
               <i class="fas fa-money-bill-wave"></i><br />
               <asp:Label ID="lblCost6" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
       </div>

   





    

	

</asp:Content>
