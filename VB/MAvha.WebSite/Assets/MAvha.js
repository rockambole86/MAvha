$(function () {
    $.support.cors = true;

    var ws = "/Default.aspx/";
    var grid;

    $("#dtpDOB").datepicker({
        autoclose: true
    });

    $("#btnRefresh").click(function (e) {
        e.preventDefault();

        loadData();
    });

    $("#btnSave").click(function (e) {
        e.preventDefault();

        var person = {
            Id: $("#txtPersonId").val() | 0,
            Fullname: $("#txtFullname").val(),
            DOB: $("#dtpDOB").val(),
            Age: $("#txtAge").val(),
            Gender: $("#ddlGender").val(),
            IsActive: true
        };

        var data = JSON.stringify(person);

        $.ajax({
            url: ws + "Save",
            type: "POST",
            dataType: "json",
            data: "{'person':" + data + "}",
            contentType: "application/json; charset=utf-8",
            success: function () {
                loadData();

                reset();
            },
            error: function (e) {
                alert("Error");
            }
        });
    });

    $("#btnDelete").click(function (e) {
        var id = $("#txtPersonId").val();

        if (id === "")
            return;

        e.preventDefault();

        $.ajax({
            type: "POST",
            url: ws + "Delete",
            dataType: "json",
            data: "{'id':" + id + "}",
            contentType: "application/json; charset=utf-8",
            success: function () {
                loadData();

                reset();
            },
            error: function (e) {
                alert("Error");
            }
        });
    });

    $("#btnReset").click(function (e) {
        reset();
    });

    $("#grdResults").on("click", "tbody tr", function () {
        var data = grid.row(this).data();

        var person = {
            Id: data[0],
            Fullname: data[1],
            DOB: data[2],
            Age: data[3],
            Gender: data[4],
            IsActive: data[5]
        };

        $("#txtPersonId").val(person.Id);
        $("#txtFullname").val(person.Fullname);
        $("#dtpDOB").datepicker("setDate", moment(person.DOB).toDate());
        $("#txtAge").val(person.Age);
        $("#ddlGender").val(person.Gender);
    });

    function loadData() {
        $.ajax({
            url: ws + "ListJson",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                var dataList = $.parseJSON(data.d);
                var dataSet = [];

                for (var i = 0; i < dataList.length; i++) {
                    var item = dataList[i];

                    var values = $.map(item, function (el) { return el; });

                    dataSet.push(values);
                }

                if ($.fn.DataTable.isDataTable("#grdResults")) {
                    $("#grdResults").DataTable().destroy();
                }

                $("#grdResults tbody").empty();

                grid = $("#grdResults").DataTable({
                    columns: [
                        { title: "Id" },
                        { title: "Nombre completo" },
                        { title: "Fecha nacimiento" },
                        { title: "Edad" },
                        { title: "Sexo" },
                        { title: "Activo" }
                    ],
                    data: dataSet,
                    columnDefs: [
                        {
                            targets: [0, 5],
                            visible: false
                        },
                        {
                            targets: [2],
                            render: function (data, type, row) {
                                return moment(data).format("YYYY-DD-MM");
                            }
                        },
                        {
                            targets: [4],
                            render: function (data, type, row) {
                                return data === 0 ? "Masculino" : "Femenino";
                            }
                        }
                    ],
                    searching: false,
                    ordering: false,
                    language: {
                        info: "Mostrando _START_ a _END_ de _TOTAL_ registros",
                        infoEmpty: "Mostrando 0 a 0 de 0 registros",
                        lengthMenu: "Mostrar _MENU_ registros",
                        emptyTable: "No hay datos",
                        loadingRecords: "Cargando...",
                        processing: "Procesando...",
                        paginate: {
                            first: "Primero",
                            last: "Ultimo",
                            next: "Siguiente",
                            previous: "Previo"
                        }
                    }
                });
            },
            error: function (e) {
                alert("Error");
            }
        });
    };

    function reset() {
        $("#txtPersonId").val("");
        $("#txtFullname").val("");
        $("#dtpDOB").val("");
        $("#txtAge").val("");
        $("#ddlGender").val(0);
    }

    loadData();
});