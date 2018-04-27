Public Class phoneClass
    'Step 1 in Class Variables 
    Private CphoneID As Integer
    Private Cmake As String
    Private Cmodel As String
    Private Cprice As Decimal
    Private Cfeature As String
    Private CbuiltDate As dateClass
    Private CsoldDate As dateClass
    'step 2 Creating a constructor 
    ' Constructor is a function that is run automatically 
    ' when an object is created 
    ' in VB the name of it is new 
    ' in all other languages the name of it is the same name as the class 
    'Public Sub New()
    '    CphoneID = 0
    '    Cmake = ""
    '    Cmodel = ""
    '    Cprice = 0
    '    Cfeature = ""
    '    CbuiltDate.dayName = ""
    '    CbuiltDate.month = 0
    '    CbuiltDate.day = 0
    '    CbuiltDate.year = 0
    '    CsoldDate.dayName = ""
    '    CsoldDate.month = 0
    '    CsoldDate.day = 0
    '    CsoldDate.year = 0
    'End Sub
    'Step 3 Creating Access Function ( properties)
    Public Property phoneID As Integer
        Get
            'when you want the outside world to know about the value of
            'this property 
            phoneID = CphoneID
        End Get
        Set(value As Integer)
            'when you want to put a value in this property from the world outside 
            CphoneID = value
        End Set
    End Property
    'Creating Access Function ( properties)
    Public Property make As String
        Get
            make = Cmake
        End Get
        Set(value As String)
            Cmake = value
        End Set
    End Property
    'Creating Access Function ( properties)
    Public Property model As String
        Get
            model = Cmodel
        End Get
        Set(value As String)
            Cmodel = value
        End Set
    End Property
    'Creating Access Function ( properties)
    Public Property price As Decimal
        Get
            price = Cprice
        End Get
        Set(value As Decimal)
            Cprice = value
        End Set
    End Property
    'Creating Access Function ( properties)
    Public Property feature As String
        Get
            feature = Cfeature
        End Get
        Set(value As String)
            Cfeature = value
        End Set
    End Property
    'Creating Access Function ( properties)
    Public Property builtDate As dateClass
        Get
            builtDate = CbuiltDate
        End Get
        Set(value As dateClass)
            CbuiltDate = value
        End Set
    End Property
    Public Property soldDate As dateClass
        Get
            soldDate = CsoldDate
        End Get
        Set(value As dateClass)
            CsoldDate = value
        End Set
    End Property
End Class
