$("#createNewJourneyType").on('click', function () {
    var newJourneyType = $("#newJourneyType").val();
    if (newJourneyType) {
        $.ajax({
            type:"GET",
            url: "/Journey/Create",
            dataType: "text",
            data: { newJourneyType: newJourneyType },
            success: function (data) {
                location.reload();
            },
            error: function (ex) {
                console.log(ex.responseText);
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
            data: { id: journeyTypeId },
            success: function (data) {
                location.reload();
            },
            error: function (ex) {
                console.log(ex)
            }
        });
    }
};

UpdateJourneyType = function (journeyTypeId, journeyTypeName) {
    var updatedValue = $("#editJourneyTypeName" + journeyTypeId).val();
    console.log("updateJourneyType")
    $.ajax({
        url: "/Journey/EditJourneyType",
        data: { id: journeyTypeId, journeyTypeName: updatedValue },
        success: function (data) {
            window.location.href = "/Journey/Index"
        },
        error: function (ex) {
            console.log(ex)

        }
    });
};



