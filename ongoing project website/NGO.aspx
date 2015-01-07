<%@ Page Title="NGO" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NGO.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <nav class="navbar navbar-default navbar-inverse" role="navigation">
            <h1 style="color: #2C6BA0; text-align: center">Welcome to NGO PORTAL</h1>
        </nav>                           
        <a href="#myModal" id="modal" role="button" class="btn btn-primary" style="margin-left: 1500px" font-size:"xx-large"  data-toggle="modal">Log In</a>           
        <a style="margin-left: 50px" role="button" class="btn btn-primary" font-size:"xx-large"   href="signup.aspx">Register</a>                    
    </div>

    <div id="myCarousel" class="carousel slide" style="width:1400px; height:400px;margin-left:300px" data-interval="3000" data-ride="carousel">
       
        
        <!-- Carousel items -->
        <div class="carousel-inner"  style="height:400px">
            <div class="active item">
                <div class="carousel-caption" style="height: 400px">
                    <img src="css/images/about-banner.png" />
                </div>
            </div>
            <div class="item">
                <div class="carousel-caption" style="height: 400px">
                    <img src="homepage1.jpg" />
                </div>
            </div>
            <div class="item">
                <div class="carousel-caption" style="height: 400px">
                    <img src="css/images/cropped-banner1.jpg" />
                </div>
            </div>
        </div>
        <!-- Carousel nav -->
        <a class="carousel-control left">
            <span class="glyphicon glyphicon-chevron-left"></span>
        </a>
        <a class="carousel-control right">
            <span class="glyphicon glyphicon-chevron-right"></span>
        </a>
    </div>

    
    <!--Modal for Register Page-->
    <!--Creating modal here-->
    <div class="modal fade" id="myModal">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <span>Log In</span>
                </div>
                <div class="modal-body">
                    <!--Name-->
                    <div class="form-group row">
                        <label for="inputName" class="col-sm-3 control-label">Email :</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="TextBox2" TextMode="Email" class="form-control" placeholder="Username" runat="server"></asp:TextBox>
                            <asp:Label ID="Label2" Style="color: red" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <!--Password-->
                    <div class="form-group row">
                        <asp:Label ID="Label6" for="password" class="col-sm-3 control-label" Font-Size="Large" runat="server" Text="Password"></asp:Label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="TextBox3" TextMode="Password" class="form-control" placeholder="password" runat="server"></asp:TextBox>
                            <asp:Label ID="Label3" Style="color: red" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <!--Buttons for Log In and Cancel-->
                    <br />
                    <div class="form-group row">
                        <label class="col-lg-7"></label>
                        <asp:LinkButton ID="LinkButton1" class="btn btn-primary" OnClick="LinkButton1_Click"  runat ="server">Login</asp:LinkButton>
                        <a href="#myModal" role="button" class="btn btn-primary" data-toggle="modal">
                            <span>Cancel</span>
                        </a>
                    </div>

                    <asp:LinkButton ID="LinkButton2" OnClick="LinkButton2_Click" runat="server">Forgot Password</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
    <div>
    
    <asp:TextBox ID="TextBox1" class="form-control" placeholder="Search" Style="margin-left: 1400px; display:inline-block;margin-top: 30px" runat="server" Width="218px"></asp:TextBox>
    <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Search" Width="100px" Style="display:inline-block; margin-top: 0px" OnClick="Button1_Click" />
    <asp:Label ID="Label5" Style="color: red" runat="server" Text=""></asp:Label>
        </div>
    <div>
        <asp:Label ID="Label1" Style="margin-left: 700px; font-size: x-large" runat="server" Text="Opportunities" Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Underline="True"></asp:Label>
        <asp:Table ID="Table1" class="table" runat="server" Style="margin-left:300px; margin-bottom: 20px; margin-top: 30px" Height="26px" Width="1299px" BorderStyle="Solid" EnableTheming="True" Font-Underline="False" GridLines="Both" HorizontalAlign="Center" CaptionAlign="Top" Font-Size="Medium" ForeColor="#0080C0" BorderColor="Black" BorderWidth="5px">
            <asp:TableRow runat="server" TableSection="TableHeader" Font-Bold="True" Font-Italic="True">
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Name</asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" Font-Italic="True" Font-Underline="True">NGO Name</asp:TableCell>
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Description</asp:TableCell>
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Country</asp:TableCell>
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">City</asp:TableCell>
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Start Date</asp:TableCell>
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">Duration</asp:TableCell>
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" HorizontalAlign="Center" VerticalAlign="Middle">status</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" Font-Bold="False" Font-Italic="False" Font-Underline="False" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell>Table </asp:TableCell>
                <asp:TableCell Style="width: 100px"></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button3" Style="margin-left: 30px" class="btn btn-primary" runat="server" Text="Apply" OnClick="Button3_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button4" Style="margin-left: 30px" class="btn btn-primary" runat="server" Text="Apply" OnClick="Button4_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button5" Style="margin-left: 30px" class="btn btn-primary" runat="server" OnClick="Button5_Click" Text="Apply" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button6" Style="margin-left: 30px" class="btn btn-primary" runat="server" OnClick="Button6_Click" Text="Apply" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button7" Style="margin-left: 30px" class="btn btn-primary" runat="server" OnClick="Button7_Click" Text="Apply" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button8" Style="margin-left: 30px" class="btn btn-primary" runat="server" OnClick="Button8_Click" Text="Apply" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button9" Style="margin-left: 30px" class="btn btn-primary" runat="server" OnClick="Button9_Click" Text="Apply" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button10" Style="margin-left: 30px" class="btn btn-primary" runat="server" OnClick="Button10_Click" Text="Apply" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button12" Style="margin-left: 30px" class="btn btn-primary" runat="server" OnClick="Button12_Click" Text="Apply" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button13" Style="margin-left: 30px" class="btn btn-primary" runat="server" OnClick="Button13_Click" Text="Apply" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    <footer>
        <div class="progress" style="margin-top: 60px">
            <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 90%">
                <span class="sr-only">90% Complete (danger)</span>
            </div>
        </div>
    </footer>
    
    
    <script type="text/javascript">
        function openModal() {
            $('#myModal').modal('show');
        }
    </script>
</asp:Content>

