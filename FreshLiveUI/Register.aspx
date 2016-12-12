<%@ Page Title="" Language="C#" MasterPageFile="~/MotherSet.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FreshLiveUI.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login_cont_tit">
        <div class="login_tit_cont">
            <span>会员注册</span>
        </div>
    </div>
    <div class="login_cont_c">
        <div class="login_c_l">
            <table width="635" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td width="150" height="60" align="right" valign="middle">用户名 ：</td>
                    <td width="360" valign="middle">
                        <input name="ctl00$bodyContent$txtUserName" type="text" id="bodyContent_txtUserName" class="login_input_css01 black_xl" />
                    </td>
                    <td width="125">&nbsp;</td>
                </tr>
                <tr id="err_logemail" style="display: none;">
                    <td align="right">&nbsp;</td>
                    <td class="font_red1" id="err_logemail_txt"></td>
                </tr>
                <tr>
                    <td height="60" align="right" valign="middle">密             码：</td>
                    <td valign="middle">
                        <input name="ctl00$bodyContent$txtPwd" type="password" id="bodyContent_txtPwd" class="login_input_css01 black_xl" />
                    </td>
                    <td valign="middle">&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" valign="middle" style="height: 60px">确认密码：</td>
                    <td valign="middle" style="height: 60px">
                        <input name="ctl00$bodyContent$txtPwdRe" type="password" id="bodyContent_txtPwdRe" class="login_input_css01 black_xl" />
                    </td>
                    <td valign="middle" style="height: 60px">
                        <br />
                    </td>
                </tr>
                <tr>
                    <td height="60" align="right" valign="middle">电子邮箱：</td>
                    <td valign="middle">
                        <input name="ctl00$bodyContent$txtEmail" type="text" id="bodyContent_txtEmail" class="login_input_css01 black_xl" />
                    </td>
                    <td valign="middle">
                        <br />
                    </td>
                </tr>
                <tr>
                    <td height="74">&nbsp;</td>
                    <td valign="middle">
                        <input type="image" name="ctl00$bodyContent$btnLogin" id="bodyContent_btnLogin" onmouseover="(this.src=&#39;/Images/botton_06.jpg&#39;)" onmouseout="(this.src=&#39;/Images/botton_05.jpg&#39;)" src="Images/botton_05.jpg" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td height="50">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2" height="100"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div class="login_c_r">
            <p>您已成为“新鲜生活”会员，请登录</p>
            <p class="link_login"><a id="show_login_box" href="Login.aspx">登陆</a></p>
        </div>
    </div>

</asp:Content>
