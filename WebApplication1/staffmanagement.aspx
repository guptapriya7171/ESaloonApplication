<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="staffmanagement.aspx.cs" Inherits="WebApplication1.staffmanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   
    <script type="text/javascript">
         $(document).ready(function () {
             $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
         });
     </script> 
       

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">

       <div class="col-md-5">

           <div class="card">
            <div class="card-body">

             
              <div class="row">
                   <div  style="text-align:center;" class="col">
                     
                     <h4>Staff Details</h4>
                         
                     
                   </div></div>

                 <div class="row">
               <div style="text-align:center;" class="col">
                  
                   <img width="100" src="Imgs/stafficon.jpg"/> 
                   
                  </div>
              </div>


             <div class="row">
                   <div class="col" style="text-align:center;">
                   <hr /> 
                 </div></div>

                
             <div class="row">
               <div class="col-md-4">
                    <label>Staff Id</label>
                       <div class="form-group">
                           <div class="input-group">
                       <asp:TextBox  CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                           <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="GO" OnClick="Button1_Click" />
                    </div> </div>
                 </div>

                 <div class="col-md-8">
                    <label>Staff Name</label>
                    <div class="form-group">
                       <asp:TextBox  CssClass="form-control" ID="TextBox2" runat="server" placeholder="Name" ></asp:TextBox>
                    </div>
                 </div>
             </div>
    
                  <br />

              <div class="row">

               <div class="col-4">
                  <asp:Button ID="Button2" width="150px" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button2_Click"></asp:Button>
                   </div>

                  <div class="col-4">
                  <asp:Button ID="Button3" width="150px"   class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click"></asp:Button>
                   </div>

                   <div class="col-4">
                  <asp:Button ID="Button4" width="150px"   class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button4_Click"></asp:Button>
                   </div>

              </div>
            </div></div></div>     

                  
       
          <div class="col-md-7">
                                 
          <div class="card">
          <div class="card-body">

          

              <div class="row">
                   <div class="col" style="text-align:center;">
                     
                     <h4>Staff List</h4>
                      <span class="badge bg-primary">Staff Info</span>
                     
                   </div></div>  

                  <div class="row">
                   <div class="col" style="text-align:center;">
                    <hr />
                    
                 </div></div>

                  

                 <div class="row">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eSalonDBConnectionString %>" 
                         SelectCommand="SELECT * FROM [staff_master_tbl]"></asp:SqlDataSource>
                   <div class="col">
  <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"
      AutoGenerateColumns="False" DataKeyNames="staff_id" DataSourceID="SqlDataSource1"> 
      <Columns>
                      <asp:BoundField DataField="staff_Id" HeaderText="ID" ReadOnly="True" SortExpression="staff_Id" />
                      <asp:BoundField DataField="staff_name" HeaderText="Staff Name" ReadOnly="True" SortExpression="staff_name" />
                          
                   </Columns>
                       </asp:GridView>
                     </div></div>

              </div>
              </div>
            </div>

            </div>
            <a href="homepage.aspx"><< Back to home</a><br /><br />
            </div>
          
</asp:Content>
