<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChart
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChart))
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.chkSucRedu = New System.Windows.Forms.CheckBox
    Me.chkInteCol = New System.Windows.Forms.CheckBox
    Me.chkSoLliure = New System.Windows.Forms.CheckBox
    Me.chkSoTotal = New System.Windows.Forms.CheckBox
    Me.chkAciVol = New System.Windows.Forms.CheckBox
    Me.chkAciTotal = New System.Windows.Forms.CheckBox
    Me.chkGrau = New System.Windows.Forms.CheckBox
    Me.chkTemperatura = New System.Windows.Forms.CheckBox
    Me.chkDensitat = New System.Windows.Forms.CheckBox
    Me.chart = New ZedGraph.ZedGraphControl
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnCancelar
    '
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.ImageIndex = 1
    Me.btnCancelar.ImageList = Me.ImageList1
    Me.btnCancelar.Location = New System.Drawing.Point(939, 464)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(161, 30)
    Me.btnCancelar.TabIndex = 1
    Me.btnCancelar.Text = "&Sortir"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "edit_add.png")
    Me.ImageList1.Images.SetKeyName(1, "apply.png")
    Me.ImageList1.Images.SetKeyName(2, "button_cancel.png")
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.chkSucRedu)
    Me.GroupBox1.Controls.Add(Me.chkInteCol)
    Me.GroupBox1.Controls.Add(Me.chkSoLliure)
    Me.GroupBox1.Controls.Add(Me.chkSoTotal)
    Me.GroupBox1.Controls.Add(Me.chkAciVol)
    Me.GroupBox1.Controls.Add(Me.chkAciTotal)
    Me.GroupBox1.Controls.Add(Me.chkGrau)
    Me.GroupBox1.Controls.Add(Me.chkTemperatura)
    Me.GroupBox1.Controls.Add(Me.chkDensitat)
    Me.GroupBox1.Location = New System.Drawing.Point(4, 5)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(1096, 50)
    Me.GroupBox1.TabIndex = 2
    Me.GroupBox1.TabStop = False
    '
    'chkSucRedu
    '
    Me.chkSucRedu.AutoSize = True
    Me.chkSucRedu.ForeColor = System.Drawing.Color.SaddleBrown
    Me.chkSucRedu.Location = New System.Drawing.Point(983, 20)
    Me.chkSucRedu.Name = "chkSucRedu"
    Me.chkSucRedu.Size = New System.Drawing.Size(96, 18)
    Me.chkSucRedu.TabIndex = 17
    Me.chkSucRedu.Text = "Suc. Redu."
    Me.chkSucRedu.UseVisualStyleBackColor = True
    '
    'chkInteCol
    '
    Me.chkInteCol.AutoSize = True
    Me.chkInteCol.ForeColor = System.Drawing.Color.Gold
    Me.chkInteCol.Location = New System.Drawing.Point(859, 20)
    Me.chkInteCol.Name = "chkInteCol"
    Me.chkInteCol.Size = New System.Drawing.Size(103, 18)
    Me.chkInteCol.TabIndex = 16
    Me.chkInteCol.Text = "Inten. Col."
    Me.chkInteCol.UseVisualStyleBackColor = True
    '
    'chkSoLliure
    '
    Me.chkSoLliure.AutoSize = True
    Me.chkSoLliure.ForeColor = System.Drawing.Color.DarkViolet
    Me.chkSoLliure.Location = New System.Drawing.Point(723, 20)
    Me.chkSoLliure.Name = "chkSoLliure"
    Me.chkSoLliure.Size = New System.Drawing.Size(96, 18)
    Me.chkSoLliure.TabIndex = 15
    Me.chkSoLliure.Text = "SO2 Lliure"
    Me.chkSoLliure.UseVisualStyleBackColor = True
    '
    'chkSoTotal
    '
    Me.chkSoTotal.AutoSize = True
    Me.chkSoTotal.ForeColor = System.Drawing.Color.Blue
    Me.chkSoTotal.Location = New System.Drawing.Point(589, 20)
    Me.chkSoTotal.Name = "chkSoTotal"
    Me.chkSoTotal.Size = New System.Drawing.Size(89, 18)
    Me.chkSoTotal.TabIndex = 14
    Me.chkSoTotal.Text = "SO2 Total"
    Me.chkSoTotal.UseVisualStyleBackColor = True
    '
    'chkAciVol
    '
    Me.chkAciVol.AutoSize = True
    Me.chkAciVol.ForeColor = System.Drawing.Color.DodgerBlue
    Me.chkAciVol.Location = New System.Drawing.Point(476, 20)
    Me.chkAciVol.Name = "chkAciVol"
    Me.chkAciVol.Size = New System.Drawing.Size(82, 18)
    Me.chkAciVol.TabIndex = 13
    Me.chkAciVol.Text = "Aci. Vol"
    Me.chkAciVol.UseVisualStyleBackColor = True
    '
    'chkAciTotal
    '
    Me.chkAciTotal.AutoSize = True
    Me.chkAciTotal.ForeColor = System.Drawing.Color.Turquoise
    Me.chkAciTotal.Location = New System.Drawing.Point(338, 20)
    Me.chkAciTotal.Name = "chkAciTotal"
    Me.chkAciTotal.Size = New System.Drawing.Size(96, 18)
    Me.chkAciTotal.TabIndex = 12
    Me.chkAciTotal.Text = "Aci. Total"
    Me.chkAciTotal.UseVisualStyleBackColor = True
    '
    'chkGrau
    '
    Me.chkGrau.AutoSize = True
    Me.chkGrau.ForeColor = System.Drawing.Color.Green
    Me.chkGrau.Location = New System.Drawing.Point(254, 20)
    Me.chkGrau.Name = "chkGrau"
    Me.chkGrau.Size = New System.Drawing.Size(54, 18)
    Me.chkGrau.TabIndex = 11
    Me.chkGrau.Text = "Grau"
    Me.chkGrau.UseVisualStyleBackColor = True
    '
    'chkTemperatura
    '
    Me.chkTemperatura.AutoSize = True
    Me.chkTemperatura.ForeColor = System.Drawing.Color.Orange
    Me.chkTemperatura.Location = New System.Drawing.Point(131, 20)
    Me.chkTemperatura.Name = "chkTemperatura"
    Me.chkTemperatura.Size = New System.Drawing.Size(103, 18)
    Me.chkTemperatura.TabIndex = 10
    Me.chkTemperatura.Text = "Temperatura"
    Me.chkTemperatura.UseVisualStyleBackColor = True
    '
    'chkDensitat
    '
    Me.chkDensitat.AutoSize = True
    Me.chkDensitat.ForeColor = System.Drawing.Color.Red
    Me.chkDensitat.Location = New System.Drawing.Point(17, 20)
    Me.chkDensitat.Name = "chkDensitat"
    Me.chkDensitat.Size = New System.Drawing.Size(82, 18)
    Me.chkDensitat.TabIndex = 9
    Me.chkDensitat.Text = "Densitat"
    Me.chkDensitat.UseVisualStyleBackColor = True
    '
    'chart
    '
    Me.chart.Location = New System.Drawing.Point(4, 61)
    Me.chart.Name = "chart"
    Me.chart.ScrollGrace = 0
    Me.chart.ScrollMaxX = 0
    Me.chart.ScrollMaxY = 0
    Me.chart.ScrollMaxY2 = 0
    Me.chart.ScrollMinX = 0
    Me.chart.ScrollMinY = 0
    Me.chart.ScrollMinY2 = 0
    Me.chart.Size = New System.Drawing.Size(1096, 397)
    Me.chart.TabIndex = 3
    '
    'frmChart
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1112, 502)
    Me.Controls.Add(Me.chart)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnCancelar)
    Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmChart"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCancelar As System.Windows.Forms.Button

  Public Sub New()

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

  End Sub
  Friend WithEvents chkSucRedu As System.Windows.Forms.CheckBox
  Friend WithEvents chkInteCol As System.Windows.Forms.CheckBox
  Friend WithEvents chkSoLliure As System.Windows.Forms.CheckBox
  Friend WithEvents chkSoTotal As System.Windows.Forms.CheckBox
  Friend WithEvents chkAciVol As System.Windows.Forms.CheckBox
  Friend WithEvents chkAciTotal As System.Windows.Forms.CheckBox
  Friend WithEvents chkGrau As System.Windows.Forms.CheckBox
  Friend WithEvents chkTemperatura As System.Windows.Forms.CheckBox
  Friend WithEvents chkDensitat As System.Windows.Forms.CheckBox
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents chart As ZedGraph.ZedGraphControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Public Sub New(ByVal pTina As Int32, ByVal pProducto As Int32)

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    idtina = pTina
    idProducte = pProducto

    inicia()
  End Sub
End Class
