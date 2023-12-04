// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(".et-sit-no").click(function () {
        let schedule = $(this).data("schedule");
        let coach = $(this).data("coach");
        let seat = $(this).data("seat");
        let userid = $(this).data("user");
        let url = window.location.origin + "/api/RailwayAjax/addbooking";
        /*alert(`Schedule: ${schedule}\nCoach: ${coach}\nSeat :${seat}`);*/
        console.log({
            'ScheduleId': schedule,
            'CoachId': coach,
            'Seat': seat,
            'CIDNo': userid
        });
        console.log(url);
        /*$.ajax({
            type: "POST",
            url: url,
            data: {
                'ScheduleId': schedule,
                'CoachId': coach,
                'Seat': seat,
                'CIDNo': userid
            },
            success: function (data) {
                console.log(data)
            },
            dataType: 'json'
        }).fail(function () {
            alert("error");
        }).always(function () {
            alert("complete");
        });;*/
    });
    $(".train-coach").click(function () {
        $(this).siblings().removeClass("active");
        $(this).addClass("active");
    })
});
