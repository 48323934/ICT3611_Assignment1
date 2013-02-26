Module GlobalVar
    ' My Global variables
    ' I have set a two dimensional array to access the room number, how many it sleeps and price per room
    ' I have on purpose displayed the array as below to easier grasp the row and column concept
    ' Still playing and testing with this
    ' These are constants therefore in the globalVar as Const arrays are not supported
    Public Rooms(,) As String = {{1, 220, "Room 101"},
                                  {2, 400, "Room 102"},
                                  {3, 580, "Room 103"},
                                  {4, 750, "Room 104"},
                                  {5, 1000, "Room 105"}}

    ' A Global transaction number variable as it will be used in various windows
    Public transaction As Integer = 1001

    ' Global variables for reporting on rooms and to check if room is occupied
    Public Room101 As Boolean = False
    Public Room102 As Boolean = False
    Public Room103 As Boolean = False
    Public Room104 As Boolean = False
    Public Room105 As Boolean = False

    '''''''' My Functions '''''''' Simple but functional
    ' Unpractical for this exercise but if this had to expand to a full blown program this could save a lot of coding
    Function addGuest(ByVal guest As Single) As Single
        guest = guest + 1
        Return guest

    End Function

    Function subtractGuest(ByVal guest As Single) As Single
        guest = guest - 1
        Return guest

    End Function

End Module
