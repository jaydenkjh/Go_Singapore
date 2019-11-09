<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Go_Singapore.Views.search1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Search Page
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="topHeader" runat="server">
   <div class="block-17 my-4">
              <div class="d-block d-flex">
                <div class="fields d-block d-flex">
                  <div class="select-wrap one-third">
                    <div class="icon"><span class="ion-ios-arrow-down"></span></div>
                      <asp:DropDownList ID="DDLCountry" CssClass="form-control" runat="server" placeholder="Keyword search"></asp:DropDownList>
                  </div>
				  <div class="select-wrap one-third">
                      <asp:TextBox ID="txtArrival" runat="server" CssClass="form-control" placeholder="Arrvial Date (DD/MM/YY)"></asp:TextBox>
                  </div>
				 <div class="select-wrap one-third">
                     <asp:TextBox ID="txtDeparture" runat="server" CssClass="form-control" placeholder="Departure Date (DD/MM/YY)"></asp:TextBox>
                  </div>
				
                </div>
                  <asp:Button ID="btnSearch" CssClass="search-submit btn btn-primary" runat="server" Text="Search" OnClick="btnSearch_Click" />
                		
              </div>
            </div>
             <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="False"></asp:Label><br />
			<input type="checkbox" name="vehicle" value="Bike"> Direct Flight Only<br>
			
			<br><br>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="homeContent" runat="server">
    <div class="row">
        <div class="col-md-8">
            <h1>Search Results</h1>
        </div>
        <div class="col-md-2 align-content-center text-center">
            Travel Style : 
            <asp:DropDownList Width="100%" ID="DDLStyle" CssClass="btn btn-danger btn-sm" runat="server" AutoPostBack="True" OnTextChanged="DDLStyle_TextChanged">
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
         @media only screen and (max-width: 1300px) {
         .weatherBox i {
                 font-size:100px;
             }
         }
         @media only screen and (max-width: 1000px) {
             .weatherBox i {
                     font-size:80px;
                 }
             .weatherBox .boxTitle
             {
                 font-size:11px;
                 font-weight:bold;
             }
             .weatherBox{
                 height:160px;
              }
         }


         


         .weatherBox .cost
         {
             font-size:16px;
             color:darkblue;
            
         }
     </style>

    
        <div class="row ftco-animate align-content-center text-center">
          <div class="col-md-12 heading-section ftco-animate">
            <h2 class="mb-4"><strong>Total </strong>Cost</h2>
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
           <br /><br />
            <div class="col-md-12 heading-section ftco-animate">
            <h2 class="mb-4"><strong>Average Cost</strong> a day</h2>
          </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Accommodation</p>
               <i class="fas fa-home"></i><br />
               <asp:Label ID="Label1" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Transportation</p>
               <i class="fas fa-train"></i><br />
               <asp:Label ID="Label2" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Food</p>
               <i class="fas fa-utensils"></i><br />
               <asp:Label ID="Label3" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Entertainment</p>
               <i class="fas fa-ticket-alt"></i><br />
               <asp:Label ID="Label4" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Water</p>
               <i class="fas fa-water"></i><br />
               <asp:Label ID="Label5" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-md-2">
               <p class="boxTitle">Overall</p>
               <i class="fas fa-money-bill-wave"></i><br />
               <asp:Label ID="Label6" CssClass="cost" runat="server" Text="Condition1"></asp:Label>
           </div>


       </div>

   





    

	

</asp:Content>
