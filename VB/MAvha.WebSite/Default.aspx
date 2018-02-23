<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!doctype html>

<html lang="en">
<head runat="server">
    <title>MAvha</title>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">

    <link rel="shortcut icon" type="image/png" href="./Assets/MAvha.png"/>

    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <link rel="stylesheet" href="./Assets/AdminLTE.min.css">
    <link rel="stylesheet" href="./Assets/font-awesome.min.css">
    <link rel="stylesheet" href="./Assets/bootstrap-datepicker.min.css">
    <link rel="stylesheet" href="./Assets/dataTables.bootstrap.min.css">
</head>

<body>
<form id="frmMain" runat="server" role="form">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-primary">
                    <div class="box-header with-border">
                        <h3 class="box-title">Información</h3>
                    </div>

                    <div class="box-body">
                        <input type="hidden" id="txtPersonId" />

                        <div class="form-group">
                            <label>Nombre completo</label>
                            <input id="txtFullname" type="text" class="form-control" maxlength="100" placeholder="Nombre completo ...">
                        </div>

                        <div class="form-group">
                            <label>Fecha de nacimiento</label>
                            <div class="input-group date">
                                <div class="input-group-addon">
                                    <i class="fa fa-calendar"></i>
                                </div>
                                <input type="text" class="form-control pull-right" id="dtpDOB">
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="row">
                                <div class="col-md-1">
                                    <label>Edad</label>
                                    <input id="txtAge" type="text" class="form-control" maxlength="100" placeholder="20">
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="row">
                                <div class="col-md-2">
                                    <label>Sexo</label>
                                    <select class="form-control" id="ddlGender">
                                        <option value="0">Masculino</option>
                                        <option value="1">Femenino</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <div class="box-footer text-right">
                        <button class="btn btn-flat" type="button" id="btnRefresh">Refrescar</button>
                        <button class="btn btn-flat btn-primary" type="button" id="btnSave">Grabar</button>
                        <button class="btn btn-flat" type="button" id="btnDelete">Eliminar</button>
                        <button class="btn btn-flat btn-success" type="reset" id="btnReset">Limpiar</button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="row">
            <div class="col-md-12">
                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Hover Data Table</h3>
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body">
                        <table id="grdResults" class="table table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>PersonId</th>
                                    <th>Fullname</th>
                                    <th>DOB</th>
                                    <th>Age</th>
                                    <th>Gender</th>
                                    <th>IsActive</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
        </div>
    </div>
</form>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
<script src="./Assets/moment.min.js"></script>
<script src="./Assets/bootstrap-datepicker.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script src="./Assets/dataTables.bootstrap.min.js"></script>
<script src="//cdn.datatables.net/plug-ins/1.10.15/dataRender/datetime.js"></script>
<script src="./Assets/MAvha.js"></script>
</body>
</html>