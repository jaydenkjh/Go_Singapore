<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="itinerary.aspx.cs" Inherits="Go_Singapore.Views.Itinerary" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Go_Singapore.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Itinerary
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topHeader" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="homeContent" runat="server">
    <%
        
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("itineraries.aspx");
            }
            else
            {
                id = Request.QueryString["id"].ToString();
            }


        ItineraryManager im = new ItineraryManager();
        DataTable dt = im.GetItinearyListById(id);
        string name = "";
        string days = "";
        if (dt != null)
        {
            name = dt.Rows[0]["name"].ToString();
            days = dt.Rows[0]["total_days"].ToString();
        }

        lblTitle2.Text = name;
        Label1.Text = days + " days itinerary in Singapore";
        %>
    <h1>
        <asp:Label ID="lblTitle2" runat="server" Text="Label"></asp:Label></h1>
    <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Larger"></asp:Label>
    <br />
    <hr />
    <br />
    <br />


    <style>
        p{
            font-size:13px;
        }
        .planbox img{
            height:250px;
            width:400px;
        }
        .planbox .title
        {
            font-weight:bold;
            font-size:20px;
        }
    </style>


    <%
            if (dt != null)
                foreach (DataRow row in dt.Rows)
                {
                    Response.Write("<div class='container planbox'><div class='row'><div class='col-5'>" +
                        "<img src='images/attractions/" + row["image"].ToString() + "'></div><div class='col-7'>" +
              "<div class='title'>" + row["startTime"] + " - " + row["endTime"] + ": " + row["attractionname"] + "</div><br/>"
              + row["description"] 
              + "</div></div></div><br/>");
                }
        

        %>


</asp:Content>
