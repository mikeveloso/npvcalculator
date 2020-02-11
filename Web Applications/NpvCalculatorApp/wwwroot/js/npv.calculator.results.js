$(document).ready(function () {
    var options = {
        zoomEnabled: true,
        animationEnabled: true,
        animationEnabled: true,
        theme: "light2",
        title: {
            text: "Net Present Value"
        },
        axisX: {
            title: "Net Present Value",
            valueFormatString: "$#,##0.00",
            prefex: "$",
            minimum: npvMin,
            includeZero: true,
            labelFontWeight: "bold",
            labelFormatter: function (e) {
                var xValue = e.value;
                var xLabel = "";

                if (xValue < 0) {
                    xLabel = "($" + CanvasJS.formatNumber((xValue * -1), "#,##0.00") + ")";
                } else {
                    xLabel = "$" + CanvasJS.formatNumber(xValue, "#,##0.00");
                }

                return xLabel;
            }
        },
        axisY: {
            title: "Rate",
            includeZero: false,
            minimum: 0,
            maximum: 15,
            interval: 1,
            suffix: "%",
            valueFormatString: "#,##0.00",
            labelFontWeight: "bold"
        },
        toolTip: {
            shared: true,
            contentFormatter: function (e) {
                var content = "";
                for (var i = 0; i < e.entries.length; i++) {
                    var xValue = e.entries[i].dataPoint.x;

                    content += "<b>Net Present Value:<b>";

                    if (xValue < 0) {
                        content += "<span style=\"color:#ff0000;\">($" + CanvasJS.formatNumber((xValue * -1), "#,##0.00") + ")";
                    } else {
                        content += "<span style=\"color:#000;\">$" + CanvasJS.formatNumber(xValue, "#,##0.00") + "</span>";
                    }

                    content += "</span><br/>";
                    content += "<b>Rate:<b><span style=\"color:#000\">" + CanvasJS.formatNumber((e.entries[i].dataPoint.y / 100), "#,##0.00%") + "</span>";
                }

                return content;
            }
        },
        data: [{
            type: "column",
            showInLegend: false,
            includeZero: true,
            xValueFormatString: "$#,##0.00",
            yValueFormatString: "#,##0.00" % "",
            dataPoints: npvChartData
        }]
    };

    function toggleDataSeries(e) {
        if (typeof (e.dataSeries.visible) === "undefined" || e.dataSeries.visible) {
            e.dataSeries.visible = false;
        } else {
            e.dataSeries.visible = true;
        }
        e.chart.render();
    }

    $("#chartContainer").CanvasJSChart(options);
});