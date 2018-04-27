Public Class Form1
    Dim phoneobj As New phoneClass 'define the objects from other class
    Dim dateObj As New dateClass
    Dim builtDateObj As New dateClass
    Dim soldDateObj As New dateClass
    Dim conn As New ADODB.Connection
    Dim rs As New ADODB.Recordset    'connect to table rate
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicShopDBDataSet.electronicShop' table. You can move, or remove it, as needed.
        Me.ElectronicShopTableAdapter.Fill(Me.ElectronicShopDBDataSet.electronicShop)
        'setting up the ADO objects
        conn.Provider = "Microsoft.Jet.OleDB.4.0"
        ' Setting up the jet DB driver (access) 
        conn.ConnectionString = "C:\ITD\Term 3\Visual Basic.Net\assignment\assignment 4\electronicShopDB.mdb"
        conn.Open()
        rs.Open("select * from electronicShop", conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
    End Sub
    'save one new object in the form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or
           TextBox2.Text = "" Or
           TextBox3.Text = "" Or
           TextBox4.Text = "" Or
           TextBox5.Text = "" Or
           TextBox6.Text = "" Or
           TextBox7.Text = "" Or
           TextBox12.Text = "" Or
           TextBox8.Text = "" Or
            TextBox9.Text = "" Or
           TextBox10.Text = "" Or
           TextBox11.Text = "" Or
            TextBox13.Text = "" Then
            MessageBox.Show("Please Fill up all boxes")
            Exit Sub
        End If
        If rs.EOF = True And rs.BOF = True Then
            'MessageBox.Show("Table is Empty")
            'Exit Sub
        Else
            rs.MoveFirst()
        End If
        Dim Criteria As String

        Criteria = "phoneID =" + TextBox1.Text

        'go to the beginning to start serach 
        rs.Find(Criteria)
        ' Either We find the record(s), which is the first record if there are more than one
        ' If record is found the file pointer stays at it
        'if not found, the file pointer has passed eof meaning eof = true
        If rs.EOF Then
            'not found
            rs.AddNew()
            Call SaveinTable()
            rs.Update()
            MessageBox.Show("Record Added succesfully")
            ' add items for combobox too

            Call ClearForm()
            Exit Sub
        Else
            'found 

            MessageBox.Show("Duplicate Record, try another ID")
            Exit Sub
        End If
    End Sub
    Private Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Clear()
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
    End Sub
    'Saving function in DB
    Private Sub SaveinTable()
        'Put value in class object
        phoneobj.phoneID = Convert.ToInt32(TextBox1.Text)
        phoneobj.make = Convert.ToString(TextBox2.Text)
        phoneobj.model = Convert.ToString(TextBox3.Text)
        phoneobj.price = Convert.ToDecimal(TextBox12.Text)
        phoneobj.feature = Convert.ToString(TextBox13.Text)
        builtDateObj.dayName = Convert.ToString(TextBox4.Text)
        builtDateObj.day = Convert.ToInt32(TextBox5.Text)
        builtDateObj.month = Convert.ToString(TextBox6.Text)
        builtDateObj.year = Convert.ToInt32(TextBox7.Text)
        soldDateObj.dayName = Convert.ToString(TextBox8.Text)
        soldDateObj.day = Convert.ToInt32(TextBox9.Text)
        soldDateObj.month = Convert.ToString(TextBox10.Text)
        soldDateObj.year = Convert.ToInt32(TextBox11.Text)
        'Put from class obj into DB
        rs.Fields("phoneID").Value = phoneobj.phoneID
        rs.Fields("make").Value = phoneobj.make
        rs.Fields("model").Value = phoneobj.model
        rs.Fields("price").Value = phoneobj.price
        rs.Fields("feature").Value = phoneobj.feature
        rs.Fields("builtDayName").Value = builtDateObj.dayName
        rs.Fields("builtDay").Value = builtDateObj.day
        rs.Fields("builtMonth").Value = builtDateObj.month
        rs.Fields("builtYear").Value = builtDateObj.year
        rs.Fields("soldDayName").Value = soldDateObj.dayName
        rs.Fields("soldDay").Value = soldDateObj.day
        rs.Fields("soldMonth").Value = soldDateObj.month
        rs.Fields("soldYear").Value = soldDateObj.year
        Call dateObj.ValidDate()
        MessageBox.Show("Data saved succesfully.")
    End Sub
    'showing Data from DB in form
    Public Sub ShowDataOnForm()
        'Transfer data from DB into class OBJ
        phoneobj.phoneID = rs.Fields("phoneID").Value
        phoneobj.make = rs.Fields("make").Value
        phoneobj.model = rs.Fields("model").Value
        phoneobj.price = rs.Fields("price").Value
        phoneobj.feature = rs.Fields("feature").Value
        builtDateObj.dayName = rs.Fields("builtDayName").Value
        builtDateObj.day = rs.Fields("builtDay").Value
        builtDateObj.month = rs.Fields("builtMonth").Value
        builtDateObj.year = rs.Fields("builtYear").Value
        soldDateObj.dayName = rs.Fields("soldDayName").Value
        soldDateObj.day = rs.Fields("soldDay").Value
        soldDateObj.month = rs.Fields("soldMonth").Value
        soldDateObj.year = rs.Fields("soldYear").Value
        'Transfer data in class object in text box to show
        TextBox1.Text = phoneobj.phoneID
        TextBox2.Text = phoneobj.make
        TextBox3.Text = phoneobj.model
        TextBox12.Text = phoneobj.price
        TextBox13.Text = phoneobj.feature
        TextBox4.Text = builtDateObj.dayName
        TextBox5.Text = builtDateObj.day
        TextBox6.Text = builtDateObj.month
        TextBox7.Text = builtDateObj.year
        TextBox8.Text = soldDateObj.dayName
        TextBox9.Text = soldDateObj.day
        TextBox10.Text = soldDateObj.month
        TextBox11.Text = soldDateObj.year

    End Sub
    'search in DB by phoneID
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Check for Table being empty 
        If rs.EOF = True And rs.BOF = True Then
            MessageBox.Show("Table is Empty")
            Exit Sub
        End If
        rs.MoveFirst()
        Dim Criteria As String
        Criteria = "phoneID = " + TextBox1.Text
        rs.Find(Criteria)
        If rs.EOF Then
            ' We did not find the record
            MessageBox.Show("record Not found !")
            Exit Sub
        Else
            'Found the record 
            ShowDataOnForm()
        End If
    End Sub
    'clear the form
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ClearForm()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.ElectronicShopTableAdapter.FillBy(Me.ElectronicShopDBDataSet.electronicShop)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
