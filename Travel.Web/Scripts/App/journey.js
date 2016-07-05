$("#createNewJourneyType").on('click', function () {
    var newJourneyType = $("#newJourneyType").val();
    if (newJourneyType) {
        $.ajax({
            url: "/Journey/Create",
            async:false,
            data: { newJourneyType: newJourneyType },
            success: function (data) {
                location.reload();
            },
            error: function (ex) {
                console.log(ex);
            }
        });
    } else {
        // display validation error
    }
});

deleteJourneyType = function (journeyTypeId) {
    if (journeyTypeId) {
        $.ajax({
            url: "Journey/Delete",
            async: false,
            data: { id: journeyTypeId },
            success: function (data) {
                location.reload();
            },
            error: function (ex) {
                console.log(ex)
            }
        });
    }
}