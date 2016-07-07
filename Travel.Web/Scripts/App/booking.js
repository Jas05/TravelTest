$("#Login")
{
    // var updatedValue = $("#editJourneyTypeName" + journeyTypeId).val();
    var bookingref = $("#BookingReference").val();
    var surname = $("#LastName").val();
    $.ajax({
        url: "/Booking/ValidateUser",
        data: { bookingRef: bookingref, surname: surname },
        success: function (data) {
            window.location.href = "/Details/Index"
        },
        error: function (ex) {
            console.log(ex)

        }
    });
};