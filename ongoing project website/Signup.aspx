<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="_Default" enableEventValidation="false"%>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--<img src ="css/images/about-banner.png" style="width:1800px;height:200px" />-->
 <div class="progress" style="margin-bottom:60px">
        <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 90%">
            <span class="sr-only">90% Complete (danger)</span>
        </div>
    </div>
     <div class="container">
         <div class="row">
             <div class="col-xs-12 col-sm-8 col-md-6 col-sm-offset-2 col-md-offset-3">
                 <form role="form">
                     <h3 style="color: #2C6BA0">Please Sign Up</h3>
                     <hr class="colorgraph">

                     <div class="row">
                         <div class="col-xs-12 col-sm-6 col-md-6">
                             <div class="form-group">
                                 <asp:TextBox ID="TextBox1" name="first_name" class="form-control input-lg" placeholder="First Name" TabIndex="1" runat="server"></asp:TextBox>
                                 <asp:Label ID="Label1" Style="color: red" runat="server" Text=""></asp:Label>
                             </div>
                         </div>
                         <div class="col-xs-12 col-sm-6 col-md-6">
                             <div class="form-group">
                                 <asp:TextBox ID="TextBox2" name="last_name" class="form-control input-lg" placeholder="Last Name" TabIndex="2" runat="server"></asp:TextBox>
                                 <asp:Label ID="Label2" Style="color: red" runat="server" Text=""></asp:Label>
                             </div>
                         </div>
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="TextBox3" name="SSN" class="form-control input-lg" placeholder="SSN" MaxLength="6" TabIndex="3" runat="server"></asp:TextBox>
                         <asp:Label ID="Label3" Style="color: red" runat="server" Text=""></asp:Label>

                     </div>
                     <div class="form-group">
                         <!--  <input type="date" name="dob" id="dob" class="form-control input-lg" tabindex="4"  runat="server" />-->
                         <asp:TextBox ID="TextBox8" class="form-control input-lg" placeholder="date of birth(mm/dd/yyyy)" runat="server" TabIndex="4"></asp:TextBox>
                         <asp:RegularExpressionValidator ID="RegularExpressionValidatorDOB" runat="server" ErrorMessage="Enter The DOB in dd/mm/yy" ControlToValidate="TextBox8" Display="Dynamic" EnableClientScript="False" ValidationExpression="^(((0?[1-9]|1[012])/(0?[1-9]|1\d|2[0-8])|(0?[13456789]|1[012])/(29|30)|(0?[13578]|1[02])/31)/(19|[2-9]\d)\d{2}|0?2/29/((19|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(([2468][048]|[3579][26])00)))$" ForeColor="Red"></asp:RegularExpressionValidator>
                         <!-- <asp:Label ID="Label4" runat="server" Text=""></asp:Label>-->
                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="TextBox4" name="email" class="form-control input-lg" placeholder="Email Address" TabIndex="5" runat="server"></asp:TextBox>
                         <asp:Label ID="Label5" Style="color: red" runat="server" Text=""></asp:Label>

                     </div>
                     <div class="form-group">
                         <asp:TextBox ID="TextBox5" Style="width: 555px; height: 100px" class="form-control input-lg" MaxLength="1000" placeholder="Address" TabIndex="6" runat="server"></asp:TextBox>
                         <asp:Label ID="Label10" Style="color: red" runat="server" Text=""></asp:Label>

                     </div>
                     <div class="input-group row">
                         <div class="col-md-4">
                             <asp:DropDownList ID="DropDownList1" class="form-control input" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" runat="server" TabIndex="7">
                                 <asp:ListItem Selected="True">select your country</asp:ListItem>
                                 <asp:ListItem>India</asp:ListItem>
                                 <asp:ListItem>Bermuda</asp:ListItem>
                                 <asp:ListItem>Canada</asp:ListItem>
                                 <asp:ListItem>Isle of man</asp:ListItem>
                                 <asp:ListItem>Estonia</asp:ListItem>
                                 <asp:ListItem>United kingdom</asp:ListItem>
                             </asp:DropDownList>
                         </div>
                         <div class="col-md-4">
                             <asp:DropDownList ID="DropDownList2" class="form-control input" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" runat="server" TabIndex="8">
                                 <asp:ListItem Selected="True">select your city</asp:ListItem>
                             </asp:DropDownList>
                         </div>
                         <div class="col-md-4">
                             <asp:DropDownList ID="DropDownList3" class="form-control input" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" runat="server" TabIndex="9">
                                 <asp:ListItem Selected="True">select your Pin</asp:ListItem>
                             </asp:DropDownList>
                         </div>
                     </div>
                     <div class="form-group row" style="margin-left: 1px">
                         <div class="col-md-4">
                             <asp:Label ID="Label6" Style="color: red" runat="server" Text=""></asp:Label>
                         </div>
                         <div class="col-md-4">
                             <asp:Label ID="Label7" Style="color: red" runat="server" Text=""></asp:Label>
                         </div>
                         <div class="col-md-3">
                             <asp:Label ID="Label8" Style="color: red" runat="server" Text=""></asp:Label>
                         </div>

                     </div>
                     <div class="row">
                         <div class="col-xs-12 col-sm-6 col-md-6">
                             <div class="form-group" style="margin-top: 10px">
                                 <asp:TextBox ID="TextBox6" TextMode="Password" class="form-control input-lg" placeholder="Password" runat="server" TabIndex="10"></asp:TextBox>
                                 <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                             </div>
                         </div>
                         <div class="col-xs-12 col-sm-6 col-md-6">
                             <div class="form-group" style="margin-top: 10px">
                                 <asp:TextBox ID="TextBox7" TextMode="Password" class="form-control input-lg" placeholder="Confirm Password" runat="server" TabIndex="11"></asp:TextBox>
                                 <asp:Label ID="Label9" Style="color: red" runat="server" Text=""></asp:Label>
                             </div>
                         </div>
                     </div>
                     <recaptcha:RecaptchaControl
                         ID="recaptcha"
                         runat="server"
                         PublicKey="6Lfm6v8SAAAAANjxqzTLg32h3tV1qCZljeIht_-l"
                         PrivateKey="6Lfm6v8SAAAAAGjzi63LMAVDBDKZXP1vaqWv1SIC" />
                     <div class="row" style="font-size: small">
                         <!--<div class="col-xs-8 col-sm-9 col-md-9">-->
                         &nbsp;&nbsp;&nbsp;&nbsp;
                        By clicking <strong class="label label-primary">Register</strong>, you agree to the <a href="#" data-toggle="modal" data-target="#t_and_c_m">Terms and Conditions</a> set out by this site, including our Cookie Use.
                   <!-- </div>-->
                     </div>
                     <hr class="colorgraph">
                     <div class="row">
                         <div class="col-xs-12 col-md-6">
                             <asp:Button ID="Button1" class="btn btn-primary btn-block btn-lg" Style="width: 230px" runat="server" OnClick="Button1_Click" Text="Register" TabIndex="12" />
                         </div>
                         <div class="col-xs-12 col-md-6">
                             <asp:Button ID="Button2" class="btn btn-primary btn-block btn-lg" Style="width: 230px;margin-left:20px" runat="server" OnClick="Button2_Click" Text="Cancel" TabIndex="13" />
                         </div>
                     </div>

                 </form>
             </div>
         </div>
     </div>
    <footer>
        <div class="progress" style="margin-top: 60px">
            <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 90%">
                <span class="sr-only">90% Complete (danger)</span>
            </div>
        </div>
    </footer>

</asp:Content>

