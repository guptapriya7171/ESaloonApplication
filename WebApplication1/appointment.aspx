<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="appointment.aspx.cs" Inherits="WebApplication1.appointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="alert alert-warning" role="alert" >
 <strong>Check for the appointment</strong>
    <hr>
  <p class="mb-0">Make sure you dont choose national holiday's date</p>
     <br />
     <h1>Find an appointment:</h1>
     <h6>Please note: This is a request only. The Beauty Parlour will contact you to confirm your appointment.</h6>
</div>
    <asp:Calendar ID="Calendar1" runat="server" ></asp:Calendar>

     
</asp:Content>
