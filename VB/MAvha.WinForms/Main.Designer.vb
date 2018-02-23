<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ddlGender = New System.Windows.Forms.ComboBox()
        Me.txtAge = New System.Windows.Forms.NumericUpDown()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grdResults = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        CType(Me.txtAge,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grdResults,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ddlGender)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.txtFullname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Información"
        '
        'ddlGender
        '
        Me.ddlGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlGender.FormattingEnabled = true
        Me.ddlGender.Location = New System.Drawing.Point(110, 99)
        Me.ddlGender.Name = "ddlGender"
        Me.ddlGender.Size = New System.Drawing.Size(147, 21)
        Me.ddlGender.TabIndex = 13
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(110, 73)
        Me.txtAge.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.txtAge.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(68, 20)
        Me.txtAge.TabIndex = 12
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAge.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(110, 47)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(105, 20)
        Me.dtpDOB.TabIndex = 11
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(110, 21)
        Me.txtFullname.MaxLength = 100
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(306, 20)
        Me.txtFullname.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(65, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(64, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Edad"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(5, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha nacimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre completo"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(599, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(599, 59)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(599, 30)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Grabar"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'grdResults
        '
        Me.grdResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdResults.Location = New System.Drawing.Point(12, 158)
        Me.grdResults.Name = "grdResults"
        Me.grdResults.RowHeadersVisible = false
        Me.grdResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdResults.Size = New System.Drawing.Size(680, 192)
        Me.grdResults.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(617, 356)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refrescar"
        Me.btnRefresh.UseVisualStyleBackColor = true
        '
        'Main
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 391)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.grdResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(720, 430)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAvha"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.txtAge,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdResults,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ddlGender As ComboBox
    Friend WithEvents txtAge As NumericUpDown
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents grdResults As DataGridView
    Friend WithEvents btnRefresh As Button
End Class
