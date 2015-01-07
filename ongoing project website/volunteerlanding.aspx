<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="volunteerlanding.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <nav class="navbar navbar-default navbar-inverse">
        <div class="container-fluid">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="row">
                <div class="col-md-2">
                    <h3 style="color: #2C6BA0; margin-left: 30px;">NGO PORTAL</h3>
                </div>

                <div class="input-group stylish-input-group ">
                    <asp:TextBox ID="TextBox1" class="form-control" Style="width: 300px; margin-left: 1000px; margin-top: 20px" placeholder="Search" runat="server">
                    </asp:TextBox>
                    <asp:Label ID="Label3" Style="color: red" runat="server" Text=""></asp:Label>
                    <asp:Button ID="Button1" runat="server" Style="width: 100px; margin-top: 20px" OnClick="Button1_Click" class="glyphicon glyphicon-search btn btn-primary" Text="Search" />
                </div>


            </div>
    </nav>
            <div>
                
                    <h5 style="margin-left: 1700px; color: red" role="alert">Hi
                    <asp:Label ID="Label2" Style="color: #2C6BA0; font-size: xx-large" Font-Underline runat="server" Text=""></asp:Label>
                        <asp:LinkButton ID="LinkButton4" Style="color: red" OnClick="LinkButton4_Click" runat="server">Logout</asp:LinkButton>
                    </h5>
            </div> 
            
        </div>

          
   
    <div class="progress" style="margin-bottom:60px">
        <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 90%">
            <span class="sr-only">90% Complete (danger)</span>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-6 col-md-2" style="margin-left: 80px">
            <div class="thumbnail">
                <div>
                    <h3>
                        <asp:LinkButton ID="LinkButton1" Style="color: #2C6BA0" OnClick="LinkButton1_Click"  runat="server">Total Opportunity</asp:LinkButton>
                        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    </h3>
                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-2" style="margin-left: 50px">
            <div class="thumbnail">
                <div>
                    <h3>
                        <asp:LinkButton ID="LinkButton2" Style="color: #2C6BA0" OnClick="LinkButton2_Click"  runat="server">History</asp:LinkButton>&nbsp;<asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    </h3>

                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-2" style="margin-left: 50px">
            <div class="thumbnail">
                <div>
                    <h3>
                        <asp:LinkButton ID="LinkButton3" Style="color: #2C6BA0" OnClick="LinkButton3_Click"  runat="server">My Opportunity</asp:LinkButton>
                        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                    </h3>
                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-2" style="margin-left: 50px">
            <div class="thumbnail">
                <div>
                    <h3>
                        <asp:LinkButton ID="LinkButton5" Style="color: #2C6BA0" OnClick="LinkButton5_Click"  runat="server">Recommended Opportunity</asp:LinkButton>
                        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                    </h3>
                </div>
            </div>
        </div>
        
    </div>
    <br />
    <div>
        <h3>
            <asp:Label ID="Label1" runat="server" Style="margin-left: 700px; color: #2C6BA0" Font-Bold Font-Underline Text="">Recommended Opportunities</asp:Label></h3>
    </div>
    <asp:Table ID="Table1" class="table" Style="margin-left: 144px; margin-bottom: 20px; margin-top: 30px" Height="26px" Width="1274px" BorderStyle="Solid" EnableTheming="True" GridLines="Both" runat="server" BackColor="White" BorderColor="Black">
        <asp:TableRow runat="server" TableSection="TableHeader" Font-Underline="true" Font-Bold>
            <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Name</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">NGO Name</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Description</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Country</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">City</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Start Date</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Duration</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Status</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <footer>
        <div class="progress" style="margin-bottom: 60px">
            <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 90%">
                <span class="sr-only">90% Complete (danger)</span>
            </div>
        </div>
    </footer>

</asp:Content>

