// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    const listItemCart = (dataCart) => {
        let lis = "";
        if (!dataCart) {
            lis += `<li class="list-group-item ms-1 text-center">Emty</li>`;
            $(".countCart").text(0);
        } else {
            dataCart.forEach((item, i) => {
                lis += `<li class="list-group-item ms-1 d-flex flex-column">
                                    <div class="row w-100">
                                        <div class="col-10 ">
                                        <p>Train: ${item.scheduleName}<br/>Trip: ${item.trip}<br/>Departure: ${item.startAt}<br/>${item.seatDetail}<br/>${item.coachClass}</p>
                                        </div>
                                        <div class="col-2">
                                        <a class="text-danger" href="">
                                            <i class="bi bi-trash3"></i>
                                        </a>
                                        </div>
                                    </div></li>`;
            });
            $(".countCart").text(dataCart.length);
        }
        $(".list-cart").html(lis);
    };
    $.get(window.location.origin + "/api/RailwayAjax/listcart", function (data) {
        listItemCart(data);
    })
    $(".sit-available").click(function () {
        let schedule = $(this).data("schedule");
        let coach = $(this).data("coach");
        let seat = $(this).data("seat");
        let starttime=  $(this).data("start");
        let endtime = $(this).data("end");
        let cabin = $(this).data("cabin");
        let coachNo = $(this).data("coachno");
        let from = $(this).data("fromstation");
        let to = $(this).data("tostation");
        let className = $(this).data("classname"); 
        let classCode = $(this).data("class");
        let urlAdd = window.location.origin + "/api/RailwayAjax/addcart";
        let urlRemove = window.location.origin + "/api/RailwayAjax/removeitem";
        /*alert(`Schedule: ${schedule}\nCoach: ${coach}\nSeat :${seat}`);*/
        console.log({
            "scheduleId": schedule,
            "coachId": coach,
            "seat": seat,
            "startAt": starttime,
            "endAt": endtime,
            "cabin": cabin,
            "coachNo": coachNo,
            "fromStation": from,
            "toStation": to,
            "coachClass": classCode,
            "coachClassName": className 
        });
        if ($(this).parent().hasClass("et-sit-avaiable")) {
            $.ajax({
                type: "POST",
                url: urlAdd,
                data: {
                    "scheduleId": schedule,
                    "coachId": coach,
                    "seat": seat,
                    "startAt": starttime,
                    "endAt": endtime,
                    "cabin": cabin,
                    "coachNo": coachNo,
                    "fromStation": from,
                    "toStation": to,
                    "coachClass": classCode,
                    "coachClassName": className 
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
                    "scheduleId": schedule,
                    "coachId": coach,
                    "seat": seat
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
    });
    $(".train-coach2").click(function () {
        $(this).parent().siblings().find(".train-coach2").removeClass("active");
        $(this).toggleClass("active");
    })
    jQuery('.train-coach, .train-coach2').click(function (e) {
        jQuery('.collapse').collapse('hide');
    });
});
