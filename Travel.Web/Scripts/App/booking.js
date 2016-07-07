$("#loginUser").click(function () {
        // var updatedValue = $("#editJourneyTypeName" + journeyTypeId).val();
        var bookingref = $("#BookingReference").val();
        var surname = $("#LastName").val();
        $.ajax({
            url: "/Booking/ValidateUser",
            data: { bookingRef: bookingref, surname: surname },
            success: function (data) {
                var currentUrl = window.location.href.split('?')[0]
                window.location.href = currentUrl + "Details/Index";
            },
            error: function (ex) {
                console.log(ex)

            }
        });
    });
