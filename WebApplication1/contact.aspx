<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="WebApplication1.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <center>
        <h1 style="font-family:algerian; text-align: center; text-transform: uppercase; color:#A52A2A">for any queries, please contact.</h1>
        <h4><b>Navitage Location Below&nbsp&nbsp<i class="far fa-hand-point-down align-items-lg-stretch"></i></b></h4>
    </center>
    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3725.067579908787!2d75.56370331476258!3d20.989927986019456!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3bd90e5179a6c9c7%3A0xe3578528716287cf!2sSmile%20Beauty%20Touch!5e0!3m2!1sen!2sin!4v1618723870014!5m2!1sen!2sin" 
       style="width:100%; height:50%;" allowfullscreen="" loading="lazy"></iframe>


    <div class="container" >
        <div class="row">
       <div class="col-12">

         <div class="row">
         <div class="col-md-3">
        <a class="navbar-brand" href="homepage.aspx" style="font-size:20px">
             SaloonStyle </a>&nbsp;&nbsp;

        <img src="Imgs/Logo2.png" height="300" width="300" /> 
         </div>
      

          
        <div class="col-md-3">
            <br />
         <p  class="text-justify"><strong> Smile Beauty Touch</strong><br />
             Address: <br />JK Park Road Ramnagar,<br />
             Near Dmart, Jalgaon, <br />
             Maharashtra 425001</p>
         </div>

            <div class="col-md-3">
            <br />
         <p  class="text-justify"><strong>Hours:</strong><br />
              Monday: 9am-3pm<br />
              Tuesday: 9am-7pm<br />
              Wednesday: 10am-8pm<br />
              Thursday: 11am-9pm<br />
               Friday: 9am-7pm<br />
              Saturday: 10am-4pm<br />
          Sunday: Closed<br /></p>
         </div>

      
         <div class="col-md-3">  <br />
        <p class="test-justify"><strong>Phone no:</strong><br />  99231 71450</p> 
         </div> 
        </div>
        </div>
    </div>
</asp:Content>
