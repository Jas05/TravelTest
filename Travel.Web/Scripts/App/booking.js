validateUser = function (bookingRef, surname) {
    // var updatedValue = $("#editJourneyTypeName" + journeyTypeId).val();
    $.ajax({
        url: "/Journey/EditJourneyType",
        data: { bookingRef: bookingRef, surname: surname },
        success: function (data) {
            window.location.href = "/Details/Index"
        },
        error: function (ex) {
            console.log(ex)

        }
    });
};