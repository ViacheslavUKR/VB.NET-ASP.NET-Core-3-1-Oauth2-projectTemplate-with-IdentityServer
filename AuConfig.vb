Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports IdentityServer4.Models

Public Class AuConfig

    Public Shared Function GetAllApiResources() As IEnumerable(Of ApiResource)
        Return New List(Of ApiResource) From {
            New ApiResource("bankOfDotNetApi") 'type our own nameSpace there
        }
    End Function

    Public Shared Function GetAllClients() As IEnumerable(Of Client)
        Return New List(Of Client) From {
            New Client With {
                  .ClientId = "Login1",
                  .AllowedGrantTypes = GrantTypes.ClientCredentials,
                  .ClientSecrets =
                       {
                         New Secret("Password1".Sha256())
                       },
                  .AllowedScopes =
                       {
                         "bankOfDotNetApi" 'type our own nameSpace there
                       }
            }
        }
    End Function

End Class
