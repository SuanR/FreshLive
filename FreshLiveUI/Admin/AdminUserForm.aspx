<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="AdminUserForm.aspx.cs" Inherits="FreshLiveUI.Admin.AdminUserForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ol class="breadcrumb">

        <li><a href="#">管理员管理</a></li>
        <li class="active"><a href="#">管理员列表</a></li>
    </ol>
    <div class="panel panel-default">

        <div class="panel-heading">
            管理员列表
        </div>
        <div class="panel-body">
            <table class="table">
                <tr>
                    <th>管理员编号</th>
                    <th>管理员账号</th>
                    <th>管理员密码</th>
                </tr>
                <asp:Repeater ID="rpt_departmentMng" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("AdminID") %></td>
                            <td><%# Eval("AdminName") %></td>
                            <td><%# Eval("AdminPwd") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                
            </table>

        </div>
    </div>  
</asp:Content>
