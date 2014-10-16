Imports PcsNet.AnaWin.Db
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports Microsoft

Public Class frmArticulos
  'Inherits System.Windows.Forms.Form
  Inherits frmMtoBaseManual
  Private rowArticles As tblArticlesFinalsRow
  Private rowArticlesOld As tblArticlesFinalsRow
  Private veDeMant As Boolean
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents cmbDO As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtAñada As DevExpress.XtraEditors.CalcEdit
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtGraus As DevExpress.XtraEditors.CalcEdit
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents cmbRecipientes As System.Windows.Forms.ComboBox
  Friend WithEvents cmbColor As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtArticleFactusol As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Private dtHistorico As New DataTable
  Friend WithEvents cmbTipoProducte As DevExpress.XtraEditors.ComboBoxEdit
  Private dtArt As DataTable

#Region " Código generado por el Diseñador de Windows Forms "

  Public Sub New()
    MyBase.New()

    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()

    'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    InicializaControlesPK()
    veDeMant = False
    InicializaFormulario(Nothing, BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Lectura)
    iniciaCmbDO()
    iniciaCmbColor()
    iniciaCmbTipoProducto()
    iniciaCmbRecipients()
    mdlFactusol.obtenirConexioFactusol()

  End Sub

  Public Sub New(ByVal id As String)
    MyBase.New()

    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()

  End Sub
  'Form reemplaza a Dispose para limpiar la lista de componentes.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
  'Puede modificarse utilizando el Diseñador de Windows Forms. 
  'No lo modifique con el editor de código.
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtidArticulo As DevExpress.XtraEditors.ButtonEdit
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
    Me.txtNombre = New DevExpress.XtraEditors.TextEdit
    Me.txtidArticulo = New DevExpress.XtraEditors.ButtonEdit
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.cmbTipoProducte = New DevExpress.XtraEditors.ComboBoxEdit
    Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
    Me.txtArticleFactusol = New DevExpress.XtraEditors.ButtonEdit
    Me.Label9 = New System.Windows.Forms.Label
    Me.cmbColor = New DevExpress.XtraEditors.ComboBoxEdit
    Me.Label7 = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.cmbRecipientes = New System.Windows.Forms.ComboBox
    Me.cmbDO = New DevExpress.XtraEditors.ComboBoxEdit
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.txtAñada = New DevExpress.XtraEditors.CalcEdit
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtGraus = New DevExpress.XtraEditors.CalcEdit
    CType(Me.ErroresProvider, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtidArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.cmbTipoProducte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtArticleFactusol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cmbColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cmbDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    CType(Me.txtAñada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtGraus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNombre
    '
    Me.txtNombre.EditValue = ""
    Me.txtNombre.Location = New System.Drawing.Point(120, 60)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Properties.MaxLength = 40
    Me.txtNombre.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
    Me.txtNombre.Size = New System.Drawing.Size(259, 20)
    Me.txtNombre.TabIndex = 1
    '
    'txtidArticulo
    '
    Me.txtidArticulo.EditValue = ""
    Me.txtidArticulo.Location = New System.Drawing.Point(15, 60)
    Me.txtidArticulo.Name = "txtidArticulo"
    Me.txtidArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
    Me.txtidArticulo.Properties.MaxLength = 4
    Me.txtidArticulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
    Me.txtidArticulo.Size = New System.Drawing.Size(99, 20)
    Me.txtidArticulo.TabIndex = 0
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(120, 45)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(90, 15)
    Me.Label2.TabIndex = 18
    Me.Label2.Text = "Descripció:"
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(15, 45)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(60, 15)
    Me.Label1.TabIndex = 17
    Me.Label1.Text = "Codi:"
    '
    'GridView1
    '
    Me.GridView1.GridControl = Nothing
    Me.GridView1.Name = "GridView1"
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.GroupBox2)
    Me.TabPage1.Location = New System.Drawing.Point(4, 23)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Size = New System.Drawing.Size(517, 233)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Dades Generals"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.cmbTipoProducte)
    Me.GroupBox2.Controls.Add(Me.TextEdit1)
    Me.GroupBox2.Controls.Add(Me.txtArticleFactusol)
    Me.GroupBox2.Controls.Add(Me.Label9)
    Me.GroupBox2.Controls.Add(Me.cmbColor)
    Me.GroupBox2.Controls.Add(Me.Label7)
    Me.GroupBox2.Controls.Add(Me.Label8)
    Me.GroupBox2.Controls.Add(Me.cmbRecipientes)
    Me.GroupBox2.Controls.Add(Me.cmbDO)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Location = New System.Drawing.Point(8, 3)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(496, 227)
    Me.GroupBox2.TabIndex = 8
    Me.GroupBox2.TabStop = False
    '
    'cmbTipoProducte
    '
    Me.cmbTipoProducte.EditValue = ""
    Me.cmbTipoProducte.Location = New System.Drawing.Point(146, 57)
    Me.cmbTipoProducte.Name = "cmbTipoProducte"
    Me.cmbTipoProducte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cmbTipoProducte.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
    Me.cmbTipoProducte.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.cmbTipoProducte.Properties.ValidateOnEnterKey = True
    Me.cmbTipoProducte.Size = New System.Drawing.Size(309, 23)
    Me.cmbTipoProducte.TabIndex = 100
    '
    'TextEdit1
    '
    Me.TextEdit1.EditValue = ""
    Me.TextEdit1.Location = New System.Drawing.Point(196, 181)
    Me.TextEdit1.Name = "TextEdit1"
    Me.TextEdit1.Properties.MaxLength = 40
    Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
    Me.TextEdit1.Size = New System.Drawing.Size(259, 20)
    Me.TextEdit1.TabIndex = 98
    '
    'txtArticleFactusol
    '
    Me.txtArticleFactusol.EditValue = "0"
    Me.txtArticleFactusol.Location = New System.Drawing.Point(146, 181)
    Me.txtArticleFactusol.Name = "txtArticleFactusol"
    Me.txtArticleFactusol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
    Me.txtArticleFactusol.Properties.MaxLength = 4
    Me.txtArticleFactusol.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
    Me.txtArticleFactusol.Size = New System.Drawing.Size(44, 20)
    Me.txtArticleFactusol.TabIndex = 97
    '
    'Label9
    '
    Me.Label9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(11, 181)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(122, 20)
    Me.Label9.TabIndex = 99
    Me.Label9.Text = "Art. Factusol:"
    '
    'cmbColor
    '
    Me.cmbColor.EditValue = ""
    Me.cmbColor.Location = New System.Drawing.Point(146, 19)
    Me.cmbColor.Name = "cmbColor"
    Me.cmbColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cmbColor.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
    Me.cmbColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.cmbColor.Properties.ValidateOnEnterKey = True
    Me.cmbColor.Size = New System.Drawing.Size(309, 23)
    Me.cmbColor.TabIndex = 96
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(14, 28)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(49, 14)
    Me.Label7.TabIndex = 95
    Me.Label7.Text = "Color:"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(11, 144)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(126, 14)
    Me.Label8.TabIndex = 94
    Me.Label8.Text = "Recipient Sortida"
    '
    'cmbRecipientes
    '
    Me.cmbRecipientes.FormattingEnabled = True
    Me.cmbRecipientes.Location = New System.Drawing.Point(146, 141)
    Me.cmbRecipientes.Name = "cmbRecipientes"
    Me.cmbRecipientes.Size = New System.Drawing.Size(309, 22)
    Me.cmbRecipientes.TabIndex = 93
    '
    'cmbDO
    '
    Me.cmbDO.EditValue = ""
    Me.cmbDO.Location = New System.Drawing.Point(146, 97)
    Me.cmbDO.Name = "cmbDO"
    Me.cmbDO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cmbDO.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.WindowText)
    Me.cmbDO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.cmbDO.Properties.ValidateOnEnterKey = True
    Me.cmbDO.Size = New System.Drawing.Size(309, 23)
    Me.cmbDO.TabIndex = 65
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(14, 105)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(119, 15)
    Me.Label5.TabIndex = 66
    Me.Label5.Text = "D.O.:"
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(14, 65)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(45, 15)
    Me.Label6.TabIndex = 14
    Me.Label6.Text = "Tipus:"
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabControl1.Location = New System.Drawing.Point(8, 96)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(525, 260)
    Me.TabControl1.TabIndex = 5
    '
    'txtAñada
    '
    Me.txtAñada.Location = New System.Drawing.Point(388, 60)
    Me.txtAñada.Name = "txtAñada"
    Me.txtAñada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
    Me.txtAñada.Properties.DisplayFormat.FormatString = "###,##0"
    Me.txtAñada.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtAñada.Properties.EditFormat.FormatString = "###,##0"
    Me.txtAñada.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtAñada.Properties.NullText = "0"
    Me.txtAñada.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
    Me.txtAñada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.txtAñada.Size = New System.Drawing.Size(57, 20)
    Me.txtAñada.TabIndex = 87
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(385, 45)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(90, 15)
    Me.Label3.TabIndex = 90
    Me.Label3.Text = "Anyada:"
    '
    'Label4
    '
    Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(451, 45)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(90, 15)
    Me.Label4.TabIndex = 89
    Me.Label4.Text = "Graus:"
    '
    'txtGraus
    '
    Me.txtGraus.Location = New System.Drawing.Point(454, 60)
    Me.txtGraus.Name = "txtGraus"
    Me.txtGraus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
    Me.txtGraus.Properties.DisplayFormat.FormatString = "###,##0.00"
    Me.txtGraus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtGraus.Properties.EditFormat.FormatString = "###,##0.00"
    Me.txtGraus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtGraus.Properties.NullText = "0"
    Me.txtGraus.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
    Me.txtGraus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.txtGraus.Size = New System.Drawing.Size(65, 20)
    Me.txtGraus.TabIndex = 88
    '
    'frmArticulos
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(540, 368)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.txtNombre)
    Me.Controls.Add(Me.txtidArticulo)
    Me.Controls.Add(Me.txtAñada)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtGraus)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.Name = "frmArticulos"
    Me.Text = "   Articles Finals"
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtGraus, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.txtAñada, 0)
    Me.Controls.SetChildIndex(Me.txtidArticulo, 0)
    Me.Controls.SetChildIndex(Me.txtNombre, 0)
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    CType(Me.ErroresProvider, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtidArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    CType(Me.cmbTipoProducte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtArticleFactusol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cmbColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cmbDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    CType(Me.txtAñada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtGraus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region

#Region " Mètodes INICIALITZACIO "

  Private Sub InicializaControlesPK()
    'Añadimos los controles que forman parte de la clave
    ListaColtrolesPK.Add(Me.txtidArticulo)
    'Añadimos el control que recogera el foco cuando se activa la clave.
    ColtrolFocusPK = Me.txtidArticulo
    'Añadimos el control que recogera el foco cuando se desactiva la clave.
    ColtrolFocusNoPK = Me.txtNombre

  End Sub

  Private Sub InicializaFormulario(ByVal Id As String, ByVal Modo As BotoneraMantenimiento.enumBotoneraMantenimientoEstado)
    Select Case Modo
      Case BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Lectura
        'Si podemos cargar la entidad solicitada por ID, pasamos a modo lectura.
        If CargaEntidad(Id) Then
          btmBotoneraMantenimiento.CambioEstado(BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Lectura)
          bloquejarControls(Me, True)
        Else
          'Si la entidad solicitada no existe, o no se puede instanciar, cargamos la primera, y pasamos a modo lectura.
          If CargaPrimeraEntidad() Then
            btmBotoneraMantenimiento.CambioEstado(BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Lectura)
            bloquejarControls(Me, True)
          Else
            'Si no podemos cargar la primera, pasamos a modo vacio.
            btmBotoneraMantenimiento.CambioEstado(BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Nuevo)
            rowArticles = New tblArticlesFinalsRow
            ValoresPorDefecto()
            DeshabilitaControlesPK()
          End If
        End If

      Case BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Edicion
        'Si podemos cargar la entidad solicitada por ID, pasamos a modo lectura.
        If CargaEntidad(Id) Then
          btmBotoneraMantenimiento.CambioEstado(BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Edicion)
          bloquejarControls(Me, False)
          DeshabilitaControlesPK()
        Else
          'Si no podemos cargar la entidad solicitada, pasamos a modo vacio.
          btmBotoneraMantenimiento.CambioEstado(BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Vacio)
          bloquejarControls(Me, True)
        End If

      Case BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Nuevo
        btmBotoneraMantenimiento.CambioEstado(BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Nuevo)
        DeshabilitaControlesPK()
        HabilitaControlesPK()

    End Select

    EntidadAControles()

  End Sub

  Public Overrides Sub bloquejarControls(ByRef ControlPare As System.Windows.Forms.Control, ByVal bloquejar As Boolean)
    bloquejarTotsControls(Me, bloquejar)
  End Sub

#End Region

#Region " Privat - Carregar DADES "
  Public Function Validar() As Boolean

    ErroresProvider.SetError(txtidArticulo, "")

    If Trim(Me.txtidArticulo.Text) = "" Or Not IsNumeric(Me.txtidArticulo.Text) Or _
        Me.txtidArticulo.Text = 0 Then
      ErroresProvider.SetError(txtidArticulo, "Formato incorrecto! ")
      Return False
    End If

    Me.txtidArticulo.Text = mdlUtilitats.formatejaAmbZeros(Trim(Me.txtidArticulo.Text), 4)
    '
    ' Comprobamos que no se duplique la Primary Key 
    '
    Dim rowEmpAux As tblArticlesFinalsRow
    rowEmpAux = Aplicacion.Conexion.tblArticlesFinals.GetByPrimaryKey(Aplicacion.CodigoEmpresa, Me.txtidArticulo.Text)
    If Not rowEmpAux Is Nothing Then
      ErroresProvider.SetError(txtidArticulo, " Este articulo ya existe ! ")
      rowEmpAux = Nothing
      Return False
    End If

    Return True

  End Function

  Public Overloads Function CargaEntidad(ByVal Id As String) As Boolean
    Dim ret As Boolean = False
    Try
      rowArticles = Aplicacion.Conexion.tblArticlesFinals.GetByPrimaryKey(Aplicacion.CodigoEmpresa, Id)
      If Not rowArticles Is Nothing Then ret = True
    Catch ex As Exception

    End Try

    Return ret
  End Function

  Public Overrides Function CargaPrimeraEntidad() As Boolean
    Dim ret As Boolean = False
    Try
      Dim dataTable As DataTable
      Dim Records As Int32
      Dim where As String = "codigoempresa = '" & Aplicacion.CodigoEmpresa & "'"

      dataTable = Aplicacion.Conexion.tblArticlesFinals.GetAsDataTable(where, "idArticle ASC", 0, 1, Records)

      If dataTable.Rows.Count > 0 Then
        rowArticles = Aplicacion.Conexion.tblArticlesFinals.GetByPrimaryKey(Aplicacion.CodigoEmpresa, dataTable.Rows(0)(1))
        If Not rowArticles Is Nothing Then ret = True
      End If
    Catch ex As Exception
    End Try
    Return ret
  End Function

  Public Overrides Function CargaAnteriorEntidad() As Boolean
    Dim ret As Boolean = False
    Try
      Dim dataTable As DataTable
      Dim Records As Int32
      Dim where As String
      where = "CodigoEmpresa = '" & Aplicacion.CodigoEmpresa & "' and idArticle < '" & rowArticles.IdArticle & "'"

      dataTable = Aplicacion.Conexion.tblArticlesFinals.GetAsDataTable(where, "idArticle DESC", 0, 1, Records)


      If dataTable.Rows.Count > 0 Then
        rowArticles = Aplicacion.Conexion.tblArticlesFinals.GetByPrimaryKey(Aplicacion.CodigoEmpresa, dataTable.Rows(0)(1))
        If Not rowArticles Is Nothing Then ret = True
      End If
    Catch ex As Exception
    End Try
    Return ret
  End Function

  Public Overrides Function CargaSiguienteEntidad() As Boolean
    Dim ret As Boolean = False
    Try
      Dim dataTable As DataTable
      Dim Records As Int32
      Dim where As String
      where = "CodigoEmpresa = '" & Aplicacion.CodigoEmpresa & "' and  idArticle > '" & Trim(rowArticles.IdArticle) & "'"

      dataTable = Aplicacion.Conexion.tblArticlesFinals.GetAsDataTable(where, "idArticle ASC", 0, 1, Records)
      If dataTable.Rows.Count > 0 Then
        rowArticles = Aplicacion.Conexion.tblArticlesFinals.GetByPrimaryKey(Aplicacion.CodigoEmpresa, dataTable.Rows(0)(1))
        If Not rowArticles Is Nothing Then ret = True
      End If
    Catch ex As Exception
    End Try
    Return ret
  End Function

  Public Overrides Function CargaUltimaEntidad() As Boolean
    Dim ret As Boolean = False
    Try
      Dim dataTable As DataTable
      Dim Records As Int32
      Dim where As String = "CodigoEmpresa = '" & Aplicacion.CodigoEmpresa & "'"

      dataTable = Aplicacion.Conexion.tblArticlesFinals.GetAsDataTable(where, "idArticle DESC", 0, 1, Records)
      If dataTable.Rows.Count > 0 Then
        rowArticles = Aplicacion.Conexion.tblArticlesFinals.GetByPrimaryKey(Aplicacion.CodigoEmpresa, dataTable.Rows(0)(1))
        If Not rowArticles Is Nothing Then ret = True
      End If
    Catch ex As Exception
    End Try
    Return ret
  End Function

  Public Overrides Function NuevaEntidad() As Boolean
    '
    'Si queremos una entidad nueva, cargamos valores por defecto.
    '
    If MsgBox("Desea crear un articulo nuevo ? ", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "AnaWin") = MsgBoxResult.No Then
      Return False
      Exit Function
    End If

    ValoresPorDefecto()
    Return EntidadAControles()


  End Function

  Public Overrides Function EliminarEntidad() As Boolean
    Dim ret As Boolean = False
    Try
      If MsgBox("Desea eliminar el articulo ? ", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "AnaWin") = MsgBoxResult.No Then
        Return False
        Exit Function
      End If
      ret = Aplicacion.Conexion.tblArticlesFinals.Delete("codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and idArticle = '" & rowArticles.IdArticle & "'")
    Catch ex As Exception
      MsgBox("No se ha podido eliminar el articulo seleccionado." & vbCrLf & ex.Message)
    End Try
    Return ret
  End Function

  Public Overrides Function GrabaEntidad() As Boolean
    Dim ret As Boolean = False
    Try
      ret = Aplicacion.Conexion.tblArticlesFinals.Update(rowArticles)
      Me.txtidArticulo.Text = rowArticles.IdArticle
    Catch ex As Exception
      MsgBox("No se ha podido grabar el articulo seleccionada." & vbCrLf & ex.Message)
    End Try
    Return ret
  End Function

  Public Overrides Function InsertaEntidad() As Boolean
    Dim ret As Boolean = False
    Try
      Aplicacion.Conexion.tblArticlesFinals.Insert(rowArticles)
      Me.txtidArticulo.Text = rowArticles.IdArticle
      ret = True
    Catch ex As Exception
      MsgBox("No se ha podido añadir el articulo seleccionada." & vbCrLf & ex.Message)
    End Try
    Return ret
  End Function

  Public Overrides Function CopiaEntidadOld() As Boolean
    Dim ret As Boolean = False
    If Not rowArticles Is Nothing Then
      Try

        If rowArticlesOld Is Nothing Then rowArticlesOld = New tblArticlesFinalsRow

        rowArticlesOld.CodigoEmpresa = rowArticles.CodigoEmpresa
        rowArticlesOld.IdArticle = rowArticles.IdArticle
        rowArticlesOld.Descripcio = rowArticles.Descripcio
        rowArticlesOld.TipoProducte = rowArticles.TipoProducte
        rowArticlesOld.IdColor = rowArticles.IdColor
        rowArticlesOld.Anada = rowArticles.Anada
        rowArticlesOld.Grados = rowArticles.Grados
        rowArticlesOld.IdDo = rowArticles.IdDo
        rowArticlesOld.RecipientSortida = rowArticles.RecipientSortida
        rowArticlesOld.ArticleFactusol = rowArticles.ArticleFactusol


        ret = True
      Catch ex As Exception
        MsgBox("No se ha podido actualizar los datos." & vbCrLf & ex.Message)
      End Try
    End If
    Return ret
  End Function

  Public Overrides Function RecuperaEntidadOld() As Boolean
    Dim ret As Boolean = False

    If Not rowArticlesOld Is Nothing Then

      Try

        If rowArticles Is Nothing Then rowArticles = New tblArticlesFinalsRow

        rowArticles.CodigoEmpresa = rowArticlesOld.CodigoEmpresa
        rowArticles.IdArticle = rowArticlesOld.IdArticle
        rowArticles.Descripcio = rowArticlesOld.Descripcio
        rowArticles.TipoProducte = rowArticlesOld.TipoProducte
        rowArticles.IdColor = rowArticlesOld.IdColor
        rowArticles.Anada = rowArticlesOld.Anada
        rowArticles.Grados = rowArticlesOld.Grados
        rowArticles.IdDo = rowArticlesOld.IdDo
        rowArticles.RecipientSortida = rowArticlesOld.RecipientSortida
        rowArticles.ArticleFactusol = rowArticlesOld.ArticleFactusol

        ret = True

      Catch ex As Exception
        MsgBox("No se han podido restaurar los datos anteriores. " & vbCrLf & ex.Message)
      End Try

    End If

    Return ret
  End Function

  Public Overloads Function ValoresPorDefecto() As Boolean
    Dim ret As Boolean = False
    Try

      ' Valores por defecto de la entidad.
      If rowArticles Is Nothing Then
        rowArticles = New tblArticlesFinalsRow
      End If

      rowArticles.CodigoEmpresa = Aplicacion.CodigoEmpresa
      rowArticles.IdArticle = mdlManteniments.obtenidArticleNuevo
      rowArticles.Descripcio = ""
      rowArticles.TipoProducte = 0
      rowArticles.IdColor = 1
      rowArticles.Anada = Format(Now, "yyyy")
      rowArticles.Grados = 0
      rowArticles.IdDo = 1
      rowArticles.RecipientSortida = 1
      rowArticles.ArticleFactusol = ""

      ret = True
    Catch ex As Exception
      MsgBox("No se han podido cargar los datos por defecto." & vbCrLf & ex.Message, MsgBoxStyle.Information, "AnaWin")
    End Try
    Return ret
  End Function

  Private Sub resetejarCamps()

    ' Valors per defecte dels camps

    Me.txtNombre.Text = ""
    Me.cmbTipoProducte.Text = ""
    Me.cmbColor.Text = ""
    Me.cmbDO.Text = ""
    Me.txtAñada.Text = Format(Now, "yyyy")
    Me.txtGraus.Text = 0
    Me.cmbRecipientes.Text = ""
    Me.txtArticleFactusol.Text = ""
    Me.TextEdit1.Text = ""

  End Sub

  Public Overrides Function EntidadAControles() As Boolean
    Dim ret As Boolean = False
    Dim valorNull As Boolean = False

    Try

      If Not rowArticles Is Nothing Then

        resetejarCamps()

        Me.txtidArticulo.Text = rowArticles.IdArticle
        If Not rowArticles.Descripcio Is Nothing Then
          Me.txtNombre.Text = rowArticles.Descripcio.Replace("'", "´")
        Else
          Me.txtNombre.Text = " "
        End If
        Me.cmbTipoProducte.Text = mdlManteniments.obtenirDescrTipoProducte(rowArticles.TipoProducte)
        'Me.txtDescripcionTipo.Text = mdlManteniments.obtenirDescrTipoProducte(rowArticles.TipoProducte)
        Me.cmbColor.Text = mdlManteniments.obtenirColorRaim(rowArticles.IdColor)
        Me.txtAñada.Value = rowArticles.Anada
        Me.txtGraus.Value = rowArticles.Grados
        Me.cmbDO.Text = mdlManteniments.obtenirDoRaim(rowArticles.IdDo)
        Me.cmbRecipientes.Text = mdlManteniments.obtenirDescripcioTina(rowArticles.RecipientSortida)
        Me.txtArticleFactusol.Text = rowArticles.ArticleFactusol
        If Me.txtArticleFactusol.Text.Trim <> "" Then
          Me.TextEdit1.Text = mdlFactusol.obtenirNomProducte(rowArticles.ArticleFactusol)
        End If
        ret = True

      End If
    Catch ex As Exception
      MsgBox("No se han podido cargar los datos de los clientes." & vbCrLf & ex.Message, MsgBoxStyle.Information, "PcsnetGrup-AnaWin")
    End Try
    Return ret
  End Function

  Public Overrides Function ControlesAEntidad() As Boolean
    Dim ret As Boolean = False
    Try

      'Codi Treballador
      If Not rowArticles Is Nothing Then

        rowArticles.IdArticle = Trim(Me.txtidArticulo.Text)
        rowArticles.CodigoEmpresa = Aplicacion.CodigoEmpresa
        rowArticles.Anada = Me.txtAñada.Text
        rowArticles.ArticleFactusol = Me.txtArticleFactusol.Text
        rowArticles.Descripcio = Me.txtNombre.Text.Trim
        rowArticles.Grados = Me.txtGraus.Value
        rowArticles.IdColor = mdlManteniments.obtenirCodiColorRaim(Me.cmbColor.Text)
        rowArticles.IdDo = mdlManteniments.obtenirCodiDo(Me.cmbDO.Text.Trim)
        rowArticles.RecipientSortida = mdlTinas.obteniridRecipientXNom(Me.cmbRecipientes.Text)
        rowArticles.TipoProducte = mdlManteniments.obtenirCodiTipoProducte(Me.cmbTipoProducte.Text)

        ret = True

      End If

    Catch ex As Exception
      MsgBox("Error al cargar los datos de los Articulos." & vbCrLf & ex.Message, MsgBoxStyle.Information, "AnaWin")
    End Try
    Return ret

  End Function

  Public Overrides Function ValidaCuerpo() As Boolean
    Dim ret As Boolean = True

    If Me.cmbColor.Text = "0" Or Me.cmbColor.Text = "" Then
      ErroresProvider.SetError(cmbColor, "Format incorrecte!")
      ret = False
      Exit Function
    Else
      ErroresProvider.SetError(cmbColor, "")
      ret = True
    End If

    If Me.cmbRecipientes.Text = "0" Or Me.cmbRecipientes.Text = "" Then
      ErroresProvider.SetError(cmbRecipientes, "Format incorrecte!")
      ret = False
      Exit Function
    Else
      ErroresProvider.SetError(cmbRecipientes, "")
      ret = True
    End If

    If Me.txtArticleFactusol.Text = "0" Or Me.txtArticleFactusol.Text = "" Then
      ErroresProvider.SetError(txtArticleFactusol, "Format incorrecte!")
      ret = False
      Exit Function
    Else
      ErroresProvider.SetError(txtArticleFactusol, "")
      ret = True
    End If

    If Me.cmbTipoProducte.Text = "0" Or Me.cmbTipoProducte.Text = "" Then
      ErroresProvider.SetError(cmbTipoProducte, "Format incorrecte!")
      ret = False
      Exit Function
    Else
      ErroresProvider.SetError(cmbTipoProducte, "")
      ret = True
    End If

    If Me.txtAñada.Text = "0" Or Me.txtAñada.Text = "" Then
      ErroresProvider.SetError(txtAñada, "Format incorrecte!")
      ret = False
      Exit Function
    Else
      ErroresProvider.SetError(txtAñada, "")
      ret = True
    End If

    If Me.txtGraus.Text = "0,00" Or Me.txtGraus.Text = "" Then
      ErroresProvider.SetError(txtGraus, "Format incorrecte!")
      ret = False
      Exit Function
    Else
      ErroresProvider.SetError(txtGraus, "")
      ret = True
    End If

    Return ret

  End Function

  Public Overrides Sub Salir()

    Me.Close()

  End Sub

#End Region

#Region " Privat ; VALIDACIO dels CAMPS "

  Public Overrides Sub LimpiaErroresProvider()
    ErroresProvider.SetError(txtidArticulo, "")
    ErroresProvider.SetError(txtAñada, "")
    ErroresProvider.SetError(txtArticleFactusol, "")
    ErroresProvider.SetError(txtGraus, "")
    ErroresProvider.SetError(cmbColor, "")
    ErroresProvider.SetError(cmbDO, "")
    ErroresProvider.SetError(cmbRecipientes, "")
    ErroresProvider.SetError(cmbTipoProducte, "")
  End Sub

#End Region

#Region " Events Formulari "

  Private Sub txtArticulo_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
    BuscaArticles()
  End Sub

  Private Sub frmArticulos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    If Not veDeMant Then
      Me.Location = New Point(0, 0)
    End If
  End Sub

  Private Sub frmArticulos_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move
    If Not veDeMant Then
      Me.Location = New Point(0, 0)
    End If
  End Sub

  Private Sub frmPersonass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
      e.Handled = True
      SendKeys.Send(vbTab)
    End If

    If e.KeyCode = Keys.Up Then
      e.Handled = True
      SendKeys.Send("+{TAB}")
    End If
  End Sub
#End Region

#Region " Funcions de Cerca "
  Public Sub BuscaArticlesFacturacio()
    'If Aplicacion.ControlStock = 1 Then
    Dim frmLookUp As New Bases.frmLookUp
    Dim drEntidad As DataRow
    Dim dtEntidades As DataTable
    Dim i As Integer
    With frmLookUp
      dtEntidades = GetDataTableArticulosFactusol()
      .Grid.DataSource = dtEntidades
      With .GridView
        .Columns.Clear()
        For i = 0 To dtEntidades.Columns.Count - 1
          .Columns.Add(dtEntidades.Columns(i).ColumnName)
          .Columns(i).Caption = dtEntidades.Columns(i).Caption
          .Columns(i).VisibleIndex = i
        Next
        'For i = 2 To dtEntidades.Columns.Count - 1
        '    .Columns(i).VisibleIndex = -1
        'Next
      End With
      .Text = "Mestre d'Articles."
      .Aceptar.Text = "Acceptar ??"
      If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        drEntidad = .DatarowSelected
        Try

          Me.txtArticleFactusol.Text = ""
          Me.TextEdit1.Text = ""

          Me.txtArticleFactusol.Text = drEntidad.Item(0)
          Me.TextEdit1.Text = drEntidad.Item(1)

        Catch ex As Exception
        End Try
      End If
    End With
    frmLookUp.Dispose()
    ' End If
  End Sub
  Private Function GetDataTableArticulosFactusol() As DataTable
    Dim dtEntidades As DataTable
    Dim cad As String = ""
    Dim command As New OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader


    If Not Aplicacion.mConnFactusol.State = ConnectionState.Closed Then
      Aplicacion.mConnFactusol.Close()
      Aplicacion.mConnFactusol.Open()
    End If



    cad = "SELECT CODART, DESART, CP1ART, CP2ART, CP3ART"
    cad = cad & " FROM F_ART "
    cad = cad & " WHERE COMART = 1;"

    command = New OleDb.OleDbCommand
    command.Connection = Aplicacion.mConnFactusol
    command.CommandText = cad
    dr = command.ExecuteReader

    If dr Is Nothing Then
      MsgBox("Error al buscar els productes d'estoc!", MsgBoxStyle.Information, "AnaWin")
      Exit Function
    Else
      crearRsManArticles()
      dtEntidades = omplirDtArticlesFactusol(dr)
      dr.Close()
      command.Dispose()
      Return dtEntidades
      'mConn.Close()
    End If
  End Function
  Private Sub crearRsManArticles()
    If Not dtArt Is Nothing Then dtArt = Nothing
    dtArt = New DataTable
    Dim dtDataColumn As DataColumn
    '
    dtDataColumn = New DataColumn
    dtDataColumn.DataType() = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 15
    dtDataColumn.ColumnName = "Codigo"
    dtArt.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType() = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 150
    dtDataColumn.ColumnName = "Descripcion"
    dtArt.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType() = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 150
    dtDataColumn.ColumnName = "DO"
    dtArt.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType() = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 150
    dtDataColumn.ColumnName = "Color"
    dtArt.Columns.Add(dtDataColumn)



  End Sub
  Private Function omplirDtArticlesFactusol(ByVal dataR As OleDb.OleDbDataReader) As DataTable
    Dim dtReg As DataRow


    If Not dataR Is Nothing Then
      While dataR.Read
        dtReg = dtArt.NewRow
        dtReg("Codigo") = dataR("CODART")
        dtReg("Descripcion") = dataR("DESART")
        dtReg("DO") = dataR("CP1ART")
        dtReg("Color") = dataR("CP3ART")
        dtArt.Rows.Add(dtReg)
      End While
    End If

    dataR.Close()
    omplirDtArticlesFactusol = dtArt

  End Function
  Private Sub BuscaArticles()
    Dim frmLookUp As New Bases.frmLookUp
    Dim cad As String
    Dim drEntidad As DataRow
    Dim dtEntidades As DataTable
    Dim dtRs As DataTable
    Dim i As Integer

    cad = "SELECT idArticle, Descripcio FROM tblArticlesFinals "

    dtRs = Aplicacion.Conexion.ExecuteSQL2DT(cad)

    dtEntidades = New DataTable
    Dim dtDataColumn As DataColumn

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 4
    dtDataColumn.ColumnName = "idArticle"
    dtEntidades.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType() = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 50
    dtDataColumn.ColumnName = "Nombre"
    dtEntidades.Columns.Add(dtDataColumn)

    For i = 0 To dtRs.Rows.Count - 1
      Dim row As DataRow = dtEntidades.NewRow

      row("idArticle") = Trim(dtRs.Rows.Item(i)("idArticle"))
      row("Nombre") = Trim(dtRs.Rows.Item(i)("Descripcio"))

      dtEntidades.Rows.Add(row)
    Next

    'Me.Hide()

    With frmLookUp
      .Grid.DataSource = dtEntidades
      With .GridView
        .Columns.Clear()
        For i = 0 To dtEntidades.Columns.Count - 1
          .Columns.Add(dtEntidades.Columns(i).ColumnName)
          .Columns(i).Caption = dtEntidades.Columns(i).Caption
          .Columns(i).VisibleIndex = i
          .Columns(i).Options = ColumnOptions.CanFocused Or ColumnOptions.CanSorted Or ColumnOptions.ReadOnly 'Or ColumnOptions.CanFiltered
        Next
        'For i = 2 To dtEntidades.Columns.Count - 1
        '    .Columns(i).VisibleIndex = -1
        'Next
      End With
      .Text = "Mestre d' Articles"
      .Aceptar.Text = "Acceptar ?"

      If .ShowDialog() = DialogResult.OK Then
        drEntidad = .DatarowSelected
        Try
          Me.txtidArticulo.Text = drEntidad.Item(0)
          Me.txtNombre.Text = Trim(CType(drEntidad.Item(1), String))
          CopiaEntidadOld()
          If CargaEntidad(drEntidad.Item(0)) Then
            ' Cargamos los datos
            If Not EntidadAControles() Then
              RecuperaEntidadOld()
            End If
          Else
            RecuperaEntidadOld()
          End If
          'Actualizamos la visualizacion de los controles
          If Me.btmBotoneraMantenimiento.EstadoAnterior = BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Edicion Or _
                    Me.btmBotoneraMantenimiento.EstadoAnterior = BotoneraMantenimiento.enumBotoneraMantenimientoEstado.Nuevo Then


            bloquejarControls(Me, True)

          End If
        Catch ex As Exception

        End Try
      End If
    End With

    frmLookUp.Dispose()
    Me.Show()
  End Sub

  Public Overrides Sub BuscaEntidad()
    BuscaArticles()
  End Sub
#End Region

  Private Sub frmArticulos_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    If Not veDeMant Then
      Me.Location = New Point(0, 0)
    End If
  End Sub

  Private Sub txtidArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtidArticulo.ButtonClick
    BuscaArticles()
  End Sub

  Private Sub txtidArticulo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtidArticulo.EditValueChanged
    If Me.txtidArticulo.Text.Trim <> "" Then
      Me.txtidArticulo.Text = mdlUtilitats.formatejaAmbZeros(Me.txtidArticulo.Text, 4)
    End If
  End Sub

  Private Sub txtArticleFactusol_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtArticleFactusol.ButtonClick
    BuscaArticlesFacturacio()
  End Sub
  Private Sub iniciaCmbDO()
    Dim dt As New DataTable
    Dim cad As String = ""

    cad = "Select * From tblDO"
    dt = Aplicacion.Conexion.tblDOCollection.GetAsDataTable("", "")

    If Not dt Is Nothing Then
      For i As Int32 = 0 To dt.Rows.Count - 1
        cad = Trim(CType(dt.Rows.Item(i)("DenomOrigen"), String))
        Me.cmbDO.Properties.Items.Add(cad)
      Next
    End If

  End Sub
  Private Sub iniciaCmbColor()

    Dim dt As New DataTable
    Dim cad As String = ""

    cad = "Select * From tblColorProducto"
    dt = Aplicacion.Conexion.tblColorProductoCollection.GetAsDataTable("", "")

    If Not dt Is Nothing Then
      For i As Int32 = 0 To dt.Rows.Count - 1
        cad = Trim(CType(dt.Rows.Item(i)("Color"), String))
        Me.cmbColor.Properties.Items.Add(cad)
      Next
    End If

  End Sub
  Private Sub iniciaCmbTipoProducto()
    Dim dt As New DataTable
    Dim cad As String = ""

    cad = "Select * From tblTipoProducto "
    dt = Aplicacion.Conexion.tblTipoProducto.GetAsDataTable("", "")

    If Not dt Is Nothing Then
      For i As Int32 = 0 To dt.Rows.Count - 1
        cad = Trim(dt.Rows.Item(i)("Descripcion"))
        Me.cmbTipoProducte.Properties.Items.Add(cad)
      Next
    End If

  End Sub
  Private Sub iniciaCmbRecipients()
    Dim dt As New DataTable
    Dim cad As String = ""

    cad = "Select * From tblRecipientes Where codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and TipoRecipient = 6"
    dt = Aplicacion.Conexion.ExecuteSQL2DT(cad)

    If Not dt Is Nothing Then
      For i As Int32 = 0 To dt.Rows.Count - 1
        cad = Trim(CType(dt.Rows.Item(i)("DescripcionCorta"), String))
        Me.cmbRecipientes.Items.Add(cad)
      Next
    End If

  End Sub
  Public Overrides Function ValidaEntidad() As Boolean
    Dim ret As Boolean = False
    ret = ValidaCuerpo()
    Return ret
  End Function
End Class
