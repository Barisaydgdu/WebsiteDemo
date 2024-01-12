<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMain.Master" AutoEventWireup="true" CodeBehind="AltSliderYonetimi.aspx.cs" Inherits="WebSiteDemo.Admin.AltSliderYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-6 grid-margin stretch-card">
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Default form</h4>
      <p class="card-description"> Slider Management </p>
      <form  class="forms-sample">
          <div class="form-group">
  <label for="exampleInputUsername1">Title</label>
  <input type="text" runat="server" class="form-control" id="txtTitle" placeholder="Title">
</div>
          <div class="form-group">
  <label for="exampleInputUsername1">Summary Text</label>
  <input type="text" runat="server" class="form-control" id="txtSummaryText" placeholder="Summary Text">
</div>
        <div class="form-group">
          <label for="exampleInputUsername1">Full Text</label>
          <input type="text" runat="server" class="form-control" id="txtFullText" placeholder="Full Text">
        </div>
        <div class="form-group">
          <label for="exampleInputPassword1">Queue No</label>
          <asp:TextBox class="form-control" placeholder="Queue No" ID="txtQueueNo5" runat="server"></asp:TextBox>
          
        </div>
          <div class="form-group">
              <label for="exampleInputPassword1">Icon Url</label>
              <asp:FileUpload ID="FlIcon" runat="server" />
           </div>
        
        
        <asp:Button type="submit" class="btn btn-primary me-2" ID="btnSubmıt" runat="server" Text="Submit" OnClick="btnSubmıt_Click" />
        
        
      </form>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </div>
  </div>
</div>
</asp:Content>
