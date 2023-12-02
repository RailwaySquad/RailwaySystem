const theme = {
    primary: "var(--fc-primary)", secondary: "var(--fc-secondary)",
    success: "var(--fc-success)", info: "var(--fc-info)",
    warning: "var(--fc-warning)", danger: "var(--fc-danger)",
    dark: "var(--fc-dark)", light: "var(--fc-light)",
    white: "var(--fc-white)",
    gray100: "var(--fc-gray-100)",
    gray200: "var(--fc-gray-200)",
    gray300: "var(--fc-gray-300)",
    gray400: "var(--fc-gray-400)",
    gray500: "var(--fc-gray-500)",
    gray600: "var(--fc-gray-600)",
    gray700: "var(--fc-gray-700)",
    gray800: "var(--fc-gray-800)",
    gray900: "var(--fc-gray-900)",
    black: "var(--fc-black)",
    transparent: "transparent"
};
window.theme = theme,


    $(function () {
        // Biểu đồ không được khởi tạo ban đầu
        var myChart = null;
        var _chartLabels = ['Label 1', 'Label 2', 'Label 3'];
        var _total = [100, 150, 200];
        var myChart;
        // Hàm khởi tạo biểu đồ
        function initializeChart(BookingDate, total) {
            // Chuyển đổi chuỗi ngày thành đối tượng Date
            BookingDate = BookingDate.map(dateString => new Date(dateString));
            // Chuyển đối tượng Date thành tên tháng
            var monthNames = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
            var monthLabels = BookingDate.map(date => monthNames[date.getMonth()]);
            var options = {
                series: [{
                    name: "Total Income", data: total
                }],
                labels: monthLabels,
                chart: {
                    height: 350, type: "area", toolbar: { show: !1 }
                },
                dataLabels: { enabled: !1 },
                markers: { size: 5, hover: { size: 6, sizeOffset: 3 } },
                colors: ["#0aad0a", "#ffc107"],
                stroke: { curve: "smooth", width: 2 },
                grid: { borderColor: window.theme.gray300 },
                xaxis: {
                    labels: {
                        show: !0, align: "right", minWidth: 0, maxWidth: 160, style: {
                            fontSize: "12px", fontWeight: 400, colors: [window.theme.gray600],
                            fontFamily: '"Inter", "sans-serif"'
                        }
                    },
                    axisBorder: { show: !0, color: window.theme.gray300, height: 1, width: "100%", offsetX: 0, offsetY: 0 },
                    axisTicks: { show: !0, borderType: "solid", color: window.theme.gray300, height: 6, offsetX: 0, offsetY: 0 }
                },
                legend: {
                    position: "top", fontWeight: 600, color: window.theme.gray600, markers: { width: 8, height: 8, strokeWidth: 0, strokeColor: "#fff", fillColors: void 0, radius: 12, customHTML: void 0, onClick: void 0, offsetX: 0, offsetY: 0 },
                    labels: { colors: window.theme.gray600, useSeriesColors: !1 }
                },
                yaxis: {
                    labels: {
                        formatter: function (e) { return e + "k" },
                        show: !0, align: "right", minWidth: 0, maxWidth: 160, style: {
                            fontSize: "12px", fontWeight: 400, colors: window.theme.gray600, fontFamily: '"Inter", "sans-serif"'
                        }
                    }
                }
            };

            // Tạo biểu đồ mới
            if (!myChart) {
                // Nếu chưa, tạo biểu đồ mới
                myChart = new ApexCharts(document.getElementById("revenueChart"), options);
                myChart.render();
            } else {
                // Nếu đã khởi tạo, cập nhật dữ liệu và tùy chọn
                myChart.updateSeries([{ data: total }]);
                myChart.updateOptions({ xaxis: { categories: BookingDate } });
            }
        }

        // Hàm xử lý lỗi
        function OnError(err) {
            console.error("Error:", err);
        }

        // Khởi tạo biểu đồ ngay khi trang được tải
        var selectedYear = $("#yearSelector").val();

        $.ajax({
            type: "POST",
            url: "/DashBoard/ShowData",
            data: { year: selectedYear },
            success: function (data) {

                if (data) {
                    var _data = data;
                    var _chartLabels = _data[0];
                    var _total = _data[1];

                    // Gọi hàm để khởi tạo biểu đồ
                    initializeChart(_chartLabels, _total);
                }
            },
            error: OnError
        });

        // Bắt sự kiện change của ô chọn năm
        $("#yearSelector").change(function () {
            var selectedYear = $(this).val();

            $.ajax({
                type: "POST",
                url: "/DashBoard/ShowData",
                data: { year: selectedYear },
                success: function (data) {
                    var _data = data;
                    var _chartLabels = _data[0];
                    var _total = _data[1];

                    // Gọi hàm để khởi tạo hoặc cập nhật biểu đồ
                    initializeChart(_chartLabels, _total);
                },
                error: OnError
            });
        });
    });