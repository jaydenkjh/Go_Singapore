<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Go_Singapore.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topHeader" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="homeContent" runat="server">
    <asp:TextBox ID="TextBox15" runat="server" Text="System Output" ReadOnly="True"></asp:TextBox>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:TextBox ID="TextBox1" runat="server" Text="Name"></asp:TextBox>
    <asp:FileUpload ID="FileUpload1" runat="server" Text="Image File"/>
    <asp:Button runat="server" Text="Update" id="Button1" OnClick="Button1_Click" />
    <br/>
    <asp:TextBox ID="TextBox3" runat="server" Text="Description" CausesValidation="True" Width="1000"></asp:TextBox>
    <br/>
    <asp:TextBox ID="TextBox11" runat="server" Text="AttractionID"></asp:TextBox>
    <asp:Button runat="server" Text="Delete" id="Button4" OnClick="Button4_Click" />
    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    <asp:TextBox ID="TextBox4" runat="server" Text="Name"></asp:TextBox>
    <asp:TextBox ID="TextBox5" runat="server" Text="Total Days"></asp:TextBox>
    <asp:Button runat="server" Text="Update" id="Button2" OnClick="Button2_Click" />
    <br/>
    <asp:TextBox ID="TextBox12" runat="server" Text="ItineraryID"></asp:TextBox>
    <asp:Button runat="server" Text="Delete" id="Button5" OnClick="Button5_Click" />
    <asp:GridView ID="GridView3" runat="server"></asp:GridView>
    <asp:TextBox ID="TextBox6" runat="server" Text="itineraryID"></asp:TextBox>
    <asp:TextBox ID="TextBox7" runat="server" Text="attractionID"></asp:TextBox>
    <asp:TextBox ID="TextBox8" runat="server" Text="day"></asp:TextBox>
    <asp:TextBox ID="TextBox9" runat="server" Text="startTime" MaxLength="5"></asp:TextBox>
    <asp:TextBox ID="TextBox10" runat="server" Text="endTime" MaxLength="5"></asp:TextBox>
    <asp:Button runat="server" Text="Update" id="Button3" OnClick="Button3_Click" />
    <br/>
    <asp:TextBox ID="TextBox13" runat="server" Text="itineraryID"></asp:TextBox>
    <asp:TextBox ID="TextBox14" runat="server" Text="attractionID"></asp:TextBox>
    <asp:Button runat="server" Text="Delete" id="Button6" OnClick="Button6_Click" />
</asp:Content>
