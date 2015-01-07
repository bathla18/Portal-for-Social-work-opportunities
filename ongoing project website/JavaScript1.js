


$(document).ready(function () {
    // Activate carousel
    $("#myCarousel").carousel();

    // Enable carousel control
    $(".left").click(function () {
        $("#myCarousel").carousel('prev');
    });
    $(".right").click(function () {
        $("#myCarousel").carousel('next');
    });
    // Enable carousel indicators
    $(".slide-one").click(function () {
        $("#myCarousel").carousel(0);
    });
    $(".slide-two").click(function () {
        $("#myCarousel").carousel(1);
    });
    $(".slide-three").click(function () {
        $("#myCarousel").carousel(2);
    });
});

$(document).ready(function () {
    $('#login-trigger').click(function () {
        $(this).next('#login-content').slideToggle();
        $(this).toggleClass('active');

        if ($(this).hasClass('active')) $(this).find('span').html('&#x25B2;')
        else $(this).find('span').html('&#x25BC;')
    })
});

$(function () {
    $('.button-checkbox').each(function () {

        // Settings
        var $widget = $(this),
            $button = $widget.find('button'),
            $checkbox = $widget.find('input:checkbox'),
            color = $button.data('color'),
            settings = {
                on: {
                    icon: 'glyphicon glyphicon-check'
                },
                off: {
                    icon: 'glyphicon glyphicon-unchecked'
                }
            };

        // Event Handlers
        $button.on('click', function () {
            $checkbox.prop('checked', !$checkbox.is(':checked'));
            $checkbox.triggerHandler('change');
            updateDisplay();
        });
        $checkbox.on('change', function () {
            updateDisplay();
        });

        // Actions
        function updateDisplay() {
            var isChecked = $checkbox.is(':checked');

            // Set the button's state
            $button.data('state', (isChecked) ? "on" : "off");

            // Set the button's icon
            $button.find('.state-icon')
                .removeClass()
                .addClass('state-icon ' + settings[$button.data('state')].icon);

            // Update the button's color
            if (isChecked) {
                $button
                    .removeClass('btn-default')
                    .addClass('btn-' + color + ' active');
            }
            else {
                $button
                    .removeClass('btn-' + color + ' active')
                    .addClass('btn-default');
            }
        }

        // Initialization
        function init() {

            updateDisplay();

            // Inject the icon if applicable
            if ($button.find('.state-icon').length == 0) {
                $button.prepend('<i class="state-icon ' + settings[$button.data('state')].icon + '"></i>');
            }
        }
        init();
    });
});

//for map 
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
