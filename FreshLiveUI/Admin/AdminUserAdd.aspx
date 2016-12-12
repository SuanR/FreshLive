<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="AdminUserAdd.aspx.cs" Inherits="FreshLiveUI.Admin.AdminUserAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ol class="breadcrumb">
        <li><a href="#">管理员管理</a></li>
        <li class="active">管理员新增</li>
    </ol>
    <div class="panel panel-default">

        <div class="panel-heading">
            管理员新增
        </div>
        <div class="panel-body ">
            <div class="form-group">
                <label for="txtEquipmentName" class="control-label col-sm-1">账户</label>

                <div class="col-sm-11">
                    <asp:hiddenfield id="hdfID" runat="server"></asp:hiddenfield>
                    <asp:textbox id="AdminName" runat="server" class="form-control" placeholder="请输入账户" clientidmode="Static"></asp:textbox>
                </div>

            </div>
            <div class="form-group">
                <label for="txtFactory" class="control-label col-sm-1">密码</label>

                <div class="col-sm-11">
                    <asp:textbox id="AdminPwd" runat="server" class="form-control" placeholder="请输入密码" clientidmode="Static"></asp:textbox>
                </div>
            </div>
            
            <div class="form-group">
                <asp:button id="btnSave" runat="server" text="提交" class="btn btn-primary center-block" />
            </div>
            
        </div>
    </div>
</asp:Content>
