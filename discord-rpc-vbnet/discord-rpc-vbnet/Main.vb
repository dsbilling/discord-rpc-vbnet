Imports System.Reflection
Imports System.IO

Public Class Main

    Public Shared APPLICATION_ID As String = "" ' CLASSIFIED
    Public Shared APP_Details As String = "Daniel is in Goldenrod City"
    Public Shared APP_State As String = "Playing Solo"
    Public Shared APP_LargeImageName As String = "goldenrod_city"
    Public Shared APP_LargeImageText As String = "Goldenrod City"
    Public Shared APP_SmallImageName As String = "logoxl"
    Public Shared APP_SmallImageText As String = "Pokémon 3D"

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Handlers As DiscordEventHandlers = New DiscordEventHandlers With {.Ready = AddressOf IsReady}

        Discord_Initialize(APPLICATION_ID, Handlers, 1, 0)

        Dim Presence As DiscordRichPresence = New DiscordRichPresence With {.Details = APP_Details, .State = APP_State, .LargeImageKey = APP_LargeImageName, .LargeImageText = APP_LargeImageText, .SmallImageKey = APP_SmallImageName, .SmallImageText = APP_SmallImageText}

        Discord_UpdatePresence(Presence)
    End Sub

    Public Shared Sub IsReady(ByRef Request As DiscordUser)
        Diagnostics.Debug.Print("Discord initialized successfully!")
    End Sub
End Class
