<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formkaryawan
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
        txtpassword = New TextBox()
        txtusername = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtkaryawan = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtemail = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtakses = New TextBox()
        Label8 = New Label()
        cmbkelamin = New ComboBox()
        cmbtanggallahir = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        txtsearch = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(128, 86)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(140, 23)
        txtpassword.TabIndex = 7
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(128, 46)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(140, 23)
        txtusername.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        ' 
        ' txtkaryawan
        ' 
        txtkaryawan.Location = New Point(128, 128)
        txtkaryawan.Name = "txtkaryawan"
        txtkaryawan.Size = New Size(140, 23)
        txtkaryawan.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 9
        Label3.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 15)
        Label4.TabIndex = 8
        Label4.Text = "Nama Karyawan"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(128, 207)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(140, 23)
        txtemail.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 13
        Label5.Text = "Tanggal Lahir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(86, 210)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 12
        Label6.Text = "Email"
        ' 
        ' txtakses
        ' 
        txtakses.Location = New Point(128, 288)
        txtakses.Name = "txtakses"
        txtakses.Size = New Size(140, 23)
        txtakses.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(61, 291)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 15)
        Label8.TabIndex = 16
        Label8.Text = "Hak Akses"
        ' 
        ' cmbkelamin
        ' 
        cmbkelamin.FormattingEnabled = True
        cmbkelamin.Items.AddRange(New Object() {"Pria", "Wanita"})
        cmbkelamin.Location = New Point(128, 168)
        cmbkelamin.Name = "cmbkelamin"
        cmbkelamin.Size = New Size(140, 23)
        cmbkelamin.TabIndex = 19
        ' 
        ' cmbtanggallahir
        ' 
        cmbtanggallahir.Location = New Point(128, 250)
        cmbtanggallahir.Name = "cmbtanggallahir"
        cmbtanggallahir.Size = New Size(140, 23)
        cmbtanggallahir.TabIndex = 20
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(304, 49)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(431, 262)
        DataGridView1.TabIndex = 21
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(193, 333)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 23
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(112, 333)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 22
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(193, 362)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 25
        Button3.Text = "Keluar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(112, 362)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 24
        Button4.Text = "Hapus"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(660, 333)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 26
        Button5.Text = "Cari Data"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(514, 333)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(140, 23)
        txtsearch.TabIndex = 27
        ' 
        ' formkaryawan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtsearch)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(cmbtanggallahir)
        Controls.Add(cmbkelamin)
        Controls.Add(txtakses)
        Controls.Add(Label8)
        Controls.Add(txtemail)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(txtkaryawan)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "formkaryawan"
        Text = "formkaryawan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtkaryawan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtakses As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbkelamin As ComboBox
    Friend WithEvents cmbtanggallahir As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtsearch As TextBox
End Class
