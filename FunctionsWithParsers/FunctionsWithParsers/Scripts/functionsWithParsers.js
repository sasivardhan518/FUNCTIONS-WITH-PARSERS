var tableData = [];
var getDataTable = function () {
    $.ajax({
        type: "GET",
        traditional: true,
        async: false,
        cache: false,
        url: '/DataTable/Index',
        context: document.body,
        success: function (result) {
            tableData =JSON.parse(result);
            console.log(tableData);
            bindData(tableData);
        },
        error: function (xhr) {
            //debugger;  
            console.log(xhr.responseText);
            alert("Error has occurred..");
        }
    });  
    
};
var getExcelDataTable = function () {
    $.ajax({
        type: "GET",
        traditional: true,
        async: false,
        cache: false,
        url: '/Excel/Index',
        context: document.body,
        success: function (result) {
            if (result) {
                alert("exported");
            }
        },
        error: function (xhr) {
            //debugger;  
            console.log(xhr.responseText);
            alert("Error has occurred..");
        }
    }); 
}
var bindData = function (data) {
    var keys = _.keys(data[0]);
    var getTd = function (data) {
        var tdString = "";
        _.each(keys, function (x) {
            tdString += "<td>" + data[x] + "</td>";
        });
        return tdString;
    }
    $('#dataTable').empty();
    $('#dataTable').append("<table id='dataGrid'></table>")
    _.each(keys, function (i) {
        $('#dataGrid').append("<th>" + i + "</th>");
    });
    _.each(data, function (x) {
        $('#dataGrid').append("<tr>" + getTd(x) + "</tr>");
    });
};