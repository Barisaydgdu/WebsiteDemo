<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMain.Master" AutoEventWireup="true" CodeBehind="KullaniciEkleme.aspx.cs" Inherits="WebSiteDemo.Admin.KullaniciEkleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-6 grid-margin stretch-card">
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Default form</h4>
      <p class="card-description"> Basic form layout </p>
      <form  class="forms-sample">
          <div class="form-group">
  <label for="exampleInputUsername1">Name</label>
  <input type="text" runat="server" class="form-control" id="txtName" placeholder="Name">
</div>
          <div class="form-group">
  <label for="exampleInputUsername1">Surname</label>
  <input type="text" runat="server" class="form-control" id="txtSurname" placeholder="Surname">
</div>
        <div class="form-group">
          <label for="exampleInputUsername1">EMail</label>
          <input type="text" runat="server" class="form-control" id="txtEmail" placeholder="Email">
        </div>
        <div class="form-group">
          <label for="exampleInputPassword1">Password</label>
          <input type="password" runat="server" class="form-control" id="txtPassword" placeholder="Password">
        </div>
        
        
        <asp:Button type="submit" class="btn btn-primary me-2" ID="btnSubmıt" runat="server" Text="Submit" OnClick="btnSubmıt_Click" />
        
        
      </form>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </div>
  </div>
</div>
</asp:Content>
