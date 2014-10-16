<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertificarPreEmbotellats
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertificarPreEmbotellats))
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtFechaCert = New DevExpress.XtraEditors.DateEdit
    Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
    Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtLitres = New System.Windows.Forms.TextBox
    Me.txtCertificacio = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.lblProducte = New System.Windows.Forms.Label
    Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.txtLots = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    CType(Me.txtFechaCert.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(59, 192)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(133, 14)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Data Certificació:"
    '
    'txtFechaCert
    '
    Me.txtFechaCert.EditValue = New Date(2009, 1, 9, 0, 0, 0, 0)
    Me.txtFechaCert.Location = New System.Drawing.Point(257, 183)
    Me.txtFechaCert.Name = "txtFechaCert"
    Me.txtFechaCert.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtFechaCert.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
    Me.txtFechaCert.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtFechaCert.Properties.EditFormat.FormatString = "dd/MM/yyyy"
    Me.txtFechaCert.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtFechaCert.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
    Me.txtFechaCert.Properties.ValidateOnEnterKey = True
    Me.txtFechaCert.Size = New System.Drawing.Size(96, 23)
    Me.txtFechaCert.TabIndex = 0
    '
    'btnCancelar
    '
    Me.btnCancelar.ImageIndex = 2
    Me.btnCancelar.ImageList = Me.ImageList1
    Me.btnCancelar.Location = New System.Drawing.Point(11, 246)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(145, 30)
    Me.btnCancelar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
    Me.btnCancelar.TabIndex = 10
    Me.btnCancelar.Text = "&Cancel·lar"
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "edit_add.png")
    Me.ImageList1.Images.SetKeyName(1, "apply.png")
    Me.ImageList1.Images.SetKeyName(2, "button_cancel.png")
    '
    'btnAceptar
    '
    Me.btnAceptar.ImageIndex = 1
    Me.btnAceptar.ImageList = Me.ImageList1
    Me.btnAceptar.Location = New System.Drawing.Point(279, 246)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(145, 30)
    Me.btnAceptar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
    Me.btnAceptar.TabIndex = 9
    Me.btnAceptar.Text = "&Acceptar"
    '
    'ErrorProvider1
    '
    Me.ErrorProvider1.ContainerControl = Me
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(59, 116)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(56, 14)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Litres:"
    '
    'txtLitres
    '
    Me.txtLitres.Location = New System.Drawing.Point(257, 110)
    Me.txtLitres.Name = "txtLitres"
    Me.txtLitres.Size = New System.Drawing.Size(132, 20)
    Me.txtLitres.TabIndex = 13
    Me.txtLitres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtCertificacio
    '
    Me.txtCertificacio.Location = New System.Drawing.Point(257, 69)
    Me.txtCertificacio.Name = "txtCertificacio"
    Me.txtCertificacio.Size = New System.Drawing.Size(132, 20)
    Me.txtCertificacio.TabIndex = 14
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(59, 75)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(119, 14)
    Me.Label3.TabIndex = 15
    Me.Label3.Text = "Id Certificació:"
    '
    'lblProducte
    '
    Me.lblProducte.AutoSize = True
    Me.lblProducte.Font = New System.Drawing.Font("Courier New", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProducte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.lblProducte.Location = New System.Drawing.Point(59, 23)
    Me.lblProducte.Name = "lblProducte"
    Me.lblProducte.Size = New System.Drawing.Size(50, 16)
    Me.lblProducte.TabIndex = 16
    Me.lblProducte.Text = "Label4"
    '
    'ErrorProvider2
    '
    Me.ErrorProvider2.ContainerControl = Me
    '
    'txtLots
    '
    Me.txtLots.Location = New System.Drawing.Point(257, 147)
    Me.txtLots.Name = "txtLots"
    Me.txtLots.Size = New System.Drawing.Size(132, 20)
    Me.txtLots.TabIndex = 18
    Me.txtLots.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(59, 153)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(42, 14)
    Me.Label4.TabIndex = 17
    Me.Label4.Text = "Lots:"
    '
    'frmCertificarPreEmbotellats
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(436, 288)
    Me.Controls.Add(Me.txtLots)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.lblProducte)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtCertificacio)
    Me.Controls.Add(Me.txtLitres)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.txtFechaCert)
    Me.Controls.Add(Me.Label2)
    Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmCertificarPreEmbotellats"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " "
    CType(Me.txtFechaCert.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtFechaCert As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton

  Public Sub New()

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

  End Sub
  Friend WithEvents txtLots As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCertificacio As System.Windows.Forms.TextBox
  Friend WithEvents txtLitres As System.Windows.Forms.TextBox
  Friend WithEvents lblProducte As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
  

  Public Sub New(ByVal pidSal As Int32)

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    idSal = pidSal
  End Sub
End Class
