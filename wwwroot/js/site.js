// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    const toastLive1 = document.getElementById("alertBsAdd");
    const toastLive2 = document.getElementById("alertBsRm");
    const toastBootstrapAdd = bootstrap.Toast.getOrCreateInstance(toastLive1);
    const toastBootstrapRm = bootstrap.Toast.getOrCreateInstance(toastLive2);
    const listItemCart = (dataCart) => {
        let lis = "";
        if (!dataCart) {
            lis += `<li class="list-group-item ms-1 text-center">Emty</li>`;
            $(".countCart").text(0);
        } else {
            dataCart.forEach((item, i) => {
                lis += `<li class="list-group-item ms-1">
                                    <table class="table table-borderless mb-0">
                                        <tr><td>Train:</td><td>${item.scheduleName}</td></tr>
                                        <tr><td>Trip:</td> <td class='fw-bold'>${item.trip}</td></tr>
                                        <tr><td>Departure:</td><td>${item.startAt}</td></tr>
                                        <tr><td colspan='2' class='fw-bold'>${item.seatDetail}</td></tr>
                                        <tr><td colspan='2'>${item.coachClass}</td></tr>
                                    </table></li>`;
            });
            $(".countCart").text(dataCart.length);
        }
        $(".list-cart").html(lis);
    };
    $.get(window.location.origin + "/api/RailwayAjax/listcart", function (data) {
        listItemCart(data);
        if (data != null) {
            let selectSeat
            data.forEach(ele => {
                selectSeat = `[data-schedule="${ele.scheduleId}"][data-coach="${ele.coachId}"][data-seat="${ele.seat}"][data-cabin="${ele.cabin}"]`;
                $(selectSeat).parent().removeClass("et-sit-avaiable");
                $(selectSeat).parent().addClass("et-sit-buying");
            })
        }
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
            });
            toastBootstrapAdd.show()
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
            toastBootstrapRm.show();
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
