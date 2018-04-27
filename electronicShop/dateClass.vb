Public Class dateClass
    'Step 1 in Class Variables 
    Private Cmonth As String
    Private Cday As Integer
    Private Cyear As Integer
    Private CdayName As String
    'step 2 Creating a constructor 
    Public Sub New()
        Cmonth = 0
        Cday = 0
        Cyear = 0
        CdayName = ""
    End Sub
    'Step 3 Creating Access Function ( properties)
    Public Property month As String
        Get
            'when you want the outside world to know about the value of
            'this property 
            month = Cmonth
        End Get
        Set(value As String)
            'when you want to put a value in this property from the world outside 
            Cmonth = value
        End Set
    End Property
    'Creating Access Function ( properties)
    Public Property day As Integer
        Get
            day = Cday
        End Get
        Set(value As Integer)
            Cday = value
        End Set
    End Property
    'Creating Access Function ( properties)
    Public Property year As Integer
        Get
            year = Cyear
        End Get
        Set(value As Integer)
            Cyear = value
        End Set
    End Property
    'Creating Access Function ( properties)
    Public Property dayName As String
        Get
            dayName = CdayName
        End Get
        Set(value As String)
            CdayName = value
        End Set
    End Property
    'function for checking validate of date
    Public Function ValidDate()
        If day <= 0 Or day > 31 Then
            MessageBox.Show("You need to insert a Day between 0 and 31")
            Return False
        End If

        If year < 2000 Or year > 2018 Then
            MessageBox.Show("You need to insert a Year between 2000 and 2017")
            Return False
        End If

        Return True

    End Function
End Class
