'Public Class CustomRoleProvider
'    Inherits RoleProvider

'    Public Overrides Sub AddUsersToRoles(usernames() As String, roleNames() As String)
'        Throw New NotImplementedException
'    End Sub

'    Private p_ApplicationName As String
'    Public Overrides Property ApplicationName As String
'        Get
'            Return Me.p_ApplicationName
'        End Get
'        Set(value As String)
'            Me.p_ApplicationName = value
'        End Set
'    End Property

'    Public Overrides Sub CreateRole(roleName As String)
'        Throw New NotImplementedException
'    End Sub

'    Public Overrides Function DeleteRole(roleName As String, throwOnPopulatedRole As Boolean) As Boolean
'        Throw New NotImplementedException
'    End Function

'    Public Overrides Function FindUsersInRole(roleName As String, usernameToMatch As String) As String()
'        Throw New NotImplementedException
'    End Function

'    Public Overrides Function GetAllRoles() As String()
'        Throw New NotImplementedException
'    End Function

'    Public Overrides Function GetRolesForUser(username As String) As String()
'        Dim roles As String() = Nothing
'        ReDim roles(1)
'        If username = "dperez" Then
'            roles(0) = "administrador"
'            roles(1) = "especialista"
'        Else
'            roles(0) = "normal"
'            roles(1) = "anonimo"
'        End If
'        Return roles
'    End Function

'    Public Overrides Function GetUsersInRole(roleName As String) As String()
'        Throw New NotImplementedException
'    End Function

'    Public Overrides Function IsUserInRole(username As String, roleName As String) As Boolean
'        Return True
'    End Function

'    Public Overrides Sub RemoveUsersFromRoles(usernames() As String, roleNames() As String)
'        Throw New NotImplementedException
'    End Sub

'    Public Overrides Function RoleExists(roleName As String) As Boolean
'        Throw New NotImplementedException
'    End Function
'End Class
