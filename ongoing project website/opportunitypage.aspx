<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="opportunitypage.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  
    <script charset="UTF-8" type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.2&mkt=en-us">
    </script> 
    <script type="text/javascript">
        var point = null;
        var map = null;
        function getMap() {
            var point = new VELatLong(34.0540, -118.2370, 0, VELatLong.RelativeToGround);
            var myMap = document.getElementById("myMap");
            myMap.style.display = '';
            map = new VEMap('myMap');
            map.LoadMap(point, 14, VEMapStyle.Road, false, VEMapMode.Mode2D, true, 1);
            StartGeocoding(map, "kolkata");
        }

        function StartGeocoding(myMap, address) {
            myMap.Find(null, address, null, null, null, null, null, null, null, null,
                     GeocodeCallback);
        }

        function GeocodeCallback(shapeLayer, findResults, places, moreResults, errorMsg) {

            if (places == null) {
                alert((errorMsg == null) ? "Address not found!!!" : errorMsg);
                return;
            }


            var bestPlace = places[0];
            var location = bestPlace.LatLong;
            console.log(location.Latitude);
            console.log(location.Longitude);


            point = new VELatLong(location.Latitude, location.Longitude, 0, VELatLong.RelativeToGround);

            map.LoadMap(point, 10, VEMapStyle.Road, false, VEMapMode.Mode2D, true, 1);

            pinPoint = map.GetCenter();
            pinPixel = map.LatLongToPixel(pinPoint);
            var pin = map.AddPushpin(pinPoint);
            pin.SetTitle(bestPlace.Name);
            pin.SetDescription("<b>Latitude:</b> " +
                                  location.Latitude + "<br><b>Longitude:</b>"
                                  + location.Longitude);

            //   pin.SetCustomIcon("<img src='images/pin.png' />");


            /*var newShape = new VEShape(VEShapeType.Pushpin, location);
            var desc = "<b>Latitude:</b> " +
                                  location.Latitude + "<br><b>Longitude:</b>"
                                  + location.Longitude;
            newShape.SetDescription(desc);
            newShape.SetTitle(bestPlace.Name);
            map.AddShape(newShape);
            */
        }
    </script>
    <asp:Panel ID="Panel1" BackImageUrl="~/opportunity.jpg" runat="server">

    <nav class="navbar navbar-default navbar-inverse" role="navigation">
            <h1 style="color: #2C6BA0; text-align: center">NGO PORTAL</h1>
        </nav>     
    <div class="row">
        <h5 style="margin-left: 1700px;color:red" role="alert">Hi
                <asp:Label ID="Label1" Style="color: #2C6BA0; font-size: xx-large" Font-Underline runat="server" Text="Label"></asp:Label>
            <asp:LinkButton ID="LinkButton1" Style="color: red" Font-Size="Small" OnClick="LinkButton1_Click" runat="server">Logout</asp:LinkButton>
        </h5>
    </div>
    
    <div class="progress">
        <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 90%">
            <span class="sr-only">90% Complete (danger)</span>
        </div>
    </div>

    <div style="margin-left: 300px">
        <h3 style="color: #FF0000; margin-left: 400px; text-decoration: underline; font-weight: bold;" font-underline>Opportunity Details</h3>

        <div style="margin-left: 180px; margin-top: 80px">
            <h4 style="color: red; font-weight: bold;">* Title :-
                    <asp:Label ID="Label2" Style="font-size: medium; color: red; margin-left: 130px" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <div style="margin-left: 180px; margin-top: 30px">
            <h4 style="color: red; font-weight: bold;">* Ngo Name :-
                    <asp:Label ID="Label3" Style="font-size: medium; color: red; margin-left: 80px" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <div style="margin-left: 180px; margin-top: 30px">
            <h4 style="color: red; font-weight: bold;">* Start Date :-
                    <asp:Label ID="Label4" Style="font-size: medium; color: red; margin-left: 85px" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <div style="margin-left: 180px; margin-top: 30px">
            <h4 style="color: red; font-weight: bold;">* Duration :-
                    <asp:Label ID="Label5" Style="font-size: medium; color: red; margin-left: 100px" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <div style="margin-left: 180px; margin-top: 30px">
            <h4 style="color: red; font-weight: bold;">* Country :-
                    <asp:Label ID="Label6" Style="font-size: medium; color: red; margin-left: 105px" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <div style="margin-left: 180px; margin-top: 30px">
            <h4 style="color: red; font-weight: bold;">* City :-
                    <asp:Label ID="Label7" Style="font-size: medium; color: red; margin-left: 135px" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <div style="margin-left: 180px; margin-top: 30px">
            <h4 style="color: red; font-weight: bold;">* No. of applicant :
                    <asp:Label ID="Label9" Style="font-size: medium; color: red; margin-left: 80px" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <div style="margin-left: 180px; margin-top: 30px">
            <h4 style="color: red; font-weight: bold;">* Description :
                    <asp:Label ID="Label8" Style="font-size: medium; color: red; margin-left: 80px" runat="server" Text="Label"></asp:Label>
            </h4>
        </div>
        <div style="margin-left: 180px; margin-top: 30px">
            <h4 style="color: #2C6BA0">
                    <asp:Label ID="Label10" Style="font-size: medium; color: #2C6BA0; margin-left: 80px" runat="server" Text=""></asp:Label>
            </h4>
        </div>
    </div>
    <div class="form-group row">
         <div class="col-md-12">
            <asp:Button ID="Button1" class="btn btn-primary" style="margin-left:1000px;margin-top:30px" runat="server" Text ="Apply" OnClick="Button1_Click" />
            <asp:Button ID="Button2" class="btn btn-primary" style="margin-top:30px;margin-left:60px" runat="server" OnClick="Button2_Click" Text="Cancel" />
            <asp:Button ID="Button3" class="btn btn-primary" style="margin-top:30px;margin-left:60px" runat="server" OnClick="Button3_Click" Text="Withdraw" />    
         </div>
    </div>
    <div id="myMap" style="position:relative; width:800px; height:400px;"></div><input type="button" onclick="getMap();" value="Show Map" />
    <footer>
            <div class="progress" style="margin-bottom: 60px">
                <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 90%">
                    <span class="sr-only">90% Complete (danger)</span>
                </div>
            </div>
        </footer>    
  </asp:Panel>
</asp:Content>

