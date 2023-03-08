Imports System.Drawing.Printing

Public Class DataGridViewPrinter
    Private dataGridView As DataGridView
    Private printDocument As PrintDocument
    Private columnWidths As List(Of Integer)

    Public Sub New(dataGridView As DataGridView, printDocument As PrintDocument)
        Me.dataGridView = dataGridView
        Me.printDocument = printDocument

        ' Calcular los anchos de columna
        columnWidths = New List(Of Integer)
        For Each column As DataGridViewColumn In dataGridView.Columns
            columnWidths.Add(column.Width)
        Next
    End Sub

    Public Sub Print()
        ' Configurar la impresión
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Manejar el evento de impresión
            AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

            ' Imprimir
            printDocument.Print()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Establecer los márgenes
        Dim leftMargin = e.MarginBounds.Left
        Dim topMargin = e.MarginBounds.Top
        Dim rightMargin = e.MarginBounds.Right
        Dim bottomMargin = e.MarginBounds.Bottom

        ' Calcular la altura de la celda y la altura total de la página
        Dim cellHeight = dataGridView.Font.Height + 5
        Dim pageHeight = e.MarginBounds.Height

        ' Calcular el número de filas que caben en una página
        Dim rowsPerPage = Math.Floor(pageHeight / cellHeight)

        ' Calcular el número total de páginas
        Dim pageCount = Math.Ceiling(dataGridView.Rows.Count / rowsPerPage)

        ' Dibujar las celdas
        Dim cellTop = topMargin
        Dim rowIndex = 0
        While rowIndex < dataGridView.Rows.Count AndAlso rowIndex < (e.PageSettings.PrinterSettings.FromPage - 1) * rowsPerPage
            cellTop += cellHeight
            rowIndex += 1
        End While
        While rowIndex < dataGridView.Rows.Count AndAlso rowIndex < e.PageSettings.PrinterSettings.ToPage * rowsPerPage
            Dim row = dataGridView.Rows(rowIndex)
            Dim cellLeft = leftMargin

            ' Calcular la altura de la fila
            Dim columnHeight = 0
            For i As Integer = 0 To dataGridView.Columns.Count - 1
                Dim value = row.Cells(i).FormattedValue.ToString()
                Dim size = e.Graphics.MeasureString(value, dataGridView.Font, columnWidths(i))

                ' Calcular la altura necesaria para mostrar el valor completo de la celda
                If size.Height > columnHeight Then
                    columnHeight = size.Height
                End If

                ' Dibujar la celda
                e.Graphics.DrawString(value, dataGridView.Font, Brushes.Black, New RectangleF(cellLeft, cellTop, columnWidths(i), columnHeight), StringFormat.GenericDefault)

                cellLeft += columnWidths(i)
            Next

            ' Si es la última fila, no dibujar las líneas horizontales
            If rowIndex = dataGridView.Rows.Count - 1 Then
                cellTop += columnHeight
            Else
                ' Dibujar las líneas horizontales
                e.Graphics.DrawLine(Pens.Black, leftMargin, cellTop + columnHeight, rightMargin, cellTop + columnHeight)

                ' Mover a la siguiente línea
                cellTop += columnHeight
            End If

            rowIndex += 1

            ' Dibujar las líneas verticales
            Dim cellBottom = cellTop
            For i As Integer = 0 To dataGridView.Columns.Count
                Dim columnWidth = columnWidths(i)

                ' Si es la última columna, no dibujar las líneas verticales
                If i = dataGridView.Columns.Count Then
                    cellBottom += columnHeight
                Else
                    ' Dibujar las líneas verticales
                    e.Graphics.DrawLine(Pens.Black, leftMargin + columnWidths.Take(i).Sum(), topMargin, leftMargin + columnWidths.Take(i).Sum(), cellBottom)
                End If
            Next
        End While

        ' Dibujar el número de página
        Dim pageNumberString = $"Página {printDocument.PrinterSettings.FromPage + e.PageSettings.PrinterSettings.ToPage - 1} de {pageCount}"
        Dim pageNumberSize = e.Graphics.MeasureString(pageNumberString, dataGridView.Font)
        e.Graphics.DrawString(pageNumberString, dataGridView.Font, Brushes.Black, rightMargin - pageNumberSize.Width, bottomMargin - pageNumberSize.Height)

        ' Indicar si hay más páginas
        e.HasMorePages = rowIndex < dataGridView.Rows.Count
    End Sub
End Class
