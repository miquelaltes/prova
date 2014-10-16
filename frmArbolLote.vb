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
Imports PrintControl

Public Class frmArbolLote
  Private dtUnitats As New DataTable
  Private destino As Int32
  Private prdestino As Int32
  Private productelot As String = ""
  Private idSalidaBodega As Int32
  Private recipientOrigen As String = ""
  Private dataLot As Date
  Private ltrlot As Decimal
  Private dtAlbarans As DataTable

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim dt As New DataTable
    Dim cad As String = ""
    crearRsman()
    dt = GetDataTable()
  End Sub
  Private Sub inicia()
    Dim dt As New DataTable
    Dim cad As String = ""
    crearRsman()
    dt = GetDataTable()
  End Sub

  Private Sub crearRsman()

    If Not dtAlbarans Is Nothing Then
      dtAlbarans.Dispose()
    End If
    If Not dtUnitats Is Nothing Then
      dtUnitats.Dispose()
    End If
    dtAlbarans = New DataTable
    dtUnitats = New DataTable


    Dim dtDataColumn As DataColumn

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 25
    dtDataColumn.ColumnName = "NumeroAlbara"
    dtAlbarans.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.DateTime")
    dtDataColumn.ColumnName = "FechaAlbaran"
    dtAlbarans.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 250
    dtDataColumn.ColumnName = "NombreProveeodr"
    dtAlbarans.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Int32")
    dtDataColumn.ColumnName = "Carga"
    dtAlbarans.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Decimal")
    dtDataColumn.ColumnName = "ph"
    dtAlbarans.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Decimal")
    dtDataColumn.ColumnName = "att"
    dtAlbarans.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Decimal")
    dtDataColumn.ColumnName = "graus"
    dtAlbarans.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 250
    dtDataColumn.ColumnName = "varietat"
    dtAlbarans.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 50
    dtDataColumn.ColumnName = "do"
    dtAlbarans.Columns.Add(dtDataColumn)

    'nodes del producte
    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = "10000"
    dtDataColumn.ColumnName = "nodo"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Int32")
    dtDataColumn.ColumnName = "idProducte"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Int32")
    dtDataColumn.ColumnName = "idProducteOr"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Int32")
    dtDataColumn.ColumnName = "idRecipient"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Int32")
    dtDataColumn.ColumnName = "idRecipientor"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Int32")
    dtDataColumn.ColumnName = "idImage"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.DateTime")
    dtDataColumn.ColumnName = "fecha"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Decimal")
    dtDataColumn.ColumnName = "Tipo"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Decimal")
    dtDataColumn.ColumnName = "Litres"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Boolean")
    dtDataColumn.ColumnName = "esTractament"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.String")
    dtDataColumn.MaxLength = 250
    dtDataColumn.ColumnName = "DescripcioTree"
    dtUnitats.Columns.Add(dtDataColumn)

    dtDataColumn = New DataColumn
    dtDataColumn.DataType = System.Type.GetType("System.Int32")
    dtDataColumn.ColumnName = "idMov"
    dtUnitats.Columns.Add(dtDataColumn)
    'dtDataColumn = New DataColumn
    'dtDataColumn.DataType = System.Type.GetType("System.Int32")
    'dtDataColumn.ColumnName = "idMovimiento"
    'dtUnitats.Columns.Add(dtDataColumn)
  End Sub
  'Public Function GetDataTable() As DataTable
  '    Dim dtEntidades As DataTable
  '    Dim strSql As String = ""
  '    Dim reg As DataRow
  '    Dim empresa As String
  '    Dim obra As String
  '    Dim final As Boolean = False
  '    Dim str As String = ""
  '    Dim origenSiNo As Boolean = False
  '    Dim prorigen As Int32 = 0
  '    Dim cad As String = ""
  '    Dim nodoorigen As String = ""
  '    Dim fecha As Date
  '    Dim prdAlbarans As Int32 = 0
  '    Dim posicio As Int32 = 0
  '    Dim j As Int32 = 0
  '    Dim idMovimiento As Int32 = 0
  '    Try


  '        posicio = 1
  '        If idSalidaBodega = 0 Then
  '            If productelot = 0 Then
  '                productelot = obtenirProducteLot()
  '                recipientOrigen = obtenirRecipientProducte(productelot)
  '                dataLot = obtenirDataLot()
  '                ltrlot = obtenirLtrLot()
  '            Else
  '                recipientOrigen = obtenirRecipientProducte(productelot)
  '                dataLot = Format(Now, "dd/MM/yyyy")
  '                ltrlot = 0 ' litres del recipient
  '            End If
  '        Else
  '            'dataLot = pfechalote
  '            recipientOrigen = obtenirRecipientProducte(productelot)
  '        End If
  '        posicio = 2
  '        'iniciaCampostxt()

  '        llenaInicioProducto()

  '        posicio = 3

  '        If productelot.Trim = "0" Then Exit Function
  '        If recipientOrigen.Trim = "0" Then Exit Function
  '        If Not IsDate(dataLot) Then Exit Function

  '        If Not final Then
  '            While final = False

  '                If dtUnitats.Rows.Count = 0 Then
  '                    'primer registre 
  '                    strSql = " select * from tblmovimientosproducto where  destino = " & recipientOrigen & " and idproductodestino = " & productelot & " and Fecha <= '" & dataLot & "'"
  '                    dtEntidades = Aplicacion.Conexion.ExecuteSQL2DT(strSql)

  '                    If dtEntidades.Rows.Count = 0 Then
  '                        final = True
  '                    End If
  '                    posicio = 4
  '                    For i As Int32 = 0 To dtEntidades.Rows.Count - 1

  '                        reg = dtUnitats.NewRow

  '                        'str = CStr(i)
  '                        reg("nodo") = Format(i, "0000")
  '                        reg("idproducte") = dtEntidades.Rows(i).Item("idproductodestino")
  '                        reg("idproducteor") = dtEntidades.Rows(i).Item("idproductoOrigen")
  '                        reg("idrecipient") = dtEntidades.Rows(i).Item("destino")
  '                        reg("idrecipientor") = dtEntidades.Rows(i).Item("origen")
  '                        reg("fecha") = dtEntidades.Rows(i).Item("fecha")
  '                        reg("litres") = dtEntidades.Rows(i).Item("Litros")
  '                        reg("tipo") = 0
  '                        reg("esTractament") = False
  '                        'reg("idMovimiento") = dtEntidades.Rows(i).Item("idMovimiento")
  '                        Select Case obtenirestatProducte(dtEntidades.Rows(i).Item("idproductoOrigen"), dtEntidades.Rows(i).Item("origen"))
  '                            Case 0 'pasta
  '                                reg("idImage") = 5
  '                            Case 1 'most 1
  '                                reg("idImage") = 5
  '                            Case 2 'most 2
  '                                reg("idImage") = 5
  '                            Case 3 ' most3
  '                                reg("idImage") = 5
  '                            Case 6 'vi
  '                                reg("idImage") = 9

  '                        End Select

  '                        'reg("descripcioTree") = reg("nodo") & " :: Moviment :: Data " & dtEntidades.Rows(i).Item("fecha") & " De "
  '                        reg("descripcioTree") = "Moviment :: Data " & dtEntidades.Rows(i).Item("fecha") & " De "
  '                        If Me.chkImpNomPrd.Checked = True Then
  '                            reg("descripcioTree") = reg("descripcioTree") & dtEntidades.Rows(i).Item("idproductoOrigen") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(i).Item("idproductoOrigen")))
  '                        End If
  '                        If Me.chkImpRecipient.Checked = True Then
  '                            reg("descripcioTree") = reg("descripcioTree") & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(i).Item("origen")).Trim
  '                        End If

  '                        reg("descripcioTree") = reg("descripcioTree") & " A "

  '                        If Me.chkImpNomPrd.Checked = True Then
  '                            reg("descripcioTree") = reg("descripcioTree") & dtEntidades.Rows(i).Item("idproductoDestino") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(i).Item("idproductoDestino")))
  '                        End If
  '                        If Me.chkImpRecipient.Checked = True Then
  '                            reg("descripcioTree") = reg("descripcioTree") & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(i).Item("destino")).Trim
  '                        End If

  '                        reg("descripcioTree") = reg("descripcioTree") & " " & Trim(mdlManteniments.obtenirDescrSubProducte(dtEntidades.Rows(i).Item("idSubProducto"))) & " " & Format(dtEntidades.Rows(i).Item("litros"), "###,##0.00")
  '                        'reg("descripcioTree") = reg("nodo") & " :: Moviment :: Data " & dtEntidades.Rows(i).Item("fecha") & " De " & dtEntidades.Rows(i).Item("idproductoOrigen") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(i).Item("idproductoOrigen"))) & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(i).Item("origen")).Trim
  '                        'reg("descripcioTree") = reg("descripcioTree") & " A " & dtEntidades.Rows(i).Item("idproductoDestino") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(i).Item("idproductoDestino"))) & " " & Trim(mdlManteniments.obtenirDescrSubProducte(dtEntidades.Rows(i).Item("idSubProducto"))) & " " & Format(dtEntidades.Rows(i).Item("litros"), "###,##0.00")
  '                        dtUnitats.Rows.Add(reg)

  '                        'obtenirDadesTractaments(recipientOrigen, productelot, dataLot, Format(i, "00"))
  '                    Next

  '                    posicio = 5
  '                Else
  '                    ' bucle dels nodos
  '                    Dim dtRow As DataRow()
  '                    dtRow = dtUnitats.Select("Tipo=0")

  '                    If dtRow.Length = 0 Then
  '                        final = True
  '                    Else
  '                        posicio = 6
  '                        For j = 0 To dtRow.Length - 1

  '                            'destino = dtUnitats.Rows(j).Item("idrecipientor")
  '                            'prdestino = dtUnitats.Rows(j).Item("idproducteor")
  '                            'nodoorigen = dtUnitats.Rows(j).Item("nodo")

  '                            destino = dtRow(j)("idrecipientor")
  '                            prdestino = dtRow(j)("idproducteor")
  '                            nodoorigen = dtRow(j)("nodo")
  '                            fecha = dtRow(j)("fecha")
  '                            'idMovimiento = dtRow(j)("idMovimiento")

  '                            dtRow(j)("tipo") = 1
  '                            'dtRow.SetValue(1, 6)

  '                            If prdestino <> 0 Then
  '                                'strSql = " select * from tblmovimientosproducto where destino = " & destino & " and origen<> " & destino & " And  idproductodestino = " & prdestino & " and idproductoorigen <> " & prdestino & " and fecha <= '" & fecha & "'"
  '                                strSql = " select * from tblmovimientosproducto where destino = " & destino & " and origen<> " & destino & " And  idproductodestino = " & prdestino & " and idproductoorigen <> " & prdestino & " and fecha <= '" & fecha & "'"
  '                                dtEntidades = Aplicacion.Conexion.ExecuteSQL2DT(strSql)
  '                                posicio = 7
  '                                For x As Int32 = 0 To dtEntidades.Rows.Count - 1

  '                                    reg = dtUnitats.NewRow

  '                                    'nodoorigen & "" & Format(x, "0000")
  '                                    reg("nodo") = nodoorigen & "" & Format(x, "00")
  '                                    reg("idproducte") = dtEntidades.Rows(x).Item("idproductodestino")
  '                                    reg("idproducteor") = dtEntidades.Rows(x).Item("idproductoOrigen")
  '                                    reg("idrecipient") = dtEntidades.Rows(x).Item("destino")
  '                                    reg("idrecipientor") = dtEntidades.Rows(x).Item("origen")
  '                                    reg("fecha") = dtEntidades.Rows(x).Item("fecha")
  '                                    reg("litres") = dtEntidades.Rows(x).Item("Litros")
  '                                    reg("tipo") = 0
  '                                    If dtEntidades.Rows(x).Item("idTratamiento") <> 0 Then
  '                                        reg("estractament") = True
  '                                    Else
  '                                        reg("estractament") = False
  '                                    End If
  '                                    If dtEntidades.Rows(x).Item("idproductoOrigen") = 0 And dtEntidades.Rows(x).Item("origen") = 0 Then
  '                                        reg("idImage") = 6
  '                                    Else

  '                                        posicio = 8
  '                                        Select Case obtenirestatProducte(dtEntidades.Rows(x).Item("idproductoOrigen"), dtEntidades.Rows(x).Item("origen"))
  '                                            Case 0 'pasta
  '                                                reg("idImage") = 5
  '                                            Case 1 'most 1
  '                                                reg("idImage") = 5
  '                                            Case 2 'most 2
  '                                                reg("idImage") = 5
  '                                            Case 3 ' most3
  '                                                reg("idImage") = 5
  '                                            Case 6 'vi
  '                                                reg("idImage") = 9

  '                                        End Select
  '                                    End If

  '                                    reg("descripcioTree") = "Moviment :: Data " & dtEntidades.Rows(x).Item("fecha") & " De "
  '                                    'reg("descripcioTree") = reg("nodo") & " :: Moviment :: Data " & dtEntidades.Rows(x).Item("fecha") & " De "
  '                                    If Me.chkImpNomPrd.Checked = True Then
  '                                        reg("descripcioTree") = reg("descripcioTree") & dtEntidades.Rows(x).Item("idproductoOrigen") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(x).Item("idproductoOrigen")))
  '                                    End If
  '                                    If Me.chkImpRecipient.Checked = True Then
  '                                        reg("descripcioTree") = reg("descripcioTree") & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(x).Item("origen")).Trim
  '                                    End If

  '                                    reg("descripcioTree") = reg("descripcioTree") & " A "

  '                                    If Me.chkImpNomPrd.Checked = True Then
  '                                        reg("descripcioTree") = reg("descripcioTree") & dtEntidades.Rows(x).Item("idproductoDestino") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(x).Item("idproductoDestino")))
  '                                    End If
  '                                    If Me.chkImpRecipient.Checked = True Then
  '                                        reg("descripcioTree") = reg("descripcioTree") & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(x).Item("destino")).Trim
  '                                    End If

  '                                    reg("descripcioTree") = reg("descripcioTree") & " " & Trim(mdlManteniments.obtenirDescrSubProducte(dtEntidades.Rows(x).Item("idSubProducto"))) & " " & Format(dtEntidades.Rows(x).Item("litros"), "###,##0.00")

  '                                    'reg("descripcioTree") = reg("nodo") & " :: Moviment :: Data " & dtEntidades.Rows(x).Item("fecha") & " De " & dtEntidades.Rows(x).Item("idproductoOrigen") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(x).Item("idproductoOrigen"))) & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(x).Item("origen")).Trim
  '                                    'reg("descripcioTree") = reg("descripcioTree") & " A " & dtEntidades.Rows(x).Item("idproductoDestino") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(x).Item("idproductoDestino"))) & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(x).Item("Destino")).Trim & " " & Trim(mdlManteniments.obtenirDescrSubProducte(dtEntidades.Rows(x).Item("idSubProducto"))) & " " & Format(dtEntidades.Rows(x).Item("litros"), "###,##0.00")

  '                                    dtUnitats.Rows.Add(reg)
  '                                    posicio = 9
  '                                    'obtenirDadesTractaments(destino, prdestino, fecha, nodoorigen & "" & Format(x, "00"))
  '                                    If dtEntidades.Rows(x).Item("idproductoOrigen") = 0 Then
  '                                        'buscar els albarans associats al producte.
  '                                        omplirDadesAlbarans(dtEntidades.Rows(x).Item("idproductoDestino"))
  '                                        'MsgBox("")
  '                                    End If
  '                                Next
  '                                obtenirDadesTractaments(destino, prdestino, fecha, nodoorigen & "" & Format(j, "00"))
  '                            End If
  '                        Next

  '                    End If

  '                    'final = True
  '                    posicio = 10
  '                End If

  '            End While

  '        End If

  '        ' Añadimos algunos nodos de ejemplo
  '        Dim n As Long, m As Long
  '        Dim sP As String, sH As String
  '        Dim node As TreeNode
  '        '
  '        Dim rows As DataRow()
  '        Dim aIndex(20) As Integer
  '        Dim nLevel As Integer
  '        'Dim node As String = ""



  '        rows = dtUnitats.Select("", "nodo")
  '        '
  '        ' Borrar los nodos anteriores
  '        TreeView1.Nodes.Clear()
  '        For n = 0 To rows.Length - 1
  '            ' La clave del nodo actual
  '            Dim num As Int32 = 0

  '            num = Len(rows(n)("nodo"))
  '            aIndex(nLevel) = n
  '            node = New TreeNode
  '            node.Text = rows(n)("descripcioTree")
  '            node.Tag = rows(n)("nodo")
  '            Me.TreeView1.ImageList = Me.ImageList2
  '            'node.SelectedImageIndex = 0
  '            'Me.TreeView1.SelectedImageIndex = 0

  '            posicio = 12
  '            node.Expand()
  '            Select Case num
  '                Case 0
  '                    'rows(n)("nodo") & "producte " & rows(n)("idproducte")
  '                    TreeView1.Nodes.Add(node.Text, rows(n)("idImage"))
  '                Case 2
  '                    posicio = 13
  '                    'rows(n)("nodo") & "producte " & rows(n)("idproducte")
  '                    TreeView1.Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                Case 4
  '                    posicio = 14
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    'TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes.Add(rows(n)("nodo"), rows(n)("nodo") & "producte " & rows(n)("idproducte"), rows(n)("idImage"))
  '                Case 6
  '                    posicio = 15
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    'TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes.Add(rows(n)("nodo"), rows(n)("nodo") & "producte " & rows(n)("idproducte"), rows(n)("idImage"))
  '                Case 8
  '                    posicio = 16
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                Case 10
  '                    posicio = 17
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                Case 12
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                Case 14
  '                    posicio = 19
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                Case 16
  '                    posicio = 201
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 21
  '                Case 18
  '                    posicio = 22
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 23
  '                Case 20
  '                    posicio = 22
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 18)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 23
  '                Case 22
  '                    posicio = 22
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 18)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 23
  '                Case 24
  '                    posicio = 22
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 18)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 22)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 23
  '                Case 26
  '                    posicio = 22
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 18)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 22)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 23
  '                Case 28
  '                    posicio = 22
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 18)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 22)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 26)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 23
  '                Case 30
  '                    posicio = 22
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 18)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 22)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 26)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 23
  '                Case 32
  '                    posicio = 22
  '                    TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 2)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 6)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 10)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 14)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 18)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 22)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 26)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 30)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
  '                    posicio = 23
  '            End Select
  '            'posicio = 13
  '        Next
  '        Return dtUnitats
  '        Exit Function
  '    Catch ex As Exception
  '        MsgBox(posicio & "::" & ex.Message)
  '    End Try

  'End Function
  Public Function GetDataTable() As DataTable
    Dim dtEntidades As DataTable
    Dim strSql As String = ""
    Dim reg As DataRow
    Dim final As Boolean = False
    Dim str As String = ""
    Dim origenSiNo As Boolean = False
    Dim prorigen As Int32 = 0
    Dim cad As String = ""
    Dim nodoorigen As String = ""
    Dim fecha As Date
    Dim prdAlbarans As Int32 = 0
    Dim posicio As Int32 = 0
    Dim j As Int32 = 0
    Dim idMovimiento As Int32 = 0
    Try


      posicio = 1
      If idSalidaBodega = 0 Then
        If productelot = 0 Then

          recipientOrigen = obtenirRecipientProducte(productelot)

        Else
          recipientOrigen = obtenirRecipientProducte(productelot)
          dataLot = Format(Now, "dd/MM/yyyy")
          ltrlot = 0 ' litres del recipient
        End If
      Else

        recipientOrigen = obtenirRecipientProducte(productelot)
      End If
      posicio = 2


      llenaInicioProducto()

      posicio = 3

      If productelot.Trim = "0" Then Exit Function
      If recipientOrigen.Trim = "0" Then Exit Function
      If Not IsDate(dataLot) Then Exit Function

      If Not final Then
        While final = False

          If dtUnitats.Rows.Count = 0 Then
            'primer registre 
            strSql = " select * from tblmovimientosproducto where  codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and destino = " & recipientOrigen & " and idproductodestino = " & productelot & " and Fecha <= '" & dataLot & "' and idTratamiento=0"
            dtEntidades = Aplicacion.Conexion.ExecuteSQL2DT(strSql)

            If dtEntidades.Rows.Count = 0 Then
              final = True
            End If
            posicio = 4
            For i As Int32 = 0 To dtEntidades.Rows.Count - 1

              reg = dtUnitats.NewRow

              'str = CStr(i)
              reg("nodo") = Format(i, "00000000")
              reg("idproducte") = dtEntidades.Rows(i).Item("idproductodestino")
              reg("idproducteor") = dtEntidades.Rows(i).Item("idproductoOrigen")
              reg("idrecipient") = dtEntidades.Rows(i).Item("destino")
              reg("idrecipientor") = dtEntidades.Rows(i).Item("origen")
              reg("fecha") = dtEntidades.Rows(i).Item("fecha")
              reg("litres") = dtEntidades.Rows(i).Item("Litros")
              reg("tipo") = 0
              reg("esTractament") = False
              reg("idMovimiento") = dtEntidades.Rows(i).Item("idMovimiento") ' TODO: canvis miquel 05/08
              Select Case obtenirestatProducte(dtEntidades.Rows(i).Item("idproductoOrigen"), dtEntidades.Rows(i).Item("origen"))
                Case 0 'pasta
                  reg("idImage") = 5
                Case 1 'most 1
                  reg("idImage") = 5
                Case 2 'most 2
                  reg("idImage") = 5
                Case 3 ' most3
                  reg("idImage") = 5
                Case 6 'vi
                  reg("idImage") = 9

              End Select

              'reg("descripcioTree") = reg("nodo") & " :: Moviment :: Data " & dtEntidades.Rows(i).Item("fecha") & " De "
              reg("descripcioTree") = "Moviment :: Data " & dtEntidades.Rows(i).Item("fecha") & " De "
              If Me.chkImpNomPrd.Checked = True Then
                reg("descripcioTree") = reg("descripcioTree") & dtEntidades.Rows(i).Item("idproductoOrigen") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(i).Item("idproductoOrigen")))
              End If
              If Me.chkImpRecipient.Checked = True Then
                reg("descripcioTree") = reg("descripcioTree") & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(i).Item("origen")).Trim
              End If

              reg("descripcioTree") = reg("descripcioTree") & " A "

              If Me.chkImpNomPrd.Checked = True Then
                reg("descripcioTree") = reg("descripcioTree") & dtEntidades.Rows(i).Item("idproductoDestino") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(i).Item("idproductoDestino")))
              End If
              If Me.chkImpRecipient.Checked = True Then
                reg("descripcioTree") = reg("descripcioTree") & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(i).Item("destino")).Trim
              End If

              reg("descripcioTree") = reg("descripcioTree") & " " & Trim(mdlManteniments.obtenirDescrSubProducte(dtEntidades.Rows(i).Item("idSubProducto"))) & " " & Format(dtEntidades.Rows(i).Item("litros"), "###,##0.00")
              'reg("descripcioTree") = reg("nodo") & " :: Moviment :: Data " & dtEntidades.Rows(i).Item("fecha") & " De " & dtEntidades.Rows(i).Item("idproductoOrigen") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(i).Item("idproductoOrigen"))) & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(i).Item("origen")).Trim
              'reg("descripcioTree") = reg("descripcioTree") & " A " & dtEntidades.Rows(i).Item("idproductoDestino") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(i).Item("idproductoDestino"))) & " " & Trim(mdlManteniments.obtenirDescrSubProducte(dtEntidades.Rows(i).Item("idSubProducto"))) & " " & Format(dtEntidades.Rows(i).Item("litros"), "###,##0.00")
              dtUnitats.Rows.Add(reg)

              'obtenirDadesTractaments(recipientOrigen, productelot, dataLot, Format(i, "00"))
            Next

            posicio = 5
          Else
            ' bucle dels nodos
            Dim dtRow As DataRow()
            dtRow = dtUnitats.Select("Tipo=0")

            If dtRow.Length = 0 Then
              final = True
            Else
              posicio = 6
              For j = 0 To dtRow.Length - 1


                destino = dtRow(j)("idrecipientor")
                prdestino = dtRow(j)("idproducteor")
                nodoorigen = dtRow(j)("nodo")
                fecha = dtRow(j)("fecha")
                Try
                  idMovimiento = dtRow(j)("idMov")
                Catch ex As Exception
                  idMovimiento = 999999999
                End Try

                dtRow(j)("tipo") = 1
                'dtRow.SetValue(1, 6)

                If prdestino <> 0 Then
                  'TODO MODIFICACIO LINIA MIQUEL TRIEM 'and idTratamiento = 0'
                  strSql = " select * from tblmovimientosproducto where codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and destino = " & destino & " and origen<> " & destino & " And  idproductodestino = " & prdestino & " and idproductoorigen <> " & prdestino & " and fecha <= '" & fecha & "' and idMovimiento <= " & idMovimiento & " "
                  'strSql = " select * from tblmovimientosproducto where codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and destino = " & destino & " and origen<> " & destino & " And  idproductodestino = " & prdestino & " and idproductoorigen <> " & prdestino & " and idTratamiento = 0"
                  dtEntidades = Aplicacion.Conexion.ExecuteSQL2DT(strSql)
                  posicio = 7
                  For x As Int32 = 0 To dtEntidades.Rows.Count - 1

                    reg = dtUnitats.NewRow

                    'nodoorigen & "" & Format(x, "0000")
                    reg("nodo") = nodoorigen & "" & Format(x, "0000")
                    reg("idproducte") = dtEntidades.Rows(x).Item("idproductodestino")
                    reg("idproducteor") = dtEntidades.Rows(x).Item("idproductoOrigen")
                    reg("idrecipient") = dtEntidades.Rows(x).Item("destino")
                    reg("idrecipientor") = dtEntidades.Rows(x).Item("origen")
                    reg("fecha") = dtEntidades.Rows(x).Item("fecha")
                    reg("litres") = dtEntidades.Rows(x).Item("Litros")
                    reg("tipo") = 0
                    If dtEntidades.Rows(x).Item("idTratamiento") <> 0 Then
                      reg("estractament") = True
                    Else
                      reg("estractament") = False
                    End If
                    If dtEntidades.Rows(x).Item("idproductoOrigen") = 0 And dtEntidades.Rows(x).Item("origen") = 0 Then
                      reg("idImage") = 6
                    Else

                      posicio = 8
                      Select Case obtenirestatProducte(dtEntidades.Rows(x).Item("idproductoOrigen"), dtEntidades.Rows(x).Item("origen"))
                        Case 0 'pasta
                          reg("idImage") = 5
                        Case 1 'most 1
                          reg("idImage") = 5
                        Case 2 'most 2
                          reg("idImage") = 5
                        Case 3 ' most3
                          reg("idImage") = 5
                        Case 6 'vi
                          reg("idImage") = 9
                      End Select
                      ' comprovar que la imatge no sigui null
                      If Microsoft.VisualBasic.IsDBNull(reg("idImage")) Then
                        reg("idImage") = 5
                      End If
                    End If

                    reg("descripcioTree") = "Moviment :: Data " & dtEntidades.Rows(x).Item("fecha") & " De "
                    'reg("descripcioTree") = reg("nodo") & " :: Moviment :: Data " & dtEntidades.Rows(x).Item("fecha") & " De "
                    If Me.chkImpNomPrd.Checked = True Then
                      reg("descripcioTree") = reg("descripcioTree") & dtEntidades.Rows(x).Item("idproductoOrigen") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(x).Item("idproductoOrigen")))
                    End If
                    If Me.chkImpRecipient.Checked = True Then
                      reg("descripcioTree") = reg("descripcioTree") & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(x).Item("origen")).Trim
                    End If

                    reg("descripcioTree") = reg("descripcioTree") & " A "

                    If Me.chkImpNomPrd.Checked = True Then
                      reg("descripcioTree") = reg("descripcioTree") & dtEntidades.Rows(x).Item("idproductoDestino") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(x).Item("idproductoDestino")))
                    End If
                    If Me.chkImpRecipient.Checked = True Then
                      reg("descripcioTree") = reg("descripcioTree") & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(x).Item("destino")).Trim
                    End If

                    reg("descripcioTree") = reg("descripcioTree") & " " & Trim(mdlManteniments.obtenirDescrSubProducte(dtEntidades.Rows(x).Item("idSubProducto"))) & " " & Format(dtEntidades.Rows(x).Item("litros"), "###,##0.00")

                    reg("idMov") = dtEntidades.Rows(x).Item("idMovimiento")
                    'reg("descripcioTree") = reg("nodo") & " :: Moviment :: Data " & dtEntidades.Rows(x).Item("fecha") & " De " & dtEntidades.Rows(x).Item("idproductoOrigen") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(x).Item("idproductoOrigen"))) & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(x).Item("origen")).Trim
                    'reg("descripcioTree") = reg("descripcioTree") & " A " & dtEntidades.Rows(x).Item("idproductoDestino") & "-" & Trim(mdlProductes.obtenirNomProducte(dtEntidades.Rows(x).Item("idproductoDestino"))) & " " & mdlTinas.obtenDescripcio(dtEntidades.Rows(x).Item("Destino")).Trim & " " & Trim(mdlManteniments.obtenirDescrSubProducte(dtEntidades.Rows(x).Item("idSubProducto"))) & " " & Format(dtEntidades.Rows(x).Item("litros"), "###,##0.00")

                    dtUnitats.Rows.Add(reg)
                    posicio = 9
                    'obtenirDadesTractaments(destino, prdestino, fecha, nodoorigen & "" & Format(x, "00"))
                    If dtEntidades.Rows(x).Item("idproductoOrigen") = 0 Then
                      'buscar els albarans associats al producte.
                      omplirDadesAlbarans(dtEntidades.Rows(x).Item("idproductoDestino"))
                      'MsgBox("")
                    End If
                  Next
                  ' entrem les dades dels tractaments fets
                  obtenirDadesTractaments(destino, prdestino, fecha, nodoorigen & "" & Format(j, "0000"))
                  ' entrem les dades del canvi de la do si en tenim
                  obtenirCanviDo(prdestino, fecha, nodoorigen & "" & Format(j, "0000"))
                End If
              Next

            End If

            'final = True
            posicio = 10
          End If

        End While

      End If


      Dim n As Long

      Dim node As TreeNode
      '
      Dim rows As DataRow()
      Dim aIndex(20) As Integer
      Dim nLevel As Integer
      'Dim node As String = ""

      rows = dtUnitats.Select("", "nodo")
      '
      ' Borrar los nodos anteriores

      TreeView1.Nodes.Clear()
      For n = 0 To rows.Length - 1
        ' La clave del nodo actual
        Dim num As Int32 = 0

        num = Len(rows(n)("nodo"))
        aIndex(nLevel) = n
        node = New TreeNode
        node.Text = rows(n)("descripcioTree")
        node.Tag = rows(n)("nodo")
        Me.TreeView1.ImageList = Me.ImageList2


        posicio = 12
        node.Expand()
        Select Case num
          Case 0
            'rows(n)("nodo") & "producte " & rows(n)("idproducte")
            TreeView1.Nodes.Add(node.Text, rows(n)("idImage"))
          Case 4
            posicio = 13
            'rows(n)("nodo") & "producte " & rows(n)("idproducte")
            TreeView1.Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
          Case 8
            posicio = 14
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            'TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 3)).Nodes.Add(rows(n)("nodo"), rows(n)("nodo") & "producte " & rows(n)("idproducte"), rows(n)("idImage"))
          Case 12
            posicio = 15
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            'TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 3)).Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes.Add(rows(n)("nodo"), rows(n)("nodo") & "producte " & rows(n)("idproducte"), rows(n)("idImage"))
          Case 16
            posicio = 16
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
          Case 20
            posicio = 17
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
          Case 24
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
          Case 28
            posicio = 19
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
          Case 32
            posicio = 201
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 21
          Case 36
            posicio = 22
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 32)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 23
          Case 40
            posicio = 22
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 32)).Nodes(Mid(rows(n)("nodo"), 1, 36)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 23
          Case 44
            posicio = 22
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 32)).Nodes(Mid(rows(n)("nodo"), 1, 36)).Nodes(Mid(rows(n)("nodo"), 1, 40)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 23
          Case 48
            posicio = 22
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 32)).Nodes(Mid(rows(n)("nodo"), 1, 36)).Nodes(Mid(rows(n)("nodo"), 1, 40)).Nodes(Mid(rows(n)("nodo"), 1, 44)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 23
          Case 52
            posicio = 22
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 32)).Nodes(Mid(rows(n)("nodo"), 1, 36)).Nodes(Mid(rows(n)("nodo"), 1, 40)).Nodes(Mid(rows(n)("nodo"), 1, 44)).Nodes(Mid(rows(n)("nodo"), 1, 48)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 23
          Case 56
            posicio = 22
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 32)).Nodes(Mid(rows(n)("nodo"), 1, 36)).Nodes(Mid(rows(n)("nodo"), 1, 40)).Nodes(Mid(rows(n)("nodo"), 1, 44)).Nodes(Mid(rows(n)("nodo"), 1, 48)).Nodes(Mid(rows(n)("nodo"), 1, 52)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 23
          Case 60
            posicio = 22
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 32)).Nodes(Mid(rows(n)("nodo"), 1, 36)).Nodes(Mid(rows(n)("nodo"), 1, 40)).Nodes(Mid(rows(n)("nodo"), 1, 44)).Nodes(Mid(rows(n)("nodo"), 1, 48)).Nodes(Mid(rows(n)("nodo"), 1, 52)).Nodes(Mid(rows(n)("nodo"), 1, 56)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 23
          Case 64
            posicio = 22
            TreeView1.Nodes(Mid(rows(n)("nodo"), 1, 4)).Nodes(Mid(rows(n)("nodo"), 1, 8)).Nodes(Mid(rows(n)("nodo"), 1, 12)).Nodes(Mid(rows(n)("nodo"), 1, 16)).Nodes(Mid(rows(n)("nodo"), 1, 20)).Nodes(Mid(rows(n)("nodo"), 1, 24)).Nodes(Mid(rows(n)("nodo"), 1, 28)).Nodes(Mid(rows(n)("nodo"), 1, 32)).Nodes(Mid(rows(n)("nodo"), 1, 36)).Nodes(Mid(rows(n)("nodo"), 1, 40)).Nodes(Mid(rows(n)("nodo"), 1, 44)).Nodes(Mid(rows(n)("nodo"), 1, 48)).Nodes(Mid(rows(n)("nodo"), 1, 52)).Nodes(Mid(rows(n)("nodo"), 1, 56)).Nodes(Mid(rows(n)("nodo"), 1, 60)).Nodes.Add(rows(n)("nodo"), node.Text, rows(n)("idImage"))
            posicio = 23
        End Select
        'posicio = 13
      Next
      Return dtUnitats
      Exit Function
    Catch ex As Exception
      MsgBox(posicio & "::" & ex.Message)
    End Try

  End Function
  Private Sub omplirDadesAlbarans(ByVal pProducte As Int32)
    Dim cad As String = ""
    Dim dt As New DataTable
    Dim row As DataRow
    Try

      cad = "SELECT     A.CodigoEmpresa, A.EjercicioAlbaran, A.SerieAlbaran, A.NumeroAlbaran, A.FechaAlbaran, A.Hora, A.idProveedor, A.TipoUva, A.TotalCarga, A.CalidadVisual, A.Grados, "
      cad = cad & " A.idDestino, A.IDViaje, A.IdDO, A.idProductoDestino, A.Tara, A.Bruto, A.idFinca, A.idParcela, A.CodigoPoblacion, A.ph, A.AciTotal, U.Nombre, P.Nombre AS NomPve, "
      cad = cad & " tblDO.DenomOrigen"
      cad = cad & " FROM tblAlbaranesProveedor AS A INNER JOIN"
      cad = cad & " tblProveedores AS P ON A.idProveedor = P.idProveedor INNER JOIN"
      cad = cad & "  tblTipoUva AS U ON A.TipoUva = U.idTipoUva INNER JOIN"
      cad = cad & " tblDO ON A.IdDO = tblDO.idDO "
      cad = cad & " WHERE A.CodigoEmpresa = '" & Aplicacion.CodigoEmpresa & "' And A.IdProductoDestino = " & pProducte & " and A.Contabilizaralbaran = 1"

      dt = Aplicacion.Conexion.ExecuteSQL2DT(cad)

      If Not dt Is Nothing Then
        For i As Int32 = 0 To dt.Rows.Count - 1
          If Not existeixAlbara(CStr(dt.Rows(i).Item("EjercicioAlbaran")) & "/" & CStr(dt.Rows(i).Item("NumeroAlbaran")), dt.Rows(i).Item("FechaAlbaran")) Then
            row = dtAlbarans.NewRow
            row("NumeroAlbara") = CStr(dt.Rows(i).Item("EjercicioAlbaran")) & "/" & CStr(dt.Rows(i).Item("NumeroAlbaran"))
            row("FechaAlbaran") = dt.Rows(i).Item("FechaAlbaran")
            row("NombreProveeodr") = dt.Rows(i).Item("NomPve")
            row("Carga") = dt.Rows(i).Item("TotalCarga")
            If Not Microsoft.VisualBasic.IsDBNull(dt.Rows(i).Item("ph")) Then
              row("ph") = Format(dt.Rows(i).Item("ph"), "###0.00")
            Else
              row("ph") = 0
            End If
            If Not Microsoft.VisualBasic.IsDBNull(dt.Rows(i).Item("grados")) Then
              row("graus") = Format(dt.Rows(i).Item("grados"), "###0.00")
            Else
              row("graus") = 0
            End If
            If Not Microsoft.VisualBasic.IsDBNull(dt.Rows(i).Item("AciTotal")) Then
              row("att") = Format(dt.Rows(i).Item("AciTotal"), "###0.00")
            Else
              row("att") = 0
            End If
            row("varietat") = dt.Rows(i).Item("Nombre")
            row("do") = Trim(dt.Rows(i).Item("DenomOrigen"))
            dtAlbarans.Rows.Add(row)
          End If
        Next
      End If


      Me.gridAlb.DataSource = dtAlbarans
      'me.gridAlb.Columns(0).
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Private Function existeixAlbara(ByVal numero As String, ByVal fecha As Date) As Boolean
    Try

      existeixAlbara = False

      For i As Int32 = 0 To dtAlbarans.Rows.Count - 1
        If dtAlbarans.Rows(i).Item("NumeroAlbara") = numero And dtAlbarans.Rows(i).Item("FechaAlbaran") = fecha Then
          existeixAlbara = True
          Exit Function
        End If
      Next

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Function
  Private Sub llenaInicioProducto()
    Dim reg As DataRow
    Dim i As Int32 = 0
    Try
      reg = dtUnitats.NewRow

      'str = CStr(i)
      reg("nodo") = Format(i, "0000")
      reg("idproducte") = productelot
      reg("idproducteor") = productelot
      reg("idrecipient") = recipientOrigen
      reg("idrecipientor") = recipientOrigen
      reg("fecha") = dataLot
      reg("litres") = ltrlot
      reg("tipo") = 0
      reg("esTractament") = False
      Select Case obtenirestatProducte(productelot, recipientOrigen)
        Case 0 'pasta
          reg("idImage") = 5
        Case 1 'most 1
          reg("idImage") = 5
        Case 2 'most 2
          reg("idImage") = 5
        Case 3 ' most3
          reg("idImage") = 5
        Case 6 'vi
          reg("idImage") = 9
      End Select

      reg("descripcioTree") = " Data: " & dataLot & " " & productelot & "-" & Trim(mdlProductes.obtenirNomProducte(productelot)) & " :: " & mdlTinas.obtenDescripcio(recipientOrigen).Trim & "-"

      reg("descripcioTree") = reg("descripcioTree") & Trim(mdlManteniments.obtenirDoRaim(mdlProductes.obtenirDoProducte(recipientOrigen, productelot))) & "" & _
      "-" & Trim(mdlManteniments.obtenirColorRaim(mdlProductes.obtenirColorProducte(recipientOrigen, productelot))) & "-" & Format(ltrlot, "###,##0.00")

      dtUnitats.Rows.Add(reg)



    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Private Sub obtenirDadesTractaments(ByVal precipient As Int32, ByVal pproducte As Int32, ByVal pdata As Date, ByVal indNodo As String)
    Dim strsql As String
    Dim dtentidades As DataTable
    Dim reg As DataRow
    Try

      strsql = " select * from tblTratamientosRecipiente where codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and idRecipiente = " & precipient & " And  idProducto = " & pproducte & " and fecha <= '" & pdata & "'"
      dtentidades = Aplicacion.Conexion.ExecuteSQL2DT(strsql)

      Dim t As Int32 = 0

      For u As Int32 = 0 To dtentidades.Rows.Count - 1
        reg = dtUnitats.NewRow

        t = t + 1

        indNodo = indNodo



        reg("nodo") = Format(t, indNodo)
        reg("idproducte") = dtentidades.Rows(u).Item("idProducto")
        reg("idproducteor") = 0
        reg("idrecipient") = dtentidades.Rows(u).Item("idRecipiente")
        reg("idrecipientor") = 0
        reg("fecha") = dtentidades.Rows(u).Item("fecha")
        reg("litres") = dtentidades.Rows(u).Item("Cantidad")
        reg("tipo") = 1
        reg("estractament") = True
        reg("idImage") = 7 ' tractament
        reg("descripcioTree") = "Tractament :: " & Trim(mdlTinas.obtenDescripcio(reg("idrecipient"))) & " :: Data " & dtentidades.Rows(u).Item("Fecha") & " Tipo " & mdlTractaments.obtenerDescripcionTratamiento(dtentidades.Rows(u).Item("idTratamiento")) & " --> " & dtentidades.Rows(u).Item("Cantidad") & " --> " & Trim(dtentidades.Rows(u).Item("Descripcion"))
        dtUnitats.Rows.Add(reg)
      Next

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Private Sub obtenirCanviDo(ByVal pproducte As Int32, ByVal pdata As Date, ByVal indNodo As String)
    Dim strsql As String
    Dim dtentidades As DataTable
    Dim reg As DataRow
    Try

      strsql = " select * from tblHistoricoActualizacionProductos where codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and idProducto = " & pproducte & " and fechaact <= '" & pdata & "'"
      dtentidades = Aplicacion.Conexion.ExecuteSQL2DT(strsql)

      Dim t As Int32 = 0

      For u As Int32 = 0 To dtentidades.Rows.Count - 1
        t = t + 1
        indNodo = indNodo

        If Not Microsoft.VisualBasic.IsDBNull(dtentidades.Rows(u).Item("DoInicial")) Then
          reg = dtUnitats.NewRow
          reg("nodo") = Format(t, indNodo)
          reg("idproducte") = dtentidades.Rows(u).Item("idProducto")
          reg("idproducteor") = 0
          reg("idrecipient") = 0
          reg("idrecipientor") = 0
          reg("fecha") = dtentidades.Rows(u).Item("FechaAct")
          reg("litres") = 0
          reg("tipo") = 1
          reg("estractament") = True
          reg("idImage") = 7 ' tractament
          reg("descripcioTree") = "Canvi Do :: Data " & dtentidades.Rows(u).Item("Fechaact") & " De " & Trim(mdlManteniments.obtenirDoRaim(dtentidades.Rows(u).Item("DoInicial"))) & " A " & Trim(mdlManteniments.obtenirDoRaim(dtentidades.Rows(u).Item("DoFinal"))) & " "
          dtUnitats.Rows.Add(reg)
        End If
      Next

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Function obtenirestatProducte(ByVal pProducto As Int32, ByVal pRecipiente As Int32) As Int32
    Dim row As New tblProductosTinaRow
    Dim cad As String = ""
    Try

      cad = "codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and idProducto = " & pProducto & " and idrecipiente = " & pRecipiente & ""
      row = Aplicacion.Conexion.tblProductosTinaCollection.GetRow(cad)

      If Not row Is Nothing Then
        obtenirestatProducte = row.IdSubProducto
      End If


    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Function
  Private Function obtenirRecipientProducte(ByVal pid As Int32) As Int32
    Dim row As New tblProductosTinaRow
    Try

      row = Aplicacion.Conexion.tblProductosTinaCollection.GetRow("codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and idProducto = " & pid & "")

      If Not row Is Nothing Then
        obtenirRecipientProducte = row.IdRecipiente
      End If

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Function

  Private Sub obtenirDades(ByVal pror As Int32, ByVal ori As Int32, ByVal strnodo As String)
    Dim strsql As String = ""
    Dim dtentidades As DataTable
    Dim str As String
    Dim cad As String = ""

    Try


      strsql = " select * from tblmovimientosproducto where codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and destino = " & ori & " And idproductodestino = " & pror & ""

      dtentidades = Aplicacion.Conexion.ExecuteSQL2DT(strsql)

      For j As Int32 = 0 To dtentidades.Rows.Count - 1

        str = "insert into #TmpArbre VALUES ('" & strnodo & "'," & dtentidades.Rows(j).Item("idproductoorigen") & "," & dtentidades.Rows(j).Item("idproductodestino") & ",'" & dtentidades.Rows(j).Item("fecha") & "')"
        Aplicacion.Conexion.ExecuteSQLScalar(str)

        If dtentidades.Rows.Count = 1 Then
          'cad = "insert into #TmpArbre VALUES ('" & str & "'," & dtentidades.Rows(j).Item("idproductoorigen") & "," & dtentidades.Rows(i).Item("idproductodestino") & ",'" & dtentidades.Rows(i).Item("fecha") & "')"
          'Aplicacion.Conexion.ExecuteSQLScalar(cad)
        Else

          If destino = 0 Then
            'origenSiNo = True
            'albarans subproducte obtenir els albarans d'entrada
          Else
            obtenirDades2(prdestino, destino, str)

          End If
        End If
      Next
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  Private Sub obtenirDades2(ByVal pror As Int32, ByVal ori As Int32, ByVal strnodo As String)
    Dim strsql As String = ""
    Dim dtentidades As DataTable
    Dim str As String
    Dim cad As String = ""
    Try
      strsql = " select * from tblmovimientosproducto where codigoempresa = '" & Aplicacion.CodigoEmpresa & "' and destino = " & ori & " And idproductodestino = " & pror & ""

      dtentidades = Aplicacion.Conexion.ExecuteSQL2DT(strsql)

      For j As Int32 = 0 To dtentidades.Rows.Count - 1


        destino = dtentidades.Rows(j).Item("origen")
        prdestino = dtentidades.Rows(j).Item("idproductoorigen")

        str = "insert into #TmpArbre VALUES ('" & str & "'," & dtentidades.Rows(j).Item("idproductoorigen") & "," & dtentidades.Rows(j).Item("idproductodestino") & ",'" & dtentidades.Rows(j).Item("fecha") & "')"
        Aplicacion.Conexion.ExecuteSQLScalar(str)

        If dtentidades.Rows.Count = 1 Then
          'cad = "insert into #TmpArbre VALUES ('" & str & "'," & dtentidades.Rows(j).Item("idproductoorigen") & "," & dtentidades.Rows(i).Item("idproductodestino") & ",'" & dtentidades.Rows(i).Item("fecha") & "')"
          'Aplicacion.Conexion.ExecuteSQLScalar(cad)
        Else

          If destino = 0 Then
            'origenSiNo = True
            'albarans subproducte obtenir els albarans d'entrada
          Else
            obtenirDades2(prdestino, destino, str)

          End If
        End If
      Next
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Dispose(True)
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Dim rows As DataRow()

    Try

      If dtUnitats.Rows.Count > 0 Then
        If Me.optDetall.Checked Then
          rows = dtUnitats.Select("", "nodo")

          Dim rpt1 As rptListadoTrazabilidad
          Dim view As New frmConfiguracioInf

          rpt1 = New rptListadoTrazabilidad


          rpt1.TextBox4.Text = mdlManteniments.obtenirDescripcioSalidaProducto(idSalidaBodega)

          rpt1.DataSource = rows

          rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
          rpt1.PageSettings.Margins.Top = 0.1
          rpt1.PageSettings.Margins.Left = 0.2
          rpt1.PageSettings.Margins.Right = 0.2
          rpt1.PageSettings.Margins.Bottom = 0.1

          rpt1.Run()

          view.Viewer1.Document = rpt1.Document
          view.MdiParent = Me.MdiParent
          view.Show()


          'Dim m_print As New ControlPrint()
          'm_print.StretchControl = False
          'm_print.SetControl(TreeView1)
          'm_print.PrintWidth = m_print.CalculateSize().Width
          'm_print.PrintHeight = m_print.CalculateSize().Height
          'PrintPreviewDialog1.Document = m_print
          ' ''PrintPreviewDialog1.Document. = "Traçabilitat"
          'PrintPreviewDialog1.ShowDialog()
        Else
          Dim distinctDT As DataTable
          distinctDT = dtUnitats.DefaultView.ToTable(True, "descripcioTree", "idImage", "fecha")
          'distinctDT = dtUnitats.DefaultView.ToTable(True, "descripcioTree", "fecha")
          rows = distinctDT.Select("idImage=7", "fecha")

          Dim rpt1 As rptListadoTrazabilidadResumen
          Dim view As New frmConfiguracioInf

          rpt1 = New rptListadoTrazabilidadResumen(dtAlbarans)


          rpt1.TextBox4.Text = mdlManteniments.obtenirDescripcioSalidaProducto(idSalidaBodega)
          rpt1.DataSource = rows

          rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
          rpt1.PageSettings.Margins.Top = 0.1
          rpt1.PageSettings.Margins.Left = 0.2
          rpt1.PageSettings.Margins.Right = 0.2
          rpt1.PageSettings.Margins.Bottom = 0.1

          rpt1.Run()

          view.Viewer1.Document = rpt1.Document
          view.MdiParent = Me.MdiParent
          view.Show()
        End If
      End If

        'Dim print As New PrintHelper
        'print.PrintPreviewTree(Me.TreeView1, "My Tree Sample")


    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub chkDesglosarArbol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesglosarArbol.CheckedChanged
    If Me.chkDesglosarArbol.Checked = True Then
      Me.TreeView1.ExpandAll()
    Else
      Me.TreeView1.CollapseAll()
    End If
  End Sub

  Private Sub chkImpNomPrd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles chkImpNomPrd.Validating
    inicia()
  End Sub

  Private Sub chkImpRecipient_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles chkImpRecipient.Validating
    inicia()
  End Sub

  Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optResum.CheckedChanged

  End Sub
End Class