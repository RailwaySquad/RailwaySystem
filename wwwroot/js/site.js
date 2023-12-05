// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    const listItemCart = (dataCart) => {
        let lis = "";
        if (!dataCart) {
            lis += `<li class="list-group-item ms-1 text-center">Emty</li>`;
        } else {
            dataCart.forEach((item, i) => {
                lis += `<li class="list-group-item ms-1 d-flex flex-column">
                                    <div class="row w-100">
                                        <div class="col-10 ">
                                        ${item.title}
                                        </div>
                                        <div class="col-2">
                                        <a class="text-danger" href="">
                                            <i class="bi bi-trash3"></i>
                                        </a>
                                        </div>
                                    </div>
                                    <div>${item.startAt}</div>
                                    <div>${item.seatDetail}</div</li>`;
            });
        }
        $(".list-cart").html(lis);
        $(".countCart").text(dataCart.length);
    };
    $(".sit-available").click(function () {
        let schedule = $(this).data("schedule");
        let coach = $(this).data("coach");
        let seat = $(this).data("seat");
        let urlAdd = window.location.origin + "/api/RailwayAjax/addcart";
        let urlRemove = window.location.origin + "/api/RailwayAjax/removeitem";
        /*alert(`Schedule: ${schedule}\nCoach: ${coach}\nSeat :${seat}`);*/
        console.log({
            "ScheduleId": schedule,
            "CoachId": coach,
            "Seat": seat
        });
        if ($(this).parent().hasClass("et-sit-avaiable")) {
            $.ajax({
                type: "POST",
                url: urlAdd,
                data: {
                    "ScheduleId": schedule,
                    "CoachId": coach,
                    "Seat": seat
                },
                success: function (data) {
                    listItemCart(data);
                },
                dataType: 'json'
            }).fail(function () {
                console.log("error");
            }).always(function () {
                console.log("complete");
            });;
        } else {
            $.ajax({
                type: "POST",
                url: urlRemove,
                data: {
                    "ScheduleId": schedule,
                    "CoachId": coach,
                    "Seat": seat
                },
                success: function (data) {
                    listItemCart(data);
                },
                dataType: 'json'
            }).fail(function () {
                console.log("error");
            }).always(function () {
                console.log("complete");
            });;
        }
        $(this).parent().toggleClass("et-sit-avaiable");
        $(this).parent().toggleClass("et-sit-buying");
    });
    $(".clearCart").click(function () {
        $.ajax({
            type: "GET",
            url: window.location.origin + "/api/RailwayAjax/clearCart",
            success: function (data) {
                console.log(data);
                listItemCart(null);
                $(".sit-available").forEach(element => {
                    if (element.parent().hasClass("et-sit-buying")) {
                        element.parent().removeClass("et-sit-buying");
                        element.parent().addClass("et-sit-avaiable");
                    }
                })
            },
            dataType: 'json'
        }).fail(function () {
            console.log("error");
        }).always(function () {
            console.log("complete");
        });;
    })
    $(".train-coach").click(function () {
        $(this).siblings().removeClass("active");
        $(this).toggleClass("active");
    })
});
