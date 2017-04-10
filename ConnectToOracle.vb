Imports Oracle.DataAccess.Client
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        'Set up conncection
        Dim oradatabase As String = "Data Source = (DESCRIPTION=(ADDRESS_LIST=" _
        + "(ADDRESS=(PROTOCOL=TCP)(HOST=YOURHOST)(PORT=YOURPORT)))" _
        + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=YOUR DB NAME)));" _
        + "User Id=USERID;Password=USERPASS;"
        'Connect to database
        Dim conn As New OracleConnection(oradatabase)
        conn.Open()
        'Create DataAdapter to define where to pull data from
        Dim adapter As OracleDataAdapter = New OracleDataAdapter("SELECT * FROM CUSTOMERS", conn)
        'Create DataSet to import the retrieved data
        Dim customerDs As New DataSet()
        'Populate the dataset based on the DataAdapters parameters
        adapter.Fill(customerDs)
        'Bind the data to the DataGrid
        dgCustomer.DataSource = customerDs.Tables(0)
        'Disconnect from the database
        conn.Close()


    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        'Set up conncection
        Dim oradatabase As String = "Data Source = (DESCRIPTION=(ADDRESS_LIST=" _
            + "(ADDRESS=(PROTOCOL=TCP)(HOST=YOURHOST)(PORT=YOURPORT)))" _
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=YOUR DB NAME)));" _
            + "User Id=USERID;Password=USERPASS;"
        'Connect to database
        Dim conn As New OracleConnection(oradatabase)
        conn.Open()
        'Create Command
        Dim SQLCommand As String
        If txtCustState.Text <> "" Then
            SQLCommand = " SELECT * FROM CUSTOMERS WHERE STATE = " + "'" + txtCustState.Text + "'"
        Else
            SQLCommand = "SELECT * FROM CUSTOMERS"
        End If
        'Create DataAdapter to define where to pull data from
        Dim adapter As OracleDataAdapter = New OracleDataAdapter(SQLCommand, conn)
        'Create DataSet to import the retrieved data
        Dim customerDs As New DataSet()
        'Populate the dataset based on the DataAdapters parameters
        adapter.Fill(customerDs)
        'Bind the data to the DataGrid
        dgCustomer.DataSource = customerDs.Tables(0)
        'Disconnect from the Database
        conn.Close()
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        End
    End Sub
End Class
