<%@ Page Title="" Language="C#" MasterPageFile="~/MotherSet.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FreshLiveUI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="login_cont_tit">
                    <div class="login_tit_cont">
                        <span>会员登录</span>
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
                                <td valign="middle">
                                    <a href="getpwd.html" class="font_red">忘记密码？</a></td>
                            </tr>

                            <tr>
                                <td height="74">&nbsp;</td>
                                <td valign="middle">
                                    <input type="image" name="ctl00$bodyContent$btnLogin" id="bodyContent_btnLogin" onmouseover="(this.src=&#39;Images/botton_02.jpg&#39;)" onmouseout="(this.src=&#39;Images/botton_01.jpg&#39;)" src="Images/botton_01.jpg" />
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
                        <p>还不是新鲜生活会员？赶快免费注册一个吧</p>
                        <p class="link_login"><a id="show_login_box" href="Register.aspx">注册</a></p>
                        <div class="cooperation_account_tit">
                            <p class="cooperation_account_tit">使用合作帐号登录新鲜生活：</p>
                            <div class="cooperation_account_cont">
                                <div class="cooperation_account_cont1"><a href="#" id="alipay_a"></a></div>
                                <div class="cooperation_account_cont2"><a href="#" id="weibo_a"></a></div>
                                <div class="cooperation_account_cont3"><a href="#" id="aqq_a"></a></div>
                            </div>

                        </div>
                    </div>
                </div>
</asp:Content>
