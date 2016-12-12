<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="FreshLiveUI.Admin.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../bootstrap/css/bootstrap-theme.css" rel="stylesheet" />
    <script src="../scipts/jquery-1.11.0.min.js"></script>
    <script src="../bootstrap/js/bootstrap.js"></script>
    <style>
        body {
            background-image: url(/images/bg.jpg);
        }

        #panelLogin {
            width: 500px;
            margin-top: 100px;
        }
    </style>
    <script>
        function checkName() {
            var username = document.getElementById("txt_username").value.trim();
            var span_name = document.getElementById("span_name");
            span_name.innerHTML = "";
            if (!username) {
                span_name.innerHTML = "账号不能为空！";
                return false;
            }
            return true;
        }
        function checkPwd() {
            var userpwd = document.getElementById("txt_pwd").value.trim();
            var span_pwd = document.getElementById("span_pwd");
            span_pwd.innerHTML = "";
            if (!userpwd) {
                span_pwd.innerHTML = "密码不能为空！";
                return false;
            }
            return true;
        }
        function checkAll() {
            return checkName() && checkPwd();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" onsubmit=" return  checkAll()">
        <div>
            <div id="panelLogin" class="panel panel-default center-block">
                <div class="panel-heading">
                    <h3 class="panel-title ">后台管理中心</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:TextBox ID="txt_username" runat="server" placeholder="请输入账号" class="form-control" onblur="checkName()"></asp:TextBox>
                        <span id="span_name"></span>
                       
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txt_pwd" runat="server" placeholder="请输入密码" class="form-control" onblur="checkPwd()" TextMode="Password"></asp:TextBox><span id="span_pwd"></span>
                    </div>                  
                    <div>
                        <asp:Button ID="btn_sure" runat="server" Text="登录" class="btn btn-primary center-block" OnClick="btn_sure_Click"   />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

