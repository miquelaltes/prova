Imports PcsNet.AnaWin.Db
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls

Public Class frmCertificarPreEmbotellats
  Private idSal As Int32
  Private LtrRec As Decimal = 0
  Private LitresTotals As Int32 = 0
  Dim rowSal As New tblSalidaProductoRow

  Private Sub frmCertificarPreEmbotellats_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
      e.Handled = True
      SendKeys.Send(vbTab)
    End If

    If e.KeyCode = Keys.Up Then
      e.Handled = True
      SendKeys.Send("+{TAB}")
    End If
  End Sub

  Private Sub frmCertificarPreEmbotellats_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    inicia()
  End Sub

  Private Sub inicia()

    'Dim LtrRec As Decimal = 0
    Try

      Me.txtFechaCert.DateTime = Now
      rowSal = Aplicacion.Conexion.tblSalidaProductoCollection.GetByPrimaryKey(Aplicacion.CodigoEmpresa, idSal)

      If Not rowSal Is Nothing Then
        Me.lblProducte.Text = rowSal.IdProducto & "-" & mdlProductes.obtenirNomProducte(rowSal.IdProducto)
        Me.txtLitres.Text = rowSal.Litros
        LitresTotals = rowSal.Litros
        Me.txtLots.Text = rowSal.Cantidad
        ''
        LtrRec = rowSal.Litros / rowSal.Cantidad
        ''
      End If

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    
    Try


      'validacio de camps
      If Me.txtCertificacio.Text.Trim = "" Then
        Me.ErrorProvider1.SetError(txtCertificacio, "Valor incorrecte!")
        Exit Sub
      ElseIf mdlProductes.existeixCertificacio(Me.txtCertificacio.Text.Trim) Then
        Me.ErrorProvider1.SetError(txtCertificacio, "La certificació ja existeix a la base de dades!")
        Exit Sub
      Else
        Me.ErrorProvider1.SetError(txtCertificacio, "")
      End If

      If Me.txtLitres.Text.Trim = "" Or CInt(Me.txtLitres.Text) = 0 Then
        Me.ErrorProvider1.SetError(txtLitres, "Valor incorrecte!")
        Exit Sub
      Else
        Me.ErrorProvider1.SetError(txtLitres, "")
      End If

      crearCanviLlibres()
      modificacioLiniaPreEmbasat()
      registraPreEmbotellatCert()


      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Dispose(True)

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Private Sub modificacioLiniaPreEmbasat()

    Try

      rowSal.Litros = rowSal.Litros - CDec(Me.txtLitres.Text)
      rowSal.Cantidad = rowSal.Cantidad - CInt(Me.txtLots.Text)

      Aplicacion.Conexion.tblSalidaProductoCollection.Update(rowSal)

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try

  End Sub

  Private Sub registraPreEmbotellatCert()
    Dim row As New tblSalidaProductoRow
    Try


      row.Cantidad = CInt(Me.txtLots.Text)
      row.Fecha = Format(Me.txtFechaCert.DateTime, "dd/MM/yyyy")
      row.IdCliente = ""
      row.IdProducto = rowSal.IdProducto
      row.IdSalida = mdlManteniments.obtenirSortida
      row.Lote = ""
      row.TipoSalida = "EMBOTELLADORA"
      row.Litros = CInt(Me.txtLitres.Text)
      row.NumeroGuia = "" & Me.txtCertificacio.Text.Trim
      row.CantidadCorchos = 0
      row.CantidadEtiquetas = 0
      row.CantidadContraEti = 0
      row.DescCorchos = ""
      row.DescEtiquetas = ""
      row.DescContraEti = ""
      row.Observaciones = ""
      row.CantidadEnvase = 0
      row.DescEnvase = ""
      row.RecipienteSalida = rowSal.RecipienteSalida
      row.IdContraEtiqueta = 0
      row.IdCorcho = 0
      row.IdEnvase = 0
      row.IdEtiqueta = 0
      row.IdRecipiente = rowSal.IdRecipiente
      row.IdCapsula = 0
      row.DescCapsula = ""
      row.CantidadCapsula = 0
      row.IdTapon = 0
      row.DescTapon = ""
      row.CantidadTapon = 0
      row.DescRecipientes = ""
      row.CantidadRecipiente = 0
      row.AlmacenDestino = 0
      row.NumeroApunte = 0
      row.IdArticuloFinal = ""
      row.DescArticuloFinal = ""
      row.CantidadArticuloFinal = 0
      row.PreEmbotellat = True
      row.IdPreEmbotellat = 0
      row.IdCertificacion = Me.txtCertificacio.Text.Trim
      row.CodigoEmpresa = Aplicacion.CodigoEmpresa

      Aplicacion.Conexion.tblSalidaProductoCollection.Insert(row)

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try

  End Sub

  Private Sub crearCanviLlibres()
    Dim dt As New DataTable
    Dim cad As String = ""
    Dim idRef As Int32 = 0
    'Dim pLitros As Int32 = 0
    Dim Descripcio As String = ""
    Dim NomProducte As String = ""
    Try


      '************AGAFEM UNA NOVA REF PER AL PRODUCTE
      idRef = mdlRegistreLlibres.obtenirNovaRef()
      '************************************************

      Dim idPro As Int32 = 0
      Dim idRec As Int32 = 0
      Dim anada As Int32 = 0
      Dim iddoIni As Int32 = 0
      Dim idColor As Int32 = 0
      Dim idTipus As Int32 = 0
      Dim idManipulacio As Int32 = 0

      idPro = rowSal.IdProducto
      idRec = rowSal.RecipienteSalida
      anada = mdlProductes.obtenirAnoEntrada(idPro)
      iddoIni = mdlProductes.obtenirDo(idPro)
      idColor = mdlProductes.obtenirColor(idPro)
      idTipus = mdlProductes.obtenirTipoProducto(idPro)
      idManipulacio = mdlProductes.obtenirManipulacio(idPro)
      NomProducte = mdlManteniments.obtenirDescrSubProducte(mdlProductes.obtenirSubProducte(idRec)) & " " & mdlProductes.obtenirVarietatProducte(idPro) & " " & anada

      If CInt(Me.txtLitres.Text) > 0 Then

        Descripcio = "Qualificació de pre embasats."

        mdlRegistreLlibres.nouRegistre(idPro, idRec, anada, CInt(Me.txtLitres.Text), _
                                    2, Me.txtFechaCert.DateTime, iddoIni, idColor, "", _
                                    "S", Descripcio, 0, idRef, "REF_" & idRef, "", 0, 0, "", "", 0, True, "", "S", idTipus, idManipulacio, NomProducte, 0, 0, 0)




        mdlRegistreLlibres.nouRegistre(idPro, idRec, anada, CInt(Me.txtLitres.Text), _
                                   2, Me.txtFechaCert.DateTime, iddoIni, idColor, Me.txtCertificacio.Text.Trim, _
                                "E", Descripcio, 0, idRef, "REF_" & idRef, "", 0, 0, "", "", 0, True, "", "E", idTipus, idManipulacio, NomProducte, 0, 0, 0)

      End If






    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Private Sub calculaLots(ByVal str As String)
    Try

      If LtrRec > 0 Then
        If str = "LtrLots" Then
          Me.txtLots.Text = CDec(Me.txtLitres.Text) / LtrRec
        End If
        If str = "NumLots" Then
          Me.txtLitres.Text = CDec(Me.txtLots.Text) * LtrRec
        End If
      End If

      If CInt(Me.txtLitres.Text) > LitresTotals Then
        MsgBox("Error: Exedit els litres màxims.", MsgBoxStyle.Information, "AnaWin")
        Me.txtLitres.Text = LitresTotals
        Me.txtLots.Text = CDec(Me.txtLitres.Text) / LtrRec
      End If

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
    Me.Dispose(True)
  End Sub

  Private Sub txtLitres_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLitres.Validated
    calculaLots("LtrLots")
  End Sub

  Private Sub txtLots_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLots.Validated
    calculaLots("NumLots")
  End Sub

  Private Sub txtCertificacio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCertificacio.TextChanged

  End Sub

  Private Sub txtCertificacio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCertificacio.Validated
    Me.txtCertificacio.Text = UCase(Me.txtCertificacio.Text)
  End Sub

  Private Sub txtFechaCert_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaCert.EditValueChanged

  End Sub

  Private Sub txtFechaCert_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFechaCert.Validating
    Try

      If Format(Me.txtFechaCert.DateTime, "dd/MM/yyyy") < Format(rowSal.Fecha, "dd/MM/yyyy") Then
        MsgBox("La data introduïda és inferior a la de l'últim moviment!", MsgBoxStyle.Exclamation, "AnaWin")
        Me.txtFechaCert.DateTime = rowSal.Fecha.AddDays(1)
        e.Cancel = True
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
End Class