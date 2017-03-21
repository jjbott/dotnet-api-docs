    Private Sub BindControls()
        ' Create a DataSet named SuppliersProducts.
        Dim SuppliersProducts As New DataSet("SuppliersProducts")
        ' Adds two DataTable objects, Suppliers and Products.
        SuppliersProducts.Tables.Add(New DataTable("Suppliers"))
        SuppliersProducts.Tables.Add(New DataTable("Products"))
        ' Insert code to add DataColumn objects.
        ' Insert code to fill tables with columns and data.
        ' Binds the DataGrid to the DataSet, displaying the Suppliers table.
        dataGrid1.SetDataBinding(SuppliersProducts, "Suppliers")
    End Sub 'BindControls