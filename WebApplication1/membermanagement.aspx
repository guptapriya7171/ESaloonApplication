<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="membermanagement.aspx.cs" 
    Inherits="WebApplication1.membermanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">
         $(document).ready(function () {
             $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
         });
     </script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
      <div class="row">
       <div class="col-md-5">

             <div class="card">
                  <div class="card-body">
  
                   <div class="row">
                   <div class="col" style="text-align:center">
                 
                     <h4>Client Details</h4>
                     </div>
                  </div>

                  <div class="row">
                    <div class="col" style="text-align:center">
                 
                   <img width="100" src="Imgs/generaluser.jpg"/> 
                   
                  </div></div>


                <div class="row">
                   <div class="col" style="text-align:center">
                    <hr>
                      </div>
                  </div>


             <div class="row">
               <div class="col-md-3">
                    <label>Member ID</label>
                       <div class="form-group">
                           <div class="input-group">
                       <asp:TextBox  CssClass="form-control" ID="TextBox10" runat="server" placeholder="ID"></asp:TextBox>
                       <asp:LinkButton class="btn btn-primary" ID="LinkButton1" runat="server" Text="A" OnClick="LinkButton1_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                   </div>
                  </div>
              </div>

                 <div class="col-md-4">
                    <label>Full Name</label>
                    <div class="form-group">
                       <asp:TextBox  CssClass="form-control" ID="TextBox2" runat="server" placeholder="Full Name" ReadOnly="True"  ></asp:TextBox>
                    </div></div>

                 <div class="col-md-5">
                     <label>Account Status</label>
                      <div class="form-group">
                           <div class="input-group">
                         <asp:TextBox  CssClass="form-control mr-1" ID="TextBox1" runat="server" placeholder="Status" ReadOnly="True"></asp:TextBox>
                           <asp:LinkButton class="btn btn-success mr-1" ID="Button3" runat="server" Text="A" OnClick="Button3_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                          <asp:LinkButton class="btn btn-warning mr-1" ID="Button4" runat="server" Text="p"><i class="fas fa-pause"></i></asp:LinkButton>
                          <asp:LinkButton class="btn btn-danger mr-1" ID="Button5" runat="server" Text="d"><i class="fas fa-times-circle"></i></asp:LinkButton>
                    </div>
                 </div>
              </div> 
             </div>
            <div class="row">
               <div class="col-md-3">
                    <label>DOB</label>
                       <div class="form-group">     
                       <asp:TextBox  CssClass="form-control" ID="TextBox11" runat="server" placeholder="ID" ReadOnly="True" TextMode="Date"></asp:TextBox>
                       </div>
                 </div>

                 <div class="col-md-4">
                    <label>Contact No.</label>
                    <div class="form-group">
                       <asp:TextBox  CssClass="form-control" ID="TextBox12" runat="server" placeholder="Contact No." ReadOnly="True" TextMode="Number"></asp:TextBox>
                    </div></div>

                 <div class="col-md-5">
                     <label>Email ID</label>
                      <div class="form-group">
                      <asp:TextBox  CssClass="form-control" ID="TextBox3" runat="server" placeholder="Email ID" ReadOnly="True" TextMode="Email"></asp:TextBox>     
                 </div>
              </div> 
             </div>
            
           <div class="row">
               <div class="col-md-4">
                    <label>State</label>
                       <div class="form-group">
                          <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="State" ReadOnly="True"></asp:TextBox>
                    </div>
                 </div>

               

                 <div class="col-md-4">
                    <label>City</label>
                    <div class="form-group">
                       <asp:TextBox  CssClass="form-control" ID="TextBox4" runat="server" placeholder="City" ReadOnly="True"></asp:TextBox>
                    </div>
                 </div>

                <div class="col-md-4">
                    <label>Pin Code</label>
                    <div class="form-group">
                       <asp:TextBox  CssClass="form-control" ID="TextBox13" runat="server" placeholder="Pin Code" ReadOnly="True" TextMode="Number"></asp:TextBox>
                    </div>
                 </div>
             </div>

               <div class="row">
               <div class="col-12">
                    <label>Full Address</label>
                       <div class="form-group">
                       <asp:TextBox  class="form-control" ID="TextBox14" runat="server" ReadOnly="True" placeholder="Full Address" 
                           TextMode="MultiLine" Rows="2"></asp:TextBox>
                    </div>
                 </div>
             </div>
   
                      <br />
                  <div class="row">
                    <div class="col-8 mx-auto">
                     <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete User Permanently" OnClick="Button2_Click" />
                          </div>
                       </div>
                  </div>      
                 </div>
           <a href="homepage.aspx"><< Back to home</a><br /><br />  

           </div>
          <div class="col-md-7">
               <div class="card">
                   <div class="card-body">

          

              <div class="row">
                   <div class="col" style="text-align:center">
                 
                     <h4>Members List</h4>
                      <span class="badge bg-primary">All Members Admin Access</span>
                     
                   </div></div>  

                  <div class="row">
                  <div class="col">
                    <hr>
                 </div>
             </div>

                  

                 <div class="row">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eSalonDBConnectionString %>" SelectCommand="SELECT * FROM [member_master_tbl]"></asp:SqlDataSource>
                   <div class="col">
                       <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="member_id" DataSourceID="SqlDataSource1">
                           <Columns>
                               <asp:BoundField DataField="member_id" HeaderText="MemberID" ReadOnly="True" SortExpression="member_id" />
                               <asp:BoundField DataField="full_name" HeaderText="Name" SortExpression="full_name" />
                               <asp:BoundField DataField="contact_no" HeaderText="Contact" SortExpression="contact_no" />
                               <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                               <asp:BoundField DataField="state" HeaderText="State" SortExpression="state" />
                               <asp:BoundField DataField="city" HeaderText="City" SortExpression="city" />
                               <asp:BoundField DataField="pincode" HeaderText="Pincode" SortExpression="pincode" />
                               <asp:BoundField DataField="account_status" HeaderText="Status" SortExpression="account_status" />
                          </Columns>
                        </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
  </div>
</asp:Content>