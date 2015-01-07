<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add opportunitynew.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
    <nav class="navbar navbar-default navbar-inverse">
        <div class="container-fluid">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="row">
                
                    <h3 style="color: #2C6BA0;text-align:center">NGO PORTAL</h3>
                
            </div>
            </div>
    </nav>    
    
        <div class="row" style="margin-left: 1200px">
            <h5 style="margin-left: 500px; color:red;font-size:Large"  role="alert">Hi
                <asp:Label ID="Label8" Style="color: #2C6BA0;font-size: xx-large" Font-Underline runat="server" Text=""></asp:Label>
                <asp:LinkButton ID="LinkButton1" Font-Size="Large" ForeColor="Red" OnClick="LinkButton1_Click" runat="server">Logout</asp:LinkButton>
            </h5>
        </div>
        <div class="progress">
            <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 95%">
                <span class="sr-only">95% Complete (danger)</span>
            </div>
        </div>
    

    <div id="addform" style="margin-left: 600px; margin-top: 150px">
        <h3 style="margin-left: 200px">Add Opportunity
        </h3>

        <div class="form-group">
            <label for="name">NAME</label>
            <asp:TextBox ID="TextBox1" class="form-control" placeholder="Enter opportunity name" MaxLength="150" runat="server" Width="594px" TabIndex="1"></asp:TextBox>
            <asp:Label ID="Label2" Style="color: red" runat="server" Text=""></asp:Label>
        </div>

        <div class="form-group">
            <label for="Description">Description</label>
            <asp:TextBox ID="TextBox4" class="form-control" placeholder="Enter Description" MaxLength="2000" Width="594px" runat="server" TabIndex="2"></asp:TextBox>
            <asp:Label ID="Label1" Style="color: red" runat="server" Text=""></asp:Label>
        </div>

        <div class="form-group">
            <label for="ngoname">NGO NAME</label>
            <asp:TextBox ID="TextBox2" class="form-control" placeholder="Enter NGO name" MaxLength="150" Style="width: 600px" runat="server" TabIndex="3"></asp:TextBox>
            <asp:Label ID="Label3" Style="color: red" runat="server" Text=""></asp:Label>
        </div>

        <div class="input-group row">

            <div class="col-md-6">
                <asp:DropDownList ID="DropDownList1" class="form-control input" Style="width: 250px; margin-top: 30px" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" runat="server" TabIndex="4">
                    <asp:ListItem Selected="True">select your country</asp:ListItem>
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>Bermuda</asp:ListItem>
                    <asp:ListItem>Canada</asp:ListItem>
                    <asp:ListItem>Estonia</asp:ListItem>
                    <asp:ListItem>Isle of man</asp:ListItem>
                    <asp:ListItem>United kingdom</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="col-md-6">
                <asp:DropDownList ID="DropDownList2" class="form-control input" Style="margin-left: 30px; width: 250px; margin-top: 30px" runat="server" TabIndex="5">
                    <asp:ListItem Selected="True">select your city</asp:ListItem>
                </asp:DropDownList>

            </div>

        </div>

        <div class="form-group row" style="margin-left: 1px">
            <div class="col-md-3">
                <asp:Label ID="Label4" Style="color: red" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:Label ID="Label5" Style="color: red" runat="server" Text=""></asp:Label>
            </div>
        </div>

        <div class="form-group row" style="margin-top: 30px; margin-left: 1px">
            <label for="startdate">Start Date (mm/dd/yyy)</label>
            <label for="duration" style="margin-left: 190px">Duration</label>
        </div>

        <div class="form-group row">
            <div class="col-md-3">

                <asp:TextBox ID="TextBox5" Style="width: 250px" class="form-control input-lg" runat="server" TabIndex="6"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorDOB" runat="server" ErrorMessage="Enter The start date in mm/dd/yyyy" ControlToValidate="TextBox5" Display="Dynamic" EnableClientScript="False" ValidationExpression="^(((0?[1-9]|1[012])/(0?[1-9]|1\d|2[0-8])|(0?[13456789]|1[012])/(29|30)|(0?[13578]|1[02])/31)/(19|[2-9]\d)\d{2}|0?2/29/((19|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(([2468][048]|[3579][26])00)))$" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:Label ID="Label6" Style="color: red" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-md-6">
                <asp:TextBox ID="TextBox3" class="form-control" Style="width: 270px" runat="server" TabIndex="7"></asp:TextBox>
                <asp:Label ID="Label7" Style="color: red" runat="server" Text=""></asp:Label>
            </div>
        </div>

        <div class="form-group row">
            <div class="col-md-3">
                <asp:Button ID="Button1" class="btn btn-primary btn-block btn-lg" Style="width: 250px; margin-top: 30px" runat="server" Text="Create" OnClick="Button1_Click1" TabIndex="8" />
            </div>
            <div class="col-md-6">
                <asp:Button ID="Button2" class="btn btn-primary btn-block btn-lg" Style="width: 250px; margin-top: 30px" runat="server" OnClick="Button2_Click" Text="Cancel" TabIndex="9" />
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

