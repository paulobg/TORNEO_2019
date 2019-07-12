
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1


    Public CONEXION_SQL As MySqlConnection
    Dim RUTA_SQL As String = "server=localhost;user id=root;password=toor;database=torneo"

    Dim PUNTOS_G1(4) As Integer
    Dim GOLES_P1_G1 As Integer = 0
    Dim GOLES_P2_G1 As Integer = 0
    Dim GOLES_P3_G1 As Integer = 0


    Dim NOME_EQUIPOS_G1(4) As String

    Dim PUNTOS_G2(4) As Integer
    Dim GOLES_P1_G2 As Integer = 0
    Dim GOLES_P2_G2 As Integer = 0
    Dim GOLES_P3_G2 As Integer = 0

    Dim NOME_EQUIPOS_G2(4) As String

    Dim PUNTOS_G3(4) As Integer
    Dim GOLES_P1_G3 As Integer = 0
    Dim GOLES_P2_G3 As Integer = 0
    Dim GOLES_P3_G3 As Integer = 0

    Dim NOME_EQUIPOS_G3(4) As String

    Dim PUNTOS_G4(4) As Integer
    Dim GOLES_P1_G4 As Integer = 0
    Dim GOLES_P2_G4 As Integer = 0
    Dim GOLES_P3_G4 As Integer = 0

    Dim NOME_EQUIPOS_G4(4) As String


    Dim PUNTOS_G5(4) As Integer
    Dim GOLES_P1_G5 As Integer = 0
    Dim GOLES_P2_G5 As Integer = 0
    Dim GOLES_P3_G5 As Integer = 0

    Dim NOME_EQUIPOS_G5(4) As String

    Dim PUNTOS_G6(4) As Integer
    Dim GOLES_P1_G6 As Integer = 0
    Dim GOLES_P2_G6 As Integer = 0
    Dim GOLES_P3_G6 As Integer = 0

    Dim NOME_EQUIPOS_G6(4) As String


    Public ROW_SEL As Integer
    Public COL_SEL As Integer
    Public CARGAR_RESULTADOS_G2 As Boolean
    Public CARGAR_RESULTADOS_G1 As Boolean
    Public CARGAR_RESULTADOS_G3 As Boolean
    Public CARGAR_RESULTADOS_G4 As Boolean
    Public CARGAR_RESULTADOS_G5 As Boolean
    Public CARGAR_RESULTADOS_G6 As Boolean

    Dim ASCENDENTE As Boolean = True

    'Private dtView As DataView = Nothing




    ''''''''''''''''''''''''''FASE DE GRUPOS'''''''''''''''''''''''''''''''''

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DG_G1.RowCount = 4
        DG_G2.RowCount = 4
        DG_G3.RowCount = 4
        DG_G4.RowCount = 4
        DG_G5.RowCount = 4
        DG_G6.RowCount = 4
        DG_CLASIFICADOS.RowCount = 6
        DG_TERCEIROS.RowCount = 7
        DG_VER_TERCEIROS.RowCount = 6
        DG_TERCEIROS_CLAS.RowCount = 5

        CONECTAR_SQL()



    End Sub


    Function CONECTAR_SQL() As Boolean
        Try
            CONEXION_SQL = New MySqlConnection(RUTA_SQL)
            CONEXION_SQL.Open()
            CARGA_SQL()
            COLOREA_TABLA()
            LER_HORAS()

        Catch ex As Exception

        End Try
        Return True
    End Function


    Function CARGA_SQL() As Boolean


        'GRUPO 1
        Try
            Dim CONSULTA As String = "SELECT EQUIPO, PARTIDO1L, PARTIDO1V, PARTIDO2L, PARTIDO2V, PARTIDO3L, PARTIDO3V FROM GRUPO1 "
            Dim DATA_SET As New DataSet
            Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)

            COMANDO.ExecuteNonQuery()
            Dim ADAPTADOR As New MySqlDataAdapter(COMANDO)
            ADAPTADOR.Fill(DATA_SET)
            DG1.DataSource = DATA_SET.Tables(0)

            For I = 0 To DG1.RowCount - 2
                DG_G1.Rows(I).Cells(0).Value = DG1.Rows(I).Cells(0).Value
                NOME_EQUIPOS_G1(I) = DG1.Rows(I).Cells(0).Value

                PUNTOS_G1(I) = 0

                If DG1.Rows(I).Cells(1).Value >= 0 And DG1.Rows(I).Cells(2).Value >= 0 Then
                    DG_G1.Rows(I).Cells(1).Value = (DG1.Rows(I).Cells(1).Value & " - " & DG1.Rows(I).Cells(2).Value)
                    If DG1.Rows(I).Cells(1).Value > DG1.Rows(I).Cells(2).Value Then
                        PUNTOS_G1(I) = PUNTOS_G1(I) + 3
                    Else
                        If DG1.Rows(I).Cells(1).Value = DG1.Rows(I).Cells(2).Value Then
                            PUNTOS_G1(I) = PUNTOS_G1(I) + 1
                        End If
                    End If
                End If

                If DG1.Rows(I).Cells(3).Value >= 0 And DG1.Rows(I).Cells(4).Value >= 0 Then
                    DG_G1.Rows(I).Cells(2).Value = (DG1.Rows(I).Cells(3).Value & " - " & DG1.Rows(I).Cells(4).Value)
                    If DG1.Rows(I).Cells(3).Value > DG1.Rows(I).Cells(4).Value Then
                        PUNTOS_G1(I) = PUNTOS_G1(I) + 3
                    Else
                        If DG1.Rows(I).Cells(3).Value = DG1.Rows(I).Cells(4).Value Then
                            PUNTOS_G1(I) = PUNTOS_G1(I) + 1
                        End If
                    End If
                End If

                If DG1.Rows(I).Cells(5).Value >= 0 And DG1.Rows(I).Cells(6).Value >= 0 Then
                    DG_G1.Rows(I).Cells(3).Value = (DG1.Rows(I).Cells(5).Value & " - " & DG1.Rows(I).Cells(6).Value)
                    If DG1.Rows(I).Cells(5).Value > DG1.Rows(I).Cells(6).Value Then
                        PUNTOS_G1(I) = PUNTOS_G1(I) + 3
                    Else
                        If DG1.Rows(I).Cells(5).Value = DG1.Rows(I).Cells(6).Value Then
                            PUNTOS_G1(I) = PUNTOS_G1(I) + 1
                        End If
                    End If
                End If

                GOLES_P1_G1 = 0
                GOLES_P2_G1 = 0
                GOLES_P3_G1 = 0

                If DG1.Rows(I).Cells(1).Value >= 0 Then
                    GOLES_P1_G1 = DG1.Rows(I).Cells(1).Value
                Else
                    GOLES_P1_G1 = 0
                End If
                If DG1.Rows(I).Cells(3).Value >= 0 Then
                    GOLES_P2_G1 = DG1.Rows(I).Cells(3).Value
                Else
                    GOLES_P2_G1 = 0
                End If
                If DG1.Rows(I).Cells(5).Value >= 0 Then
                    GOLES_P3_G1 = DG1.Rows(I).Cells(5).Value
                Else
                    GOLES_P3_G1 = 0
                End If

                DG_G1.Rows(I).Cells(4).Value = (GOLES_P1_G1 + GOLES_P2_G1 + GOLES_P3_G1)

                GOLES_P1_G1 = 0
                GOLES_P2_G1 = 0
                GOLES_P3_G1 = 0

                If DG1.Rows(I).Cells(2).Value >= 0 Then
                    GOLES_P1_G1 = DG1.Rows(I).Cells(2).Value
                Else
                    GOLES_P1_G1 = 0
                End If
                If DG1.Rows(I).Cells(4).Value >= 0 Then
                    GOLES_P2_G1 = DG1.Rows(I).Cells(4).Value
                Else
                    GOLES_P2_G1 = 0
                End If
                If DG1.Rows(I).Cells(6).Value >= 0 Then
                    GOLES_P3_G1 = DG1.Rows(I).Cells(6).Value
                Else
                    GOLES_P3_G1 = 0
                End If

                DG_G1.Rows(I).Cells(5).Value = (GOLES_P1_G1 + GOLES_P2_G1 + GOLES_P3_G1)
                DG_G1.Rows(I).Cells(6).Value = DG_G1.Rows(I).Cells(4).Value - DG_G1.Rows(I).Cells(5).Value
                DG_G1.Rows(I).Cells(7).Value = PUNTOS_G1(I)

                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET GF=@GF, GC=@GC, DG=@DG, PTS=@PTS WHERE ID=@ID"
                Dim COMANDO2 As New MySqlCommand(CONSULTA2, CONEXION_SQL)
                COMANDO2.Parameters.Clear()
                COMANDO2.Parameters.AddWithValue("@GF", DG_G1.Rows(I).Cells(4).Value)
                COMANDO2.Parameters.AddWithValue("@GC", DG_G1.Rows(I).Cells(5).Value)
                COMANDO2.Parameters.AddWithValue("@DG", DG_G1.Rows(I).Cells(6).Value)
                COMANDO2.Parameters.AddWithValue("@PTS", DG_G1.Rows(I).Cells(7).Value)
                COMANDO2.Parameters.AddWithValue("@ID", I + 1)
                COMANDO2.ExecuteNonQuery()

            Next
        Catch ex As Exception
        End Try

        'GRUPO 2

        Try

                Dim CONSULT4 As String = "SELECT EQUIPO, PARTIDO1L, PARTIDO1V, PARTIDO2L, PARTIDO2V, PARTIDO3L, PARTIDO3V FROM GRUPO2 "
                Dim DATA_SET4 As New DataSet
                Dim COMANDO4 As New MySqlCommand(CONSULT4, CONEXION_SQL)

                COMANDO4.ExecuteNonQuery()
                Dim ADAPTADO4 As New MySqlDataAdapter(COMANDO4)
                ADAPTADO4.Fill(DATA_SET4)
                DG2.DataSource = DATA_SET4.Tables(0)

                For I = 0 To DG2.RowCount - 2
                    DG_G2.Rows(I).Cells(0).Value = DG2.Rows(I).Cells(0).Value
                    NOME_EQUIPOS_G2(I) = DG2.Rows(I).Cells(0).Value

                    PUNTOS_G2(I) = 0

                    If DG2.Rows(I).Cells(1).Value >= 0 And DG2.Rows(I).Cells(2).Value >= 0 Then
                        DG_G2.Rows(I).Cells(1).Value = (DG2.Rows(I).Cells(1).Value & " - " & DG2.Rows(I).Cells(2).Value)
                        If DG2.Rows(I).Cells(1).Value > DG2.Rows(I).Cells(2).Value Then
                            PUNTOS_G2(I) = PUNTOS_G2(I) + 3
                        Else
                            If DG2.Rows(I).Cells(1).Value = DG2.Rows(I).Cells(2).Value Then
                                PUNTOS_G2(I) = PUNTOS_G2(I) + 1
                            End If
                        End If
                    End If

                    If DG2.Rows(I).Cells(3).Value >= 0 And DG2.Rows(I).Cells(4).Value >= 0 Then
                        DG_G2.Rows(I).Cells(2).Value = (DG2.Rows(I).Cells(3).Value & " - " & DG2.Rows(I).Cells(4).Value)
                        If DG2.Rows(I).Cells(3).Value > DG2.Rows(I).Cells(4).Value Then
                            PUNTOS_G2(I) = PUNTOS_G2(I) + 3
                        Else
                            If DG2.Rows(I).Cells(3).Value = DG2.Rows(I).Cells(4).Value Then
                                PUNTOS_G2(I) = PUNTOS_G2(I) + 1
                            End If
                        End If
                    End If

                    If DG2.Rows(I).Cells(5).Value >= 0 And DG2.Rows(I).Cells(6).Value >= 0 Then
                        DG_G2.Rows(I).Cells(3).Value = (DG2.Rows(I).Cells(5).Value & " - " & DG2.Rows(I).Cells(6).Value)
                        If DG2.Rows(I).Cells(5).Value > DG2.Rows(I).Cells(6).Value Then
                            PUNTOS_G2(I) = PUNTOS_G2(I) + 3
                        Else
                            If DG2.Rows(I).Cells(5).Value = DG2.Rows(I).Cells(6).Value Then
                                PUNTOS_G2(I) = PUNTOS_G2(I) + 1
                            End If
                        End If
                    End If

                    GOLES_P1_G2 = 0
                    GOLES_P2_G2 = 0
                    GOLES_P3_G2 = 0

                    If DG2.Rows(I).Cells(1).Value >= 0 Then
                        GOLES_P1_G2 = DG2.Rows(I).Cells(1).Value
                    Else
                        GOLES_P1_G2 = 0
                    End If
                    If DG2.Rows(I).Cells(3).Value >= 0 Then
                        GOLES_P2_G2 = DG2.Rows(I).Cells(3).Value
                    Else
                        GOLES_P2_G2 = 0
                    End If
                    If DG2.Rows(I).Cells(5).Value >= 0 Then
                        GOLES_P3_G2 = DG2.Rows(I).Cells(5).Value
                    Else
                        GOLES_P3_G2 = 0
                    End If

                    DG_G2.Rows(I).Cells(4).Value = (GOLES_P1_G2 + GOLES_P2_G2 + GOLES_P3_G2)

                    GOLES_P1_G2 = 0
                    GOLES_P2_G2 = 0
                    GOLES_P3_G2 = 0

                    If DG2.Rows(I).Cells(2).Value >= 0 Then
                        GOLES_P1_G2 = DG2.Rows(I).Cells(2).Value
                    Else
                        GOLES_P1_G2 = 0
                    End If
                    If DG2.Rows(I).Cells(4).Value >= 0 Then
                        GOLES_P2_G2 = DG2.Rows(I).Cells(4).Value
                    Else
                        GOLES_P2_G2 = 0
                    End If
                    If DG2.Rows(I).Cells(6).Value >= 0 Then
                        GOLES_P3_G2 = DG2.Rows(I).Cells(6).Value
                    Else
                        GOLES_P3_G2 = 0
                    End If

                    DG_G2.Rows(I).Cells(5).Value = (GOLES_P1_G2 + GOLES_P2_G2 + GOLES_P3_G2)
                    DG_G2.Rows(I).Cells(6).Value = DG_G2.Rows(I).Cells(4).Value - DG_G2.Rows(I).Cells(5).Value
                    DG_G2.Rows(I).Cells(7).Value = PUNTOS_G2(I)

                    Dim CONSULTA5 As String = "UPDATE GRUPO2 SET GF=@GF, GC=@GC, DG=@DG, PTS=@PTS WHERE ID=@ID"
                    Dim COMANDO5 As New MySqlCommand(CONSULTA5, CONEXION_SQL)
                    COMANDO5.Parameters.Clear()
                    COMANDO5.Parameters.AddWithValue("@GF", DG_G2.Rows(I).Cells(4).Value)
                    COMANDO5.Parameters.AddWithValue("@GC", DG_G2.Rows(I).Cells(5).Value)
                    COMANDO5.Parameters.AddWithValue("@DG", DG_G2.Rows(I).Cells(6).Value)
                    COMANDO5.Parameters.AddWithValue("@PTS", DG_G2.Rows(I).Cells(7).Value)
                    COMANDO5.Parameters.AddWithValue("@ID", I + 1)
                    COMANDO5.ExecuteNonQuery()

                Next

            Catch ex As Exception
            End Try

        'GRUPO 3

        Try

                Dim CONSULTA6 As String = "SELECT EQUIPO, PARTIDO1L, PARTIDO1V, PARTIDO2L, PARTIDO2V, PARTIDO3L, PARTIDO3V FROM GRUPO3 "
                Dim DATA_SET6 As New DataSet
                Dim COMANDO6 As New MySqlCommand(CONSULTA6, CONEXION_SQL)

                COMANDO6.ExecuteNonQuery()
                Dim ADAPTADO6 As New MySqlDataAdapter(COMANDO6)
                ADAPTADO6.Fill(DATA_SET6)
                DG3.DataSource = DATA_SET6.Tables(0)

                For I = 0 To DG3.RowCount - 2
                    DG_G3.Rows(I).Cells(0).Value = DG3.Rows(I).Cells(0).Value
                    NOME_EQUIPOS_G3(I) = DG3.Rows(I).Cells(0).Value

                    PUNTOS_G3(I) = 0

                    If DG3.Rows(I).Cells(1).Value >= 0 And DG3.Rows(I).Cells(2).Value >= 0 Then
                        DG_G3.Rows(I).Cells(1).Value = (DG3.Rows(I).Cells(1).Value & " - " & DG3.Rows(I).Cells(2).Value)
                        If DG3.Rows(I).Cells(1).Value > DG3.Rows(I).Cells(2).Value Then
                            PUNTOS_G3(I) = PUNTOS_G3(I) + 3
                        Else
                            If DG3.Rows(I).Cells(1).Value = DG3.Rows(I).Cells(2).Value Then
                                PUNTOS_G3(I) = PUNTOS_G3(I) + 1
                            End If
                        End If
                    End If

                    If DG3.Rows(I).Cells(3).Value >= 0 And DG3.Rows(I).Cells(4).Value >= 0 Then
                        DG_G3.Rows(I).Cells(2).Value = (DG3.Rows(I).Cells(3).Value & " - " & DG3.Rows(I).Cells(4).Value)
                        If DG3.Rows(I).Cells(3).Value > DG3.Rows(I).Cells(4).Value Then
                            PUNTOS_G3(I) = PUNTOS_G3(I) + 3
                        Else
                            If DG3.Rows(I).Cells(3).Value = DG3.Rows(I).Cells(4).Value Then
                                PUNTOS_G3(I) = PUNTOS_G3(I) + 1
                            End If
                        End If
                    End If

                    If DG3.Rows(I).Cells(5).Value >= 0 And DG3.Rows(I).Cells(6).Value >= 0 Then
                        DG_G3.Rows(I).Cells(3).Value = (DG3.Rows(I).Cells(5).Value & " - " & DG3.Rows(I).Cells(6).Value)
                        If DG3.Rows(I).Cells(5).Value > DG3.Rows(I).Cells(6).Value Then
                            PUNTOS_G3(I) = PUNTOS_G3(I) + 3
                        Else
                            If DG3.Rows(I).Cells(5).Value = DG3.Rows(I).Cells(6).Value Then
                                PUNTOS_G3(I) = PUNTOS_G3(I) + 1
                            End If
                        End If
                    End If

                    GOLES_P1_G3 = 0
                    GOLES_P2_G3 = 0
                    GOLES_P3_G3 = 0

                    If DG3.Rows(I).Cells(1).Value >= 0 Then
                        GOLES_P1_G3 = DG3.Rows(I).Cells(1).Value
                    Else
                        GOLES_P1_G3 = 0
                    End If
                    If DG3.Rows(I).Cells(3).Value >= 0 Then
                        GOLES_P2_G3 = DG3.Rows(I).Cells(3).Value
                    Else
                        GOLES_P2_G3 = 0
                    End If
                    If DG3.Rows(I).Cells(5).Value >= 0 Then
                        GOLES_P3_G2 = DG3.Rows(I).Cells(5).Value
                    Else
                        GOLES_P3_G3 = 0
                    End If

                    DG_G3.Rows(I).Cells(4).Value = (GOLES_P1_G3 + GOLES_P2_G3 + GOLES_P3_G3)

                    GOLES_P1_G3 = 0
                    GOLES_P2_G3 = 0
                    GOLES_P3_G3 = 0

                    If DG3.Rows(I).Cells(2).Value >= 0 Then
                        GOLES_P1_G3 = DG3.Rows(I).Cells(2).Value
                    Else
                        GOLES_P1_G3 = 0
                    End If
                    If DG3.Rows(I).Cells(4).Value >= 0 Then
                        GOLES_P2_G2 = DG3.Rows(I).Cells(4).Value
                    Else
                        GOLES_P2_G3 = 0
                    End If
                    If DG3.Rows(I).Cells(6).Value >= 0 Then
                        GOLES_P3_G3 = DG3.Rows(I).Cells(6).Value
                    Else
                        GOLES_P3_G3 = 0
                    End If

                DG_G3.Rows(I).Cells(5).Value = (GOLES_P1_G3 + GOLES_P2_G3 + GOLES_P3_G3)
                DG_G3.Rows(I).Cells(6).Value = DG_G3.Rows(I).Cells(4).Value - DG_G3.Rows(I).Cells(5).Value
                    DG_G3.Rows(I).Cells(7).Value = PUNTOS_G3(I)

                    Dim CONSULTA7 As String = "UPDATE GRUPO3 SET GF=@GF, GC=@GC, DG=@DG, PTS=@PTS WHERE ID=@ID"
                    Dim COMANDO7 As New MySqlCommand(CONSULTA7, CONEXION_SQL)
                    COMANDO7.Parameters.Clear()
                    COMANDO7.Parameters.AddWithValue("@GF", DG_G3.Rows(I).Cells(4).Value)
                    COMANDO7.Parameters.AddWithValue("@GC", DG_G3.Rows(I).Cells(5).Value)
                    COMANDO7.Parameters.AddWithValue("@DG", DG_G3.Rows(I).Cells(6).Value)
                    COMANDO7.Parameters.AddWithValue("@PTS", DG_G3.Rows(I).Cells(7).Value)
                    COMANDO7.Parameters.AddWithValue("@ID", I + 1)
                    COMANDO7.ExecuteNonQuery()

                Next



            Catch ex As Exception
            End Try

        'GRUPO 4

        Try

                Dim CONSULTA8 As String = "SELECT EQUIPO, PARTIDO1L, PARTIDO1V, PARTIDO2L, PARTIDO2V, PARTIDO3L, PARTIDO3V FROM GRUPO4 "
                Dim DATA_SET8 As New DataSet
                Dim COMANDO8 As New MySqlCommand(CONSULTA8, CONEXION_SQL)

                COMANDO8.ExecuteNonQuery()
                Dim ADAPTADO8 As New MySqlDataAdapter(COMANDO8)
                ADAPTADO8.Fill(DATA_SET8)
                DG4.DataSource = DATA_SET8.Tables(0)

                For I = 0 To DG4.RowCount - 2
                    DG_G4.Rows(I).Cells(0).Value = DG4.Rows(I).Cells(0).Value
                    NOME_EQUIPOS_G4(I) = DG4.Rows(I).Cells(0).Value

                    PUNTOS_G4(I) = 0

                    If DG4.Rows(I).Cells(1).Value >= 0 And DG4.Rows(I).Cells(2).Value >= 0 Then
                        DG_G4.Rows(I).Cells(1).Value = (DG4.Rows(I).Cells(1).Value & " - " & DG4.Rows(I).Cells(2).Value)
                        If DG4.Rows(I).Cells(1).Value > DG4.Rows(I).Cells(2).Value Then
                            PUNTOS_G4(I) = PUNTOS_G4(I) + 3
                        Else
                            If DG4.Rows(I).Cells(1).Value = DG4.Rows(I).Cells(2).Value Then
                                PUNTOS_G4(I) = PUNTOS_G4(I) + 1
                            End If
                        End If
                    End If

                    If DG4.Rows(I).Cells(3).Value >= 0 And DG4.Rows(I).Cells(4).Value >= 0 Then
                        DG_G4.Rows(I).Cells(2).Value = (DG4.Rows(I).Cells(3).Value & " - " & DG4.Rows(I).Cells(4).Value)
                        If DG4.Rows(I).Cells(3).Value > DG4.Rows(I).Cells(4).Value Then
                            PUNTOS_G4(I) = PUNTOS_G4(I) + 3
                        Else
                            If DG4.Rows(I).Cells(3).Value = DG4.Rows(I).Cells(4).Value Then
                                PUNTOS_G4(I) = PUNTOS_G4(I) + 1
                            End If
                        End If
                    End If

                    If DG4.Rows(I).Cells(5).Value >= 0 And DG4.Rows(I).Cells(6).Value >= 0 Then
                        DG_G4.Rows(I).Cells(3).Value = (DG4.Rows(I).Cells(5).Value & " - " & DG4.Rows(I).Cells(6).Value)
                        If DG4.Rows(I).Cells(5).Value > DG4.Rows(I).Cells(6).Value Then
                            PUNTOS_G4(I) = PUNTOS_G4(I) + 3
                        Else
                            If DG4.Rows(I).Cells(5).Value = DG4.Rows(I).Cells(6).Value Then
                                PUNTOS_G4(I) = PUNTOS_G4(I) + 1
                            End If
                        End If
                    End If

                    GOLES_P1_G4 = 0
                    GOLES_P2_G4 = 0
                    GOLES_P3_G4 = 0

                    If DG4.Rows(I).Cells(1).Value >= 0 Then
                        GOLES_P1_G4 = DG4.Rows(I).Cells(1).Value
                    Else
                        GOLES_P1_G4 = 0
                    End If
                    If DG4.Rows(I).Cells(3).Value >= 0 Then
                        GOLES_P2_G4 = DG4.Rows(I).Cells(3).Value
                    Else
                        GOLES_P2_G4 = 0
                    End If
                    If DG4.Rows(I).Cells(5).Value >= 0 Then
                        GOLES_P3_G4 = DG4.Rows(I).Cells(5).Value
                    Else
                        GOLES_P3_G4 = 0
                    End If

                    DG_G4.Rows(I).Cells(4).Value = (GOLES_P1_G4 + GOLES_P2_G4 + GOLES_P3_G4)

                    GOLES_P1_G4 = 0
                    GOLES_P2_G4 = 0
                    GOLES_P3_G4 = 0

                    If DG4.Rows(I).Cells(2).Value >= 0 Then
                        GOLES_P1_G4 = DG4.Rows(I).Cells(2).Value
                    Else
                        GOLES_P1_G4 = 0
                    End If
                    If DG4.Rows(I).Cells(4).Value >= 0 Then
                        GOLES_P2_G4 = DG4.Rows(I).Cells(4).Value
                    Else
                        GOLES_P2_G4 = 0
                    End If
                    If DG4.Rows(I).Cells(6).Value >= 0 Then
                        GOLES_P3_G4 = DG4.Rows(I).Cells(6).Value
                    Else
                        GOLES_P3_G4 = 0
                    End If

                    DG_G4.Rows(I).Cells(5).Value = (GOLES_P1_G4 + GOLES_P2_G4 + GOLES_P3_G4)
                    DG_G4.Rows(I).Cells(6).Value = DG_G4.Rows(I).Cells(4).Value - DG_G4.Rows(I).Cells(5).Value
                    DG_G4.Rows(I).Cells(7).Value = PUNTOS_G4(I)

                    Dim CONSULTA9 As String = "UPDATE GRUPO4 SET GF=@GF, GC=@GC, DG=@DG, PTS=@PTS WHERE ID=@ID"
                    Dim COMANDO9 As New MySqlCommand(CONSULTA8, CONEXION_SQL)
                COMANDO9.Parameters.Clear()
                COMANDO9.Parameters.AddWithValue("@GF", DG_G4.Rows(I).Cells(4).Value)
                COMANDO9.Parameters.AddWithValue("@GC", DG_G4.Rows(I).Cells(5).Value)
                COMANDO9.Parameters.AddWithValue("@DG", DG_G4.Rows(I).Cells(6).Value)
                COMANDO9.Parameters.AddWithValue("@PTS", DG_G4.Rows(I).Cells(7).Value)
                COMANDO9.Parameters.AddWithValue("@ID", I + 1)
                COMANDO9.ExecuteNonQuery()

            Next



            Catch ex As Exception
            End Try

        'GRUPO 5

        Try

                Dim CONSULTA10 As String = "SELECT EQUIPO, PARTIDO1L, PARTIDO1V, PARTIDO2L, PARTIDO2V, PARTIDO3L, PARTIDO3V FROM GRUPO5 "
                Dim DATA_SET10 As New DataSet
                Dim COMANDO10 As New MySqlCommand(CONSULTA10, CONEXION_SQL)

                COMANDO10.ExecuteNonQuery()
                Dim ADAPTADO10 As New MySqlDataAdapter(COMANDO10)
                ADAPTADO10.Fill(DATA_SET10)
                DG5.DataSource = DATA_SET10.Tables(0)

                For I = 0 To DG5.RowCount - 2
                    DG_G5.Rows(I).Cells(0).Value = DG5.Rows(I).Cells(0).Value
                    NOME_EQUIPOS_G5(I) = DG5.Rows(I).Cells(0).Value

                    PUNTOS_G5(I) = 0

                    If DG5.Rows(I).Cells(1).Value >= 0 And DG5.Rows(I).Cells(2).Value >= 0 Then
                        DG_G5.Rows(I).Cells(1).Value = (DG5.Rows(I).Cells(1).Value & " - " & DG5.Rows(I).Cells(2).Value)
                        If DG5.Rows(I).Cells(1).Value > DG5.Rows(I).Cells(2).Value Then
                            PUNTOS_G5(I) = PUNTOS_G5(I) + 3
                        Else
                            If DG5.Rows(I).Cells(1).Value = DG5.Rows(I).Cells(2).Value Then
                                PUNTOS_G5(I) = PUNTOS_G5(I) + 1
                            End If
                        End If
                    End If

                    If DG5.Rows(I).Cells(3).Value >= 0 And DG5.Rows(I).Cells(4).Value >= 0 Then
                        DG_G5.Rows(I).Cells(2).Value = (DG5.Rows(I).Cells(3).Value & " - " & DG5.Rows(I).Cells(4).Value)
                        If DG5.Rows(I).Cells(3).Value > DG5.Rows(I).Cells(4).Value Then
                            PUNTOS_G5(I) = PUNTOS_G5(I) + 3
                        Else
                            If DG5.Rows(I).Cells(3).Value = DG5.Rows(I).Cells(4).Value Then
                                PUNTOS_G5(I) = PUNTOS_G5(I) + 1
                            End If
                        End If
                    End If

                    If DG5.Rows(I).Cells(5).Value >= 0 And DG5.Rows(I).Cells(6).Value >= 0 Then
                        DG_G5.Rows(I).Cells(3).Value = (DG5.Rows(I).Cells(5).Value & " - " & DG5.Rows(I).Cells(6).Value)
                        If DG5.Rows(I).Cells(5).Value > DG5.Rows(I).Cells(6).Value Then
                            PUNTOS_G5(I) = PUNTOS_G5(I) + 3
                        Else
                            If DG5.Rows(I).Cells(5).Value = DG5.Rows(I).Cells(6).Value Then
                                PUNTOS_G5(I) = PUNTOS_G5(I) + 1
                            End If
                        End If
                    End If

                    GOLES_P1_G5 = 0
                    GOLES_P2_G5 = 0
                    GOLES_P3_G5 = 0

                    If DG5.Rows(I).Cells(1).Value >= 0 Then
                        GOLES_P1_G5 = DG5.Rows(I).Cells(1).Value
                    Else
                        GOLES_P1_G5 = 0
                    End If
                    If DG5.Rows(I).Cells(3).Value >= 0 Then
                        GOLES_P2_G5 = DG5.Rows(I).Cells(3).Value
                    Else
                        GOLES_P2_G5 = 0
                    End If
                    If DG5.Rows(I).Cells(5).Value >= 0 Then
                        GOLES_P3_G5 = DG5.Rows(I).Cells(5).Value
                    Else
                        GOLES_P3_G5 = 0
                    End If

                    DG_G5.Rows(I).Cells(4).Value = (GOLES_P1_G5 + GOLES_P2_G5 + GOLES_P3_G5)

                    GOLES_P1_G5 = 0
                    GOLES_P2_G5 = 0
                    GOLES_P3_G5 = 0

                    If DG5.Rows(I).Cells(2).Value >= 0 Then
                        GOLES_P1_G5 = DG5.Rows(I).Cells(2).Value
                    Else
                        GOLES_P1_G5 = 0
                    End If
                    If DG5.Rows(I).Cells(4).Value >= 0 Then
                        GOLES_P2_G5 = DG5.Rows(I).Cells(4).Value
                    Else
                        GOLES_P2_G5 = 0
                    End If
                    If DG5.Rows(I).Cells(6).Value >= 0 Then
                        GOLES_P3_G5 = DG5.Rows(I).Cells(6).Value
                    Else
                        GOLES_P3_G5 = 0
                    End If

                    DG_G5.Rows(I).Cells(5).Value = (GOLES_P1_G5 + GOLES_P2_G5 + GOLES_P3_G5)
                    DG_G5.Rows(I).Cells(6).Value = DG_G5.Rows(I).Cells(4).Value - DG_G5.Rows(I).Cells(5).Value
                    DG_G5.Rows(I).Cells(7).Value = PUNTOS_G5(I)

                    Dim CONSULTA11 As String = "UPDATE GRUPO5 SET GF=@GF, GC=@GC, DG=@DG, PTS=@PTS WHERE ID=@ID"
                    Dim COMANDO11 As New MySqlCommand(CONSULTA11, CONEXION_SQL)
                COMANDO11.Parameters.Clear()
                COMANDO11.Parameters.AddWithValue("@GF", DG_G5.Rows(I).Cells(4).Value)
                COMANDO11.Parameters.AddWithValue("@GC", DG_G5.Rows(I).Cells(5).Value)
                COMANDO11.Parameters.AddWithValue("@DG", DG_G5.Rows(I).Cells(6).Value)
                COMANDO11.Parameters.AddWithValue("@PTS", DG_G5.Rows(I).Cells(7).Value)
                COMANDO11.Parameters.AddWithValue("@ID", I + 1)
                COMANDO11.ExecuteNonQuery()

            Next

            Catch ex As Exception
            End Try

        'GRUPO 6

        Try
                Dim CONSULTA12 As String = "SELECT EQUIPO, PARTIDO1L, PARTIDO1V, PARTIDO2L, PARTIDO2V, PARTIDO3L, PARTIDO3V FROM GRUPO6 "
                Dim DATA_SET12 As New DataSet
                Dim COMANDO12 As New MySqlCommand(CONSULTA12, CONEXION_SQL)

                COMANDO12.ExecuteNonQuery()
                Dim ADAPTADO12 As New MySqlDataAdapter(COMANDO12)
                ADAPTADO12.Fill(DATA_SET12)
                DG6.DataSource = DATA_SET12.Tables(0)

                For I = 0 To DG6.RowCount - 2
                    DG_G6.Rows(I).Cells(0).Value = DG6.Rows(I).Cells(0).Value
                    NOME_EQUIPOS_G6(I) = DG6.Rows(I).Cells(0).Value

                    PUNTOS_G6(I) = 0

                    If DG6.Rows(I).Cells(1).Value >= 0 And DG6.Rows(I).Cells(2).Value >= 0 Then
                        DG_G6.Rows(I).Cells(1).Value = (DG6.Rows(I).Cells(1).Value & " - " & DG6.Rows(I).Cells(2).Value)
                        If DG6.Rows(I).Cells(1).Value > DG6.Rows(I).Cells(2).Value Then
                            PUNTOS_G6(I) = PUNTOS_G6(I) + 3
                        Else
                            If DG6.Rows(I).Cells(1).Value = DG6.Rows(I).Cells(2).Value Then
                                PUNTOS_G6(I) = PUNTOS_G6(I) + 1
                            End If
                        End If
                    End If

                    If DG6.Rows(I).Cells(3).Value >= 0 And DG6.Rows(I).Cells(4).Value >= 0 Then
                        DG_G6.Rows(I).Cells(2).Value = (DG6.Rows(I).Cells(3).Value & " - " & DG6.Rows(I).Cells(4).Value)
                        If DG6.Rows(I).Cells(3).Value > DG6.Rows(I).Cells(4).Value Then
                            PUNTOS_G6(I) = PUNTOS_G6(I) + 3
                        Else
                            If DG6.Rows(I).Cells(3).Value = DG6.Rows(I).Cells(4).Value Then
                                PUNTOS_G6(I) = PUNTOS_G6(I) + 1
                            End If
                        End If
                    End If

                    If DG6.Rows(I).Cells(5).Value >= 0 And DG6.Rows(I).Cells(6).Value >= 0 Then
                        DG_G6.Rows(I).Cells(3).Value = (DG6.Rows(I).Cells(5).Value & " - " & DG6.Rows(I).Cells(6).Value)
                        If DG6.Rows(I).Cells(5).Value > DG6.Rows(I).Cells(6).Value Then
                            PUNTOS_G6(I) = PUNTOS_G6(I) + 3
                        Else
                            If DG6.Rows(I).Cells(5).Value = DG6.Rows(I).Cells(6).Value Then
                                PUNTOS_G6(I) = PUNTOS_G6(I) + 1
                            End If
                        End If
                    End If

                    GOLES_P1_G6 = 0
                    GOLES_P2_G6 = 0
                    GOLES_P3_G6 = 0

                    If DG6.Rows(I).Cells(1).Value >= 0 Then
                        GOLES_P1_G6 = DG6.Rows(I).Cells(1).Value
                    Else
                        GOLES_P1_G6 = 0
                    End If
                    If DG6.Rows(I).Cells(3).Value >= 0 Then
                        GOLES_P2_G6 = DG6.Rows(I).Cells(3).Value
                    Else
                        GOLES_P2_G6 = 0
                    End If
                    If DG6.Rows(I).Cells(5).Value >= 0 Then
                        GOLES_P3_G6 = DG6.Rows(I).Cells(5).Value
                    Else
                        GOLES_P3_G6 = 0
                    End If

                    DG_G6.Rows(I).Cells(4).Value = (GOLES_P1_G6 + GOLES_P2_G6 + GOLES_P3_G6)

                    GOLES_P1_G6 = 0
                    GOLES_P2_G6 = 0
                    GOLES_P3_G6 = 0

                    If DG6.Rows(I).Cells(2).Value >= 0 Then
                        GOLES_P1_G6 = DG6.Rows(I).Cells(2).Value
                    Else
                        GOLES_P1_G6 = 0
                    End If
                    If DG6.Rows(I).Cells(4).Value >= 0 Then
                        GOLES_P2_G6 = DG6.Rows(I).Cells(4).Value
                    Else
                        GOLES_P2_G6 = 0
                    End If
                    If DG6.Rows(I).Cells(6).Value >= 0 Then
                        GOLES_P3_G6 = DG6.Rows(I).Cells(6).Value
                    Else
                        GOLES_P3_G6 = 0
                    End If

                    DG_G6.Rows(I).Cells(5).Value = (GOLES_P1_G6 + GOLES_P2_G6 + GOLES_P3_G6)
                    DG_G6.Rows(I).Cells(6).Value = DG_G6.Rows(I).Cells(4).Value - DG_G6.Rows(I).Cells(5).Value
                    DG_G6.Rows(I).Cells(7).Value = PUNTOS_G6(I)

                    Dim CONSULTA13 As String = "UPDATE GRUPO6 SET GF=@GF, GC=@GC, DG=@DG, PTS=@PTS WHERE ID=@ID"
                    Dim COMANDO13 As New MySqlCommand(CONSULTA13, CONEXION_SQL)
                COMANDO13.Parameters.Clear()
                COMANDO13.Parameters.AddWithValue("@GF", DG_G6.Rows(I).Cells(4).Value)
                COMANDO13.Parameters.AddWithValue("@GC", DG_G6.Rows(I).Cells(5).Value)
                COMANDO13.Parameters.AddWithValue("@DG", DG_G6.Rows(I).Cells(6).Value)
                COMANDO13.Parameters.AddWithValue("@PTS", DG_G6.Rows(I).Cells(7).Value)
                COMANDO13.Parameters.AddWithValue("@ID", I + 1)
                COMANDO13.ExecuteNonQuery()

            Next

            Catch ex As Exception
            End Try

        'CARGAR DATOS A TABLA DE PARTIDO
        Try
                Dim CONSULTA14 As String = "SELECT  PARTIDO1L, PARTIDO2L, PARTIDO3L FROM GRUPO1 "
                Dim DATA_SET14 As New DataSet
                Dim COMANDO14 As New MySqlCommand(CONSULTA14, CONEXION_SQL)

                COMANDO14.ExecuteNonQuery()
                Dim ADAPTADOR14 As New MySqlDataAdapter(COMANDO14)
                ADAPTADOR14.Fill(DATA_SET14)
                DGPARTIDO1.DataSource = DATA_SET14.Tables(0)




                Dim CONSULTA15 As String = "SELECT  PARTIDO1L, PARTIDO2L, PARTIDO3L FROM GRUPO2 "
                Dim DATA_SET15 As New DataSet
                Dim COMANDO15 As New MySqlCommand(CONSULTA15, CONEXION_SQL)

                COMANDO15.ExecuteNonQuery()
                Dim ADAPTADOR15 As New MySqlDataAdapter(COMANDO15)
                ADAPTADOR15.Fill(DATA_SET15)
                DGPARTIDO2.DataSource = DATA_SET15.Tables(0)


                Dim CONSULTA16 As String = "SELECT  PARTIDO1L, PARTIDO2L, PARTIDO3L FROM GRUPO3 "
                Dim DATA_SET16 As New DataSet
                Dim COMANDO16 As New MySqlCommand(CONSULTA16, CONEXION_SQL)

                COMANDO16.ExecuteNonQuery()
                Dim ADAPTADOR16 As New MySqlDataAdapter(COMANDO16)
                ADAPTADOR16.Fill(DATA_SET16)
                DGPARTIDO3.DataSource = DATA_SET16.Tables(0)


                Dim CONSULTA17 As String = "SELECT  PARTIDO1L, PARTIDO2L, PARTIDO3L FROM GRUPO4 "
                Dim DATA_SET17 As New DataSet
                Dim COMANDO17 As New MySqlCommand(CONSULTA17, CONEXION_SQL)

                COMANDO17.ExecuteNonQuery()
                Dim ADAPTADOR17 As New MySqlDataAdapter(COMANDO17)
                ADAPTADOR17.Fill(DATA_SET17)
                DGPARTIDO4.DataSource = DATA_SET17.Tables(0)


                Dim CONSULTA18 As String = "SELECT  PARTIDO1L, PARTIDO2L, PARTIDO3L FROM GRUPO5 "
                Dim DATA_SET18 As New DataSet
                Dim COMANDO18 As New MySqlCommand(CONSULTA18, CONEXION_SQL)

                COMANDO18.ExecuteNonQuery()
                Dim ADAPTADOR18 As New MySqlDataAdapter(COMANDO18)
                ADAPTADOR18.Fill(DATA_SET18)
                DGPARTIDO5.DataSource = DATA_SET18.Tables(0)


                Dim CONSULTA19 As String = "SELECT  PARTIDO1L, PARTIDO2L, PARTIDO3L FROM GRUPO6 "
                Dim DATA_SET19 As New DataSet
                Dim COMANDO19 As New MySqlCommand(CONSULTA19, CONEXION_SQL)

                COMANDO19.ExecuteNonQuery()
                Dim ADAPTADOR19 As New MySqlDataAdapter(COMANDO19)
            ADAPTADOR19.Fill(DATA_SET19)
            DGPARTIDO6.DataSource = DATA_SET19.Tables(0)

        Catch ex As Exception
            End Try


        Try
            CLASIFICAR()
        Catch ex As Exception
            MessageBox.Show("FALLO CLASIFICAR")
        End Try


        Return True
    End Function

    ''''''''''''''''''colorear tabla''''''''''''''''
    Function COLOREA_TABLA() As Boolean
        Try

            'G1
            DG_G1.Rows(0).Cells(0).Style.BackColor = Color.Azure
            DG_G1.Rows(1).Cells(0).Style.BackColor = Color.Azure
            DG_G1.Rows(2).Cells(0).Style.BackColor = Color.Azure
            DG_G1.Rows(3).Cells(0).Style.BackColor = Color.Azure

            G1_C2.HeaderCell.Style.BackColor = Color.Bisque
            G1_C3.HeaderCell.Style.BackColor = Color.Bisque
            G1_C4.HeaderCell.Style.BackColor = Color.Bisque
            G1_C5.HeaderCell.Style.BackColor = Color.Bisque
            G1_C6.HeaderCell.Style.BackColor = Color.Bisque
            G1_C7.HeaderCell.Style.BackColor = Color.Bisque
            G1_C8.HeaderCell.Style.BackColor = Color.Bisque
            G1_C9.HeaderCell.Style.BackColor = Color.Bisque

            'marcar resultados de partidos iguales
            DG_G1.Rows(0).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G1.Rows(1).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G1.Rows(2).Cells(1).Style.BackColor = Color.CornflowerBlue
            DG_G1.Rows(3).Cells(1).Style.BackColor = Color.CornflowerBlue

            DG_G1.Rows(0).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G1.Rows(2).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G1.Rows(1).Cells(2).Style.BackColor = Color.Cornsilk
            DG_G1.Rows(3).Cells(2).Style.BackColor = Color.Cornsilk

            DG_G1.Rows(0).Cells(3).Style.BackColor = Color.CadetBlue
            DG_G1.Rows(3).Cells(3).Style.BackColor = Color.CadetBlue


            DG_G1.Rows(1).Cells(3).Style.BackColor = Color.Thistle
            DG_G1.Rows(2).Cells(3).Style.BackColor = Color.Thistle

            'G2
            DG_G2.Rows(0).Cells(0).Style.BackColor = Color.Azure
            DG_G2.Rows(1).Cells(0).Style.BackColor = Color.Azure
            DG_G2.Rows(2).Cells(0).Style.BackColor = Color.Azure
            DG_G2.Rows(3).Cells(0).Style.BackColor = Color.Azure

            G2_C2.HeaderCell.Style.BackColor = Color.Bisque
            G2_C3.HeaderCell.Style.BackColor = Color.Bisque
            G2_C4.HeaderCell.Style.BackColor = Color.Bisque
            G2_C5.HeaderCell.Style.BackColor = Color.Bisque
            G2_C6.HeaderCell.Style.BackColor = Color.Bisque
            G2_C7.HeaderCell.Style.BackColor = Color.Bisque
            G2_C8.HeaderCell.Style.BackColor = Color.Bisque
            G2_C9.HeaderCell.Style.BackColor = Color.Bisque

            'marcar resultados de partidos iguales
            DG_G2.Rows(0).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G2.Rows(1).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G2.Rows(2).Cells(1).Style.BackColor = Color.CornflowerBlue
            DG_G2.Rows(3).Cells(1).Style.BackColor = Color.CornflowerBlue

            DG_G2.Rows(0).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G2.Rows(2).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G2.Rows(1).Cells(2).Style.BackColor = Color.Cornsilk
            DG_G2.Rows(3).Cells(2).Style.BackColor = Color.Cornsilk

            DG_G2.Rows(0).Cells(3).Style.BackColor = Color.CadetBlue
            DG_G2.Rows(3).Cells(3).Style.BackColor = Color.CadetBlue


            DG_G2.Rows(1).Cells(3).Style.BackColor = Color.Thistle
            DG_G2.Rows(2).Cells(3).Style.BackColor = Color.Thistle


            'G3
            DG_G3.Rows(0).Cells(0).Style.BackColor = Color.Azure
            DG_G3.Rows(1).Cells(0).Style.BackColor = Color.Azure
            DG_G3.Rows(2).Cells(0).Style.BackColor = Color.Azure
            DG_G3.Rows(3).Cells(0).Style.BackColor = Color.Azure

            G3_C2.HeaderCell.Style.BackColor = Color.Bisque
            G3_C3.HeaderCell.Style.BackColor = Color.Bisque
            G3_C4.HeaderCell.Style.BackColor = Color.Bisque
            G3_C5.HeaderCell.Style.BackColor = Color.Bisque
            G3_C6.HeaderCell.Style.BackColor = Color.Bisque
            G3_C7.HeaderCell.Style.BackColor = Color.Bisque
            G3_C8.HeaderCell.Style.BackColor = Color.Bisque
            G3_C9.HeaderCell.Style.BackColor = Color.Bisque

            'marcar resultados de partidos iguales
            DG_G3.Rows(0).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G3.Rows(1).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G3.Rows(2).Cells(1).Style.BackColor = Color.CornflowerBlue
            DG_G3.Rows(3).Cells(1).Style.BackColor = Color.CornflowerBlue

            DG_G3.Rows(0).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G3.Rows(2).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G3.Rows(1).Cells(2).Style.BackColor = Color.Cornsilk
            DG_G3.Rows(3).Cells(2).Style.BackColor = Color.Cornsilk

            DG_G3.Rows(0).Cells(3).Style.BackColor = Color.CadetBlue
            DG_G3.Rows(3).Cells(3).Style.BackColor = Color.CadetBlue


            DG_G3.Rows(1).Cells(3).Style.BackColor = Color.Thistle
            DG_G3.Rows(2).Cells(3).Style.BackColor = Color.Thistle



            'G4
            DG_G4.Rows(0).Cells(0).Style.BackColor = Color.Azure
            DG_G4.Rows(1).Cells(0).Style.BackColor = Color.Azure
            DG_G4.Rows(2).Cells(0).Style.BackColor = Color.Azure
            DG_G4.Rows(3).Cells(0).Style.BackColor = Color.Azure

            G4_C2.HeaderCell.Style.BackColor = Color.Bisque
            G4_C3.HeaderCell.Style.BackColor = Color.Bisque
            G4_C4.HeaderCell.Style.BackColor = Color.Bisque
            G4_C5.HeaderCell.Style.BackColor = Color.Bisque
            G4_C6.HeaderCell.Style.BackColor = Color.Bisque
            G4_C7.HeaderCell.Style.BackColor = Color.Bisque
            G4_C8.HeaderCell.Style.BackColor = Color.Bisque
            G4_C9.HeaderCell.Style.BackColor = Color.Bisque

            'marcar resultados de partidos iguales
            DG_G4.Rows(0).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G4.Rows(1).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G4.Rows(2).Cells(1).Style.BackColor = Color.CornflowerBlue
            DG_G4.Rows(3).Cells(1).Style.BackColor = Color.CornflowerBlue

            DG_G4.Rows(0).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G4.Rows(2).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G4.Rows(1).Cells(2).Style.BackColor = Color.Cornsilk
            DG_G4.Rows(3).Cells(2).Style.BackColor = Color.Cornsilk

            DG_G4.Rows(0).Cells(3).Style.BackColor = Color.CadetBlue
            DG_G4.Rows(3).Cells(3).Style.BackColor = Color.CadetBlue


            DG_G4.Rows(1).Cells(3).Style.BackColor = Color.Thistle
            DG_G4.Rows(2).Cells(3).Style.BackColor = Color.Thistle




            'G5

            DG_G5.Rows(0).Cells(0).Style.BackColor = Color.Azure
            DG_G5.Rows(1).Cells(0).Style.BackColor = Color.Azure
            DG_G5.Rows(2).Cells(0).Style.BackColor = Color.Azure
            DG_G5.Rows(3).Cells(0).Style.BackColor = Color.Azure

            G5_C2.HeaderCell.Style.BackColor = Color.Bisque
            G5_C3.HeaderCell.Style.BackColor = Color.Bisque
            G5_C4.HeaderCell.Style.BackColor = Color.Bisque
            G5_C5.HeaderCell.Style.BackColor = Color.Bisque
            G5_C6.HeaderCell.Style.BackColor = Color.Bisque
            G5_C7.HeaderCell.Style.BackColor = Color.Bisque
            G5_C8.HeaderCell.Style.BackColor = Color.Bisque
            G5_C9.HeaderCell.Style.BackColor = Color.Bisque

            'marcar resultados de partidos iguales
            DG_G5.Rows(0).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G5.Rows(1).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G5.Rows(2).Cells(1).Style.BackColor = Color.CornflowerBlue
            DG_G5.Rows(3).Cells(1).Style.BackColor = Color.CornflowerBlue

            DG_G5.Rows(0).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G5.Rows(2).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G5.Rows(1).Cells(2).Style.BackColor = Color.Cornsilk
            DG_G5.Rows(3).Cells(2).Style.BackColor = Color.Cornsilk

            DG_G5.Rows(0).Cells(3).Style.BackColor = Color.CadetBlue
            DG_G5.Rows(3).Cells(3).Style.BackColor = Color.CadetBlue


            DG_G5.Rows(1).Cells(3).Style.BackColor = Color.Thistle
            DG_G5.Rows(2).Cells(3).Style.BackColor = Color.Thistle




            'G6

            DG_G6.Rows(0).Cells(0).Style.BackColor = Color.Azure
            DG_G6.Rows(1).Cells(0).Style.BackColor = Color.Azure
            DG_G6.Rows(2).Cells(0).Style.BackColor = Color.Azure
            DG_G6.Rows(3).Cells(0).Style.BackColor = Color.Azure

            G6_C2.HeaderCell.Style.BackColor = Color.Bisque
            G6_C3.HeaderCell.Style.BackColor = Color.Bisque
            G6_C4.HeaderCell.Style.BackColor = Color.Bisque
            G6_C5.HeaderCell.Style.BackColor = Color.Bisque
            G6_C6.HeaderCell.Style.BackColor = Color.Bisque
            G6_C7.HeaderCell.Style.BackColor = Color.Bisque
            G6_C8.HeaderCell.Style.BackColor = Color.Bisque
            G6_C9.HeaderCell.Style.BackColor = Color.Bisque

            'marcar resultados de partidos iguales
            DG_G6.Rows(0).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G6.Rows(1).Cells(1).Style.BackColor = Color.DarkSalmon
            DG_G6.Rows(2).Cells(1).Style.BackColor = Color.CornflowerBlue
            DG_G6.Rows(3).Cells(1).Style.BackColor = Color.CornflowerBlue

            DG_G6.Rows(0).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G6.Rows(2).Cells(2).Style.BackColor = Color.BurlyWood
            DG_G6.Rows(1).Cells(2).Style.BackColor = Color.Cornsilk
            DG_G6.Rows(3).Cells(2).Style.BackColor = Color.Cornsilk

            DG_G6.Rows(0).Cells(3).Style.BackColor = Color.CadetBlue
            DG_G6.Rows(3).Cells(3).Style.BackColor = Color.CadetBlue


            DG_G6.Rows(1).Cells(3).Style.BackColor = Color.Thistle
            DG_G6.Rows(2).Cells(3).Style.BackColor = Color.Thistle






            'TABLA CLASIFICADOS

            DG_CLAS_C1.HeaderCell.Style.BackColor = Color.Bisque
            DG_CLAS_C2.HeaderCell.Style.BackColor = Color.Bisque

            DG_CLAS_C1.HeaderCell.Style.BackColor = Color.Bisque
            DG_CLAS_C2.HeaderCell.Style.BackColor = Color.Bisque


        Catch ex As Exception

        End Try
        Return True
    End Function

    '''''''''''''''''''''ESCRIBIR VALORES EN SQL'''''''''''''

    ' ESCRIBIR VARIABLES DO GRUPO 1
    Private Sub DG_G1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G1.CellEndEdit

        ROW_SEL = Val(DG_G1.CurrentRow.Index)
        COL_SEL = Val(DG_G1.CurrentCell.ColumnIndex)

        If COL_SEL = 0 Then
            Dim CONSULTA As String = "UPDATE GRUPO1 SET EQUIPO=@EQUIPO WHERE ID=@ID"
            Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO.Parameters.AddWithValue("@EQUIPO", DG_G1.Rows(ROW_SEL).Cells(0).Value)
            COMANDO.Parameters.AddWithValue("@ID", ROW_SEL + 1)
            COMANDO.ExecuteNonQuery()
        End If
    End Sub

    ' ESCRIBIR VARIABLES DO GRUPO 2
    Private Sub DG_G2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G2.CellEndEdit

        ROW_SEL = Val(DG_G2.CurrentRow.Index)
        COL_SEL = Val(DG_G2.CurrentCell.ColumnIndex)

        If COL_SEL = 0 Then
            Dim CONSULTA As String = "UPDATE GRUPO2 SET EQUIPO=@EQUIPO WHERE ID=@ID"
            Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO.Parameters.AddWithValue("@EQUIPO", DG_G2.Rows(ROW_SEL).Cells(0).Value)
            COMANDO.Parameters.AddWithValue("@ID", ROW_SEL + 1)
            COMANDO.ExecuteNonQuery()
        End If
    End Sub

    ' ESCRIBIR VARIABLES DO GRUPO 3
    Private Sub DG_G3_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G3.CellEndEdit

        ROW_SEL = Val(DG_G3.CurrentRow.Index)
        COL_SEL = Val(DG_G3.CurrentCell.ColumnIndex)

        If COL_SEL = 0 Then
            Dim CONSULTA As String = "UPDATE GRUPO3 SET EQUIPO=@EQUIPO WHERE ID=@ID"
            Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO.Parameters.AddWithValue("@EQUIPO", DG_G3.Rows(ROW_SEL).Cells(0).Value)
            COMANDO.Parameters.AddWithValue("@ID", ROW_SEL + 1)
            COMANDO.ExecuteNonQuery()
        End If
    End Sub


    ' ESCRIBIR VARIABLES DO GRUPO 4
    Private Sub DG_G4_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G4.CellEndEdit

        ROW_SEL = Val(DG_G4.CurrentRow.Index)
        COL_SEL = Val(DG_G4.CurrentCell.ColumnIndex)

        If COL_SEL = 0 Then
            Dim CONSULTA As String = "UPDATE GRUPO4 SET EQUIPO=@EQUIPO WHERE ID=@ID"
            Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO.Parameters.AddWithValue("@EQUIPO", DG_G4.Rows(ROW_SEL).Cells(0).Value)
            COMANDO.Parameters.AddWithValue("@ID", ROW_SEL + 1)
            COMANDO.ExecuteNonQuery()
        End If
    End Sub


    ' ESCRIBIR VARIABLES DO GRUPO 5
    Private Sub DG_G5_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G5.CellEndEdit

        ROW_SEL = Val(DG_G5.CurrentRow.Index)
        COL_SEL = Val(DG_G5.CurrentCell.ColumnIndex)

        If COL_SEL = 0 Then
            Dim CONSULTA As String = "UPDATE GRUPO5 SET EQUIPO=@EQUIPO WHERE ID=@ID"
            Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO.Parameters.AddWithValue("@EQUIPO", DG_G5.Rows(ROW_SEL).Cells(0).Value)
            COMANDO.Parameters.AddWithValue("@ID", ROW_SEL + 1)
            COMANDO.ExecuteNonQuery()
        End If
    End Sub


    ' ESCRIBIR VARIABLES DO GRUPO 6
    Private Sub DG_G6_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G6.CellEndEdit

        ROW_SEL = Val(DG_G6.CurrentRow.Index)
        COL_SEL = Val(DG_G6.CurrentCell.ColumnIndex)

        If COL_SEL = 0 Then
            Dim CONSULTA As String = "UPDATE GRUPO6 SET EQUIPO=@EQUIPO WHERE ID=@ID"
            Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO.Parameters.AddWithValue("@EQUIPO", DG_G6.Rows(ROW_SEL).Cells(0).Value)
            COMANDO.Parameters.AddWithValue("@ID", ROW_SEL + 1)
            COMANDO.ExecuteNonQuery()
        End If
    End Sub







    ''''''''''''''''ABRIR VENTANA PARA INTRODUCIR RESULTADOS'''''''''''''

    'GRUPO1

    Private Sub DG_G1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G1.CellDoubleClick
        ROW_SEL = Val(DG_G1.CurrentRow.Index)
        COL_SEL = Val(DG_G1.CurrentCell.ColumnIndex)
        CARGAR_RESULTADOS_G1 = True
        Select Case COL_SEL
            Case 1
                RESULTADOS_1.Show()
            Case 2
                RESULTADOS_1.Show()
            Case 3
                RESULTADOS_1.Show()
            Case 8
                DG_G1.Rows(ROW_SEL).Cells(8).Value = DG_G1.Rows(ROW_SEL).Cells(8).Value - 1
                If DG_G1.Rows(ROW_SEL).Cells(8).Value < 1 Then
                    DG_G1.Rows(ROW_SEL).Cells(8).Value = 1
                End If
                CRUCES()

        End Select

    End Sub

    ' GRUPO 2
    Private Sub DG_G2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G2.CellDoubleClick
        ROW_SEL = Val(DG_G2.CurrentRow.Index)
        COL_SEL = Val(DG_G2.CurrentCell.ColumnIndex)
        CARGAR_RESULTADOS_G2 = True
        Select Case COL_SEL
            Case 1
                RESULTADOS_1.Show()
            Case 2
                RESULTADOS_1.Show()
            Case 3
                RESULTADOS_1.Show()
            Case 8
                DG_G2.Rows(ROW_SEL).Cells(8).Value = DG_G2.Rows(ROW_SEL).Cells(8).Value - 1
                If DG_G2.Rows(ROW_SEL).Cells(8).Value < 1 Then
                    DG_G2.Rows(ROW_SEL).Cells(8).Value = 1
                End If
                CRUCES()
        End Select

    End Sub

    'GRUPO3

    Private Sub DG_G3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G3.CellDoubleClick
        ROW_SEL = Val(DG_G3.CurrentRow.Index)
        COL_SEL = Val(DG_G3.CurrentCell.ColumnIndex)
        CARGAR_RESULTADOS_G3 = True
        Select Case COL_SEL
            Case 1
                RESULTADOS_1.Show()
            Case 2
                RESULTADOS_1.Show()
            Case 3
                RESULTADOS_1.Show()
            Case 8
                DG_G3.Rows(ROW_SEL).Cells(8).Value = DG_G3.Rows(ROW_SEL).Cells(8).Value - 1
                If DG_G3.Rows(ROW_SEL).Cells(8).Value < 1 Then
                    DG_G3.Rows(ROW_SEL).Cells(8).Value = 1
                End If
                CRUCES()
        End Select

    End Sub

    'GRUPO4

    Private Sub DG_G4_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G4.CellDoubleClick
        ROW_SEL = Val(DG_G4.CurrentRow.Index)
        COL_SEL = Val(DG_G4.CurrentCell.ColumnIndex)
        CARGAR_RESULTADOS_G4 = True
        Select Case COL_SEL
            Case 1
                RESULTADOS_1.Show()
            Case 2
                RESULTADOS_1.Show()
            Case 3
                RESULTADOS_1.Show()
            Case 8
                DG_G4.Rows(ROW_SEL).Cells(8).Value = DG_G4.Rows(ROW_SEL).Cells(8).Value - 1
                If DG_G4.Rows(ROW_SEL).Cells(8).Value < 1 Then
                    DG_G4.Rows(ROW_SEL).Cells(8).Value = 1
                End If
                CRUCES()
        End Select
    End Sub

    'GRUPO5

    Private Sub DG_G5_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G5.CellDoubleClick
        ROW_SEL = Val(DG_G5.CurrentRow.Index)
        COL_SEL = Val(DG_G5.CurrentCell.ColumnIndex)
        CARGAR_RESULTADOS_G5 = True
        Select Case COL_SEL
            Case 1
                RESULTADOS_1.Show()
            Case 2
                RESULTADOS_1.Show()
            Case 3
                RESULTADOS_1.Show()
            Case 8
                DG_G5.Rows(ROW_SEL).Cells(8).Value = DG_G5.Rows(ROW_SEL).Cells(8).Value - 1
                If DG_G5.Rows(ROW_SEL).Cells(8).Value < 1 Then
                    DG_G5.Rows(ROW_SEL).Cells(8).Value = 1
                End If
                CRUCES()
        End Select
    End Sub

    'GRUPO6

    Private Sub DG_G6_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_G6.CellDoubleClick
        ROW_SEL = Val(DG_G6.CurrentRow.Index)
        COL_SEL = Val(DG_G6.CurrentCell.ColumnIndex)
        CARGAR_RESULTADOS_G6 = True
        Select Case COL_SEL
            Case 1
                RESULTADOS_1.Show()
            Case 2
                RESULTADOS_1.Show()
            Case 3
                RESULTADOS_1.Show()
            Case 8
                DG_G6.Rows(ROW_SEL).Cells(8).Value = DG_G6.Rows(ROW_SEL).Cells(8).Value - 1
                If DG_G6.Rows(ROW_SEL).Cells(8).Value < 1 Then
                    DG_G6.Rows(ROW_SEL).Cells(8).Value = 1
                End If
                CRUCES()
        End Select
    End Sub



    '''''''''''''''''''Clasificacion'''''''''''''''''
    Function CLASIFICAR() As Boolean

        Dim POS(3) As Integer
        Dim columpartido As Integer
        Try


            ''''' GRUPO 1 '''''
            For I = 0 To 3
                POS(I) = 4
                For J = 0 To 3
                    columpartido = 0
                    If I <> J Then

                        If DG_G1.Rows(I).Cells(7).Value > DG_G1.Rows(J).Cells(7).Value Then
                            POS(I) = POS(I) - 1

                            'empate a puntos
                        ElseIf DG_G1.Rows(I).Cells(7).Value = DG_G1.Rows(J).Cells(7).Value Then

                            'mirar en quen columna de partido estou (a fila marcama a i ou j)

                            If (I = 0 And J = 1) Or (I = 1 And J = 0) Or (I = 2 And J = 3) Or (I = 3 And J = 2) Then
                                columpartido = 0
                            End If
                            If (I = 0 And J = 2) Or (I = 1 And J = 3) Or (I = 2 And J = 0) Or (I = 3 And J = 1) Then
                                columpartido = 1
                            End If
                            If (I = 0 And J = 3) Or (I = 1 And J = 2) Or (I = 2 And J = 1) Or (I = 3 And J = 0) Then
                                columpartido = 2
                            End If

                            If DGPARTIDO1.Rows(I).Cells(columpartido).Value > DGPARTIDO1.Rows(J).Cells(columpartido).Value Then
                                POS(I) = POS(I) - 1
                            End If
                            'TAMEN EMPATADOS NO ENFRENTAMIENTO DIRECTO
                            If DGPARTIDO1.Rows(I).Cells(columpartido).Value = DGPARTIDO1.Rows(J).Cells(columpartido).Value Then

                                If DG_G1.Rows(I).Cells(6).Value > DG_G1.Rows(J).Cells(6).Value Then
                                    POS(I) = POS(I) - 1
                                End If
                                'TAMEN EMPATADOS EN DF
                                If DG_G1.Rows(I).Cells(6).Value = DG_G1.Rows(J).Cells(6).Value Then

                                    'TAMEN EMPATADOS EN GF
                                    If DG_G1.Rows(I).Cells(4).Value > DG_G1.Rows(J).Cells(4).Value Then
                                        POS(I) = POS(I) - 1
                                    End If

                                End If


                            End If

                        End If

                    End If


                Next
                DG_G1.Rows(I).Cells(8).Value = POS(I)
            Next

            ''''' GRUPO 2 '''''

            For I = 0 To 3
                POS(I) = 4
                For J = 0 To 3
                    columpartido = 0
                    If I <> J Then

                        If DG_G2.Rows(I).Cells(7).Value > DG_G2.Rows(J).Cells(7).Value Then
                            POS(I) = POS(I) - 1

                            'empate a puntos
                        ElseIf DG_G2.Rows(I).Cells(7).Value = DG_G2.Rows(J).Cells(7).Value Then

                            'mirar en quen columna de partido estou (a fila marcama a i ou j)

                            If (I = 0 And J = 1) Or (I = 1 And J = 0) Or (I = 2 And J = 3) Or (I = 3 And J = 2) Then
                                columpartido = 0
                            End If
                            If (I = 0 And J = 2) Or (I = 1 And J = 3) Or (I = 2 And J = 0) Or (I = 3 And J = 1) Then
                                columpartido = 1
                            End If
                            If (I = 0 And J = 3) Or (I = 1 And J = 2) Or (I = 2 And J = 1) Or (I = 3 And J = 0) Then
                                columpartido = 2
                            End If

                            If DGPARTIDO2.Rows(I).Cells(columpartido).Value > DGPARTIDO2.Rows(J).Cells(columpartido).Value Then
                                POS(I) = POS(I) - 1
                            End If
                            'TAMEN EMPATADOS NO ENFRENTAMIENTO DIRECTO
                            If DGPARTIDO2.Rows(I).Cells(columpartido).Value = DGPARTIDO2.Rows(J).Cells(columpartido).Value Then

                                If DG_G2.Rows(I).Cells(6).Value > DG_G2.Rows(J).Cells(6).Value Then
                                    POS(I) = POS(I) - 1
                                End If
                                'TAMEN EMPATADOS EN DF
                                If DG_G2.Rows(I).Cells(6).Value = DG_G2.Rows(J).Cells(6).Value Then

                                    'TAMEN EMPATADOS EN GF
                                    If DG_G2.Rows(I).Cells(4).Value > DG_G2.Rows(J).Cells(4).Value Then
                                        POS(I) = POS(I) - 1
                                    End If

                                End If


                            End If

                        End If

                    End If


                Next
                DG_G2.Rows(I).Cells(8).Value = POS(I)
            Next

            ''''' GRUPO 3 '''''

            For I = 0 To 3
                POS(I) = 4
                For J = 0 To 3
                    columpartido = 0
                    If I <> J Then

                        If DG_G3.Rows(I).Cells(7).Value > DG_G3.Rows(J).Cells(7).Value Then
                            POS(I) = POS(I) - 1

                            'empate a puntos
                        ElseIf DG_G3.Rows(I).Cells(7).Value = DG_G3.Rows(J).Cells(7).Value Then

                            'mirar en quen columna de partido estou (a fila marcama a i ou j)

                            If (I = 0 And J = 1) Or (I = 1 And J = 0) Or (I = 2 And J = 3) Or (I = 3 And J = 2) Then
                                columpartido = 0
                            End If
                            If (I = 0 And J = 2) Or (I = 1 And J = 3) Or (I = 2 And J = 0) Or (I = 3 And J = 1) Then
                                columpartido = 1
                            End If
                            If (I = 0 And J = 3) Or (I = 1 And J = 2) Or (I = 2 And J = 1) Or (I = 3 And J = 0) Then
                                columpartido = 2
                            End If

                            If DGPARTIDO3.Rows(I).Cells(columpartido).Value > DGPARTIDO3.Rows(J).Cells(columpartido).Value Then
                                POS(I) = POS(I) - 1
                            End If
                            'TAMEN EMPATADOS NO ENFRENTAMIENTO DIRECTO
                            If DGPARTIDO3.Rows(I).Cells(columpartido).Value = DGPARTIDO3.Rows(J).Cells(columpartido).Value Then

                                If DG_G3.Rows(I).Cells(6).Value > DG_G3.Rows(J).Cells(6).Value Then
                                    POS(I) = POS(I) - 1
                                End If
                                'TAMEN EMPATADOS EN DF
                                If DG_G3.Rows(I).Cells(6).Value = DG_G3.Rows(J).Cells(6).Value Then

                                    'TAMEN EMPATADOS EN GF
                                    If DG_G3.Rows(I).Cells(4).Value > DG_G3.Rows(J).Cells(4).Value Then
                                        POS(I) = POS(I) - 1
                                    End If

                                End If


                            End If

                        End If

                    End If


                Next
                DG_G3.Rows(I).Cells(8).Value = POS(I)
            Next

            ''''' GRUPO 4 '''''

            For I = 0 To 3
                POS(I) = 4
                For J = 0 To 3
                    columpartido = 0
                    If I <> J Then

                        If DG_G4.Rows(I).Cells(7).Value > DG_G4.Rows(J).Cells(7).Value Then
                            POS(I) = POS(I) - 1

                            'empate a puntos
                        ElseIf DG_G4.Rows(I).Cells(7).Value = DG_G4.Rows(J).Cells(7).Value Then

                            'mirar en quen columna de partido estou (a fila marcama a i ou j)

                            If (I = 0 And J = 1) Or (I = 1 And J = 0) Or (I = 2 And J = 3) Or (I = 3 And J = 2) Then
                                columpartido = 0
                            End If
                            If (I = 0 And J = 2) Or (I = 1 And J = 3) Or (I = 2 And J = 0) Or (I = 3 And J = 1) Then
                                columpartido = 1
                            End If
                            If (I = 0 And J = 3) Or (I = 1 And J = 2) Or (I = 2 And J = 1) Or (I = 3 And J = 0) Then
                                columpartido = 2
                            End If

                            If DGPARTIDO4.Rows(I).Cells(columpartido).Value > DGPARTIDO4.Rows(J).Cells(columpartido).Value Then
                                POS(I) = POS(I) - 1
                            End If
                            'TAMEN EMPATADOS NO ENFRENTAMIENTO DIRECTO
                            If DGPARTIDO4.Rows(I).Cells(columpartido).Value = DGPARTIDO4.Rows(J).Cells(columpartido).Value Then

                                If DG_G4.Rows(I).Cells(6).Value > DG_G4.Rows(J).Cells(6).Value Then
                                    POS(I) = POS(I) - 1
                                End If
                                'TAMEN EMPATADOS EN DF
                                If DG_G4.Rows(I).Cells(6).Value = DG_G4.Rows(J).Cells(6).Value Then

                                    'TAMEN EMPATADOS EN GF
                                    If DG_G4.Rows(I).Cells(4).Value > DG_G4.Rows(J).Cells(4).Value Then
                                        POS(I) = POS(I) - 1
                                    End If

                                End If


                            End If

                        End If

                    End If


                Next
                DG_G4.Rows(I).Cells(8).Value = POS(I)
            Next

            ''''' GRUPO 5 '''''

            For I = 0 To 3
                POS(I) = 4
                For J = 0 To 3
                    columpartido = 0
                    If I <> J Then

                        If DG_G5.Rows(I).Cells(7).Value > DG_G5.Rows(J).Cells(7).Value Then
                            POS(I) = POS(I) - 1

                            'empate a puntos
                        ElseIf DG_G5.Rows(I).Cells(7).Value = DG_G5.Rows(J).Cells(7).Value Then

                            'mirar en quen columna de partido estou (a fila marcama a i ou j)

                            If (I = 0 And J = 1) Or (I = 1 And J = 0) Or (I = 2 And J = 3) Or (I = 3 And J = 2) Then
                                columpartido = 0
                            End If
                            If (I = 0 And J = 2) Or (I = 1 And J = 3) Or (I = 2 And J = 0) Or (I = 3 And J = 1) Then
                                columpartido = 1
                            End If
                            If (I = 0 And J = 3) Or (I = 1 And J = 2) Or (I = 2 And J = 1) Or (I = 3 And J = 0) Then
                                columpartido = 2
                            End If

                            If DGPARTIDO5.Rows(I).Cells(columpartido).Value > DGPARTIDO5.Rows(J).Cells(columpartido).Value Then
                                POS(I) = POS(I) - 1
                            End If
                            'TAMEN EMPATADOS NO ENFRENTAMIENTO DIRECTO
                            If DGPARTIDO5.Rows(I).Cells(columpartido).Value = DGPARTIDO5.Rows(J).Cells(columpartido).Value Then

                                If DG_G5.Rows(I).Cells(6).Value > DG_G5.Rows(J).Cells(6).Value Then
                                    POS(I) = POS(I) - 1
                                End If
                                'TAMEN EMPATADOS EN DF
                                If DG_G5.Rows(I).Cells(6).Value = DG_G5.Rows(J).Cells(6).Value Then

                                    'TAMEN EMPATADOS EN GF
                                    If DG_G5.Rows(I).Cells(4).Value > DG_G5.Rows(J).Cells(4).Value Then
                                        POS(I) = POS(I) - 1
                                    End If

                                End If


                            End If

                        End If

                    End If


                Next
                DG_G5.Rows(I).Cells(8).Value = POS(I)
            Next


            ''''' GRUPO 6 '''''

            For I = 0 To 3
                POS(I) = 4
                For J = 0 To 3
                    columpartido = 0
                    If I <> J Then

                        If DG_G6.Rows(I).Cells(7).Value > DG_G6.Rows(J).Cells(7).Value Then
                            POS(I) = POS(I) - 1

                            'empate a puntos
                        ElseIf DG_G6.Rows(I).Cells(7).Value = DG_G6.Rows(J).Cells(7).Value Then

                            'mirar en quen columna de partido estou (a fila marcama a i ou j)

                            If (I = 0 And J = 1) Or (I = 1 And J = 0) Or (I = 2 And J = 3) Or (I = 3 And J = 2) Then
                                columpartido = 0
                            End If
                            If (I = 0 And J = 2) Or (I = 1 And J = 3) Or (I = 2 And J = 0) Or (I = 3 And J = 1) Then
                                columpartido = 1
                            End If
                            If (I = 0 And J = 3) Or (I = 1 And J = 2) Or (I = 2 And J = 1) Or (I = 3 And J = 0) Then
                                columpartido = 2
                            End If

                            If DGPARTIDO6.Rows(I).Cells(columpartido).Value > DGPARTIDO6.Rows(J).Cells(columpartido).Value Then
                                POS(I) = POS(I) - 1
                            End If
                            'TAMEN EMPATADOS NO ENFRENTAMIENTO DIRECTO
                            If DGPARTIDO6.Rows(I).Cells(columpartido).Value = DGPARTIDO6.Rows(J).Cells(columpartido).Value Then

                                If DG_G6.Rows(I).Cells(6).Value > DG_G6.Rows(J).Cells(6).Value Then
                                    POS(I) = POS(I) - 1
                                End If
                                'TAMEN EMPATADOS EN DF
                                If DG_G6.Rows(I).Cells(6).Value = DG_G6.Rows(J).Cells(6).Value Then

                                    'TAMEN EMPATADOS EN GF
                                    If DG_G6.Rows(I).Cells(4).Value > DG_G6.Rows(J).Cells(4).Value Then
                                        POS(I) = POS(I) - 1
                                    End If

                                End If


                            End If

                        End If

                    End If


                Next
                DG_G6.Rows(I).Cells(8).Value = POS(I)
            Next


            CRUCES()


        Catch ex As Exception

        End Try







        Return True
    End Function




    ''''''''''''''''''''''''''CRUCES'''''''''''''''''''''''''''''''''

    Function CRUCES() As Boolean

        For i = 0 To 2
            For j = 0 To 5
                DG_CLASIFICADOS.Rows(j).Cells(i).Value = ""
            Next
        Next
        For i = 0 To 5
            For j = 0 To 1
                DG_VER_TERCEIROS.Rows(i).Cells(j).Value = ""
            Next
        Next
        For i = 0 To 5
            For j = 0 To 4
                DG_TERCEIROS.Rows(i).Cells(j).Value = ""
            Next
        Next



        DG_CLASIFICADOS.Rows(0).Cells(0).Value = "GRUPO A"
        DG_CLASIFICADOS.Rows(1).Cells(0).Value = "GRUPO B"
        DG_CLASIFICADOS.Rows(2).Cells(0).Value = "GRUPO C"
        DG_CLASIFICADOS.Rows(3).Cells(0).Value = "GRUPO D"
        DG_CLASIFICADOS.Rows(4).Cells(0).Value = "GRUPO E"
        DG_CLASIFICADOS.Rows(5).Cells(0).Value = "GRUPO F"

        Try

            For I = 0 To 3

                If DG_G1.Rows(I).Cells(8).Value = 1 Then
                    DG_CLASIFICADOS.Rows(0).Cells(1).Value = DG_G1.Rows(I).Cells(0).Value

                End If
                If DG_G1.Rows(I).Cells(8).Value = 2 Then
                    DG_CLASIFICADOS.Rows(0).Cells(2).Value = DG_G1.Rows(I).Cells(0).Value

                End If

                If DG_G1.Rows(I).Cells(8).Value = 3 Then
                    DG_TERCEIROS.Rows(0).Cells(0).Value = DG_G1.Rows(I).Cells(0).Value
                    DG_TERCEIROS.Rows(0).Cells(1).Value = DG_G1.Rows(I).Cells(7).Value
                    DG_TERCEIROS.Rows(0).Cells(2).Value = DG_G1.Rows(I).Cells(6).Value
                    DG_TERCEIROS.Rows(0).Cells(3).Value = DG_G1.Rows(I).Cells(4).Value
                    DG_TERCEIROS.Rows(0).Cells(4).Value = "A"

                    DG_VER_TERCEIROS.Rows(0).Cells(0).Value = "A"
                    DG_VER_TERCEIROS.Rows(0).Cells(1).Value = DG_G1.Rows(I).Cells(0).Value


                End If

            Next


            For I = 0 To 3

                If DG_G2.Rows(I).Cells(8).Value = 1 Then
                    DG_CLASIFICADOS.Rows(1).Cells(1).Value = DG_G2.Rows(I).Cells(0).Value
                End If
                If DG_G2.Rows(I).Cells(8).Value = 2 Then
                    DG_CLASIFICADOS.Rows(1).Cells(2).Value = DG_G2.Rows(I).Cells(0).Value
                End If

                If DG_G2.Rows(I).Cells(8).Value = 3 Then
                    DG_TERCEIROS.Rows(1).Cells(0).Value = DG_G2.Rows(I).Cells(0).Value
                    DG_TERCEIROS.Rows(1).Cells(1).Value = DG_G2.Rows(I).Cells(7).Value
                    DG_TERCEIROS.Rows(1).Cells(2).Value = DG_G2.Rows(I).Cells(6).Value
                    DG_TERCEIROS.Rows(1).Cells(3).Value = DG_G2.Rows(I).Cells(4).Value
                    DG_TERCEIROS.Rows(1).Cells(4).Value = "B"

                    DG_VER_TERCEIROS.Rows(1).Cells(0).Value = "B"
                    DG_VER_TERCEIROS.Rows(1).Cells(1).Value = DG_G2.Rows(I).Cells(0).Value

                End If







            Next


            For I = 0 To 3

                If DG_G3.Rows(I).Cells(8).Value = 1 Then
                    DG_CLASIFICADOS.Rows(2).Cells(1).Value = DG_G3.Rows(I).Cells(0).Value
                End If
                If DG_G3.Rows(I).Cells(8).Value = 2 Then
                    DG_CLASIFICADOS.Rows(2).Cells(2).Value = DG_G3.Rows(I).Cells(0).Value
                End If

                If DG_G3.Rows(I).Cells(8).Value = 3 Then
                    DG_TERCEIROS.Rows(2).Cells(0).Value = DG_G3.Rows(I).Cells(0).Value
                    DG_TERCEIROS.Rows(2).Cells(1).Value = DG_G3.Rows(I).Cells(7).Value
                    DG_TERCEIROS.Rows(2).Cells(2).Value = DG_G3.Rows(I).Cells(6).Value
                    DG_TERCEIROS.Rows(2).Cells(3).Value = DG_G3.Rows(I).Cells(4).Value
                    DG_TERCEIROS.Rows(2).Cells(4).Value = "C"

                    DG_VER_TERCEIROS.Rows(2).Cells(0).Value = "C"
                    DG_VER_TERCEIROS.Rows(2).Cells(1).Value = DG_G3.Rows(I).Cells(0).Value

                End If


            Next



            For I = 0 To 3

                If DG_G4.Rows(I).Cells(8).Value = 1 Then
                    DG_CLASIFICADOS.Rows(3).Cells(1).Value = DG_G4.Rows(I).Cells(0).Value
                End If
                If DG_G4.Rows(I).Cells(8).Value = 2 Then
                    DG_CLASIFICADOS.Rows(3).Cells(2).Value = DG_G4.Rows(I).Cells(0).Value
                End If
                If DG_G4.Rows(I).Cells(8).Value = 3 Then
                    DG_TERCEIROS.Rows(3).Cells(0).Value = DG_G4.Rows(I).Cells(0).Value
                    DG_TERCEIROS.Rows(3).Cells(1).Value = DG_G4.Rows(I).Cells(7).Value
                    DG_TERCEIROS.Rows(3).Cells(2).Value = DG_G4.Rows(I).Cells(6).Value
                    DG_TERCEIROS.Rows(3).Cells(3).Value = DG_G4.Rows(I).Cells(4).Value
                    DG_TERCEIROS.Rows(3).Cells(4).Value = "D"

                    DG_VER_TERCEIROS.Rows(3).Cells(0).Value = "D"
                    DG_VER_TERCEIROS.Rows(3).Cells(1).Value = DG_G4.Rows(I).Cells(0).Value

                End If

            Next

            For I = 0 To 3

                If DG_G5.Rows(I).Cells(8).Value = 1 Then
                    DG_CLASIFICADOS.Rows(4).Cells(1).Value = DG_G5.Rows(I).Cells(0).Value
                End If
                If DG_G4.Rows(I).Cells(8).Value = 2 Then
                    DG_CLASIFICADOS.Rows(4).Cells(2).Value = DG_G4.Rows(I).Cells(0).Value
                End If

                If DG_G5.Rows(I).Cells(8).Value = 3 Then
                    DG_TERCEIROS.Rows(4).Cells(0).Value = DG_G5.Rows(I).Cells(0).Value
                    DG_TERCEIROS.Rows(4).Cells(1).Value = DG_G5.Rows(I).Cells(7).Value
                    DG_TERCEIROS.Rows(4).Cells(2).Value = DG_G5.Rows(I).Cells(6).Value
                    DG_TERCEIROS.Rows(4).Cells(3).Value = DG_G5.Rows(I).Cells(4).Value
                    DG_TERCEIROS.Rows(4).Cells(4).Value = "E"


                    DG_VER_TERCEIROS.Rows(4).Cells(0).Value = "E"
                    DG_VER_TERCEIROS.Rows(4).Cells(1).Value = DG_G5.Rows(I).Cells(0).Value

                End If

            Next


            For I = 0 To 3

                If DG_G6.Rows(I).Cells(8).Value = 1 Then
                    DG_CLASIFICADOS.Rows(5).Cells(1).Value = DG_G6.Rows(I).Cells(0).Value
                End If
                If DG_G6.Rows(I).Cells(8).Value = 2 Then
                    DG_CLASIFICADOS.Rows(5).Cells(2).Value = DG_G6.Rows(I).Cells(0).Value
                End If

                If DG_G6.Rows(I).Cells(8).Value = 3 Then
                    DG_TERCEIROS.Rows(5).Cells(0).Value = DG_G6.Rows(I).Cells(0).Value
                    DG_TERCEIROS.Rows(5).Cells(1).Value = DG_G6.Rows(I).Cells(7).Value
                    DG_TERCEIROS.Rows(5).Cells(2).Value = DG_G6.Rows(I).Cells(6).Value
                    DG_TERCEIROS.Rows(5).Cells(3).Value = DG_G6.Rows(I).Cells(4).Value
                    DG_TERCEIROS.Rows(5).Cells(4).Value = "F"


                    DG_VER_TERCEIROS.Rows(5).Cells(0).Value = "F"
                    DG_VER_TERCEIROS.Rows(5).Cells(1).Value = DG_G6.Rows(I).Cells(0).Value
                End If
            Next


            ORDENA()

            'METO OS CATRO MELLORES TERCEIROS NA TABLA DE CLASIFICADOS

            Try

                DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = DG_TERCEIROS.Rows(0).Cells(4).Value
                DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value = DG_TERCEIROS.Rows(0).Cells(0).Value
                DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = DG_TERCEIROS.Rows(1).Cells(4).Value
                DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value = DG_TERCEIROS.Rows(1).Cells(0).Value
                DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = DG_TERCEIROS.Rows(2).Cells(4).Value
                DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value = DG_TERCEIROS.Rows(2).Cells(0).Value
                DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = DG_TERCEIROS.Rows(3).Cells(4).Value
                DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value = DG_TERCEIROS.Rows(3).Cells(0).Value

                DG_TERCEIROS_CLAS.Sort(DG_TERCEIROS_CLAS.Columns(0), 0)


            Catch ex As Exception

            End Try


            'OCTAVOS
            Try
                'PRIMEIROS E SEGUNDOS DE GRUPO
                A2.Text = DG_CLASIFICADOS.Rows(0).Cells(2).Value
                C2.Text = DG_CLASIFICADOS.Rows(2).Cells(2).Value

                D1.Text = DG_CLASIFICADOS.Rows(3).Cells(1).Value


                C1.Text = DG_CLASIFICADOS.Rows(2).Cells(1).Value


                F1.Text = DG_CLASIFICADOS.Rows(5).Cells(1).Value
                E2.Text = DG_CLASIFICADOS.Rows(4).Cells(2).Value

                B1.Text = DG_CLASIFICADOS.Rows(1).Cells(1).Value


                E1.Text = DG_CLASIFICADOS.Rows(4).Cells(1).Value
                D2.Text = DG_CLASIFICADOS.Rows(3).Cells(2).Value

                A1.Text = DG_CLASIFICADOS.Rows(0).Cells(1).Value


                B2.Text = DG_CLASIFICADOS.Rows(1).Cells(2).Value
                F2.Text = DG_CLASIFICADOS.Rows(5).Cells(2).Value



                'TERCEIROS DE GRUPO
                '1

                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "D" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value

                End If
                '2
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "E" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If
                '3
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If
                '4
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "E" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If

                '5
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If
                '6
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "E" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If

                '7
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "E" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If

                '8
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If

                '9
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "E" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value

                End If

                '10
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "A" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "E" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value

                End If

                '11
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "E" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If


                '12
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If

                '13
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "E" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If

                '14
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "B" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "E" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value

                End If

                '14
                If DG_TERCEIROS_CLAS.Rows(0).Cells(0).Value = "C" And DG_TERCEIROS_CLAS.Rows(1).Cells(0).Value = "D" And DG_TERCEIROS_CLAS.Rows(2).Cells(0).Value = "E" And DG_TERCEIROS_CLAS.Rows(3).Cells(0).Value = "F" Then

                    C3D3E3.Text = DG_TERCEIROS_CLAS.Rows(0).Cells(1).Value
                    A3C3D3.Text = DG_TERCEIROS_CLAS.Rows(1).Cells(1).Value
                    A3B3F3.Text = DG_TERCEIROS_CLAS.Rows(3).Cells(1).Value
                    B3E3F3.Text = DG_TERCEIROS_CLAS.Rows(2).Cells(1).Value

                End If

            Catch ex As Exception
                MessageBox.Show("FALLO OCTAVOS")
            End Try















            CARGAR_GOLES_CRUCES()



        Catch ex As Exception
            MessageBox.Show("FALLO A TABLA CLASIFICACION")


        End Try

        Return True
    End Function


    'ORDENAR TABLA TERCEIROS

    Private Class RowComparer
        Implements System.Collections.IComparer

        Public sortOrderModifier As Integer = 1
        Public Shared COLRED As Integer
        Public Shared COLRED2 As Integer
        Public Sub New(ByVal sortOrder As SortOrder)
            If sortOrder = SortOrder.Descending Then
                sortOrderModifier = -1
            ElseIf sortOrder = SortOrder.Ascending Then
                sortOrderModifier = 1
            End If

            sortOrderModifier = -1
        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
            Implements System.Collections.IComparer.Compare

            Dim DataGridViewRow1 As DataGridViewRow = CType(x, DataGridViewRow)
            Dim DataGridViewRow2 As DataGridViewRow = CType(y, DataGridViewRow)

            ' Try to sort based on the Last Name column.
            Dim CompareResult As Integer = System.Decimal.Compare(
                DataGridViewRow1.Cells(COLRED).Value,
                DataGridViewRow2.Cells(COLRED).Value)

            ' If the Last Names are equal, sort based on the First Name.
            If CompareResult = 0 Then
                CompareResult = System.Decimal.Compare(
                    DataGridViewRow1.Cells(COLRED2).Value,
                    DataGridViewRow2.Cells(COLRED2).Value)
            End If
            Return CompareResult * sortOrderModifier
        End Function
    End Class



    Function ORDENA() As Boolean
        Try
            RowComparer.COLRED = 1
            RowComparer.COLRED2 = 2
            DG_TERCEIROS.Sort(New RowComparer(SortOrder.Descending))

            RowComparer.COLRED = 2
            RowComparer.COLRED2 = 3
            DG_TERCEIROS.Sort(New RowComparer(SortOrder.Descending))

        Catch ex As Exception

        End Try
        Return True
    End Function





    'CARGAR HORAS

    Function LER_HORAS() As Boolean

        Dim CONSULTA As String = "SELECT  H_O1, H_O2, H_O3, H_O4, H_O5, H_O6, H_O7, H_O8, H_C1, H_C2, H_C3, H_C4, H_S1, H_S2, H_F1, H_F2 FROM horas "
        Dim DATA_SET As New DataSet
        Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)

        COMANDO.ExecuteNonQuery()
        Dim ADAPTADOR As New MySqlDataAdapter(COMANDO)
        ADAPTADOR.Fill(DATA_SET)
        DG_H.DataSource = DATA_SET.Tables(0)

        H_O1.Text = DG_H.Rows(0).Cells(0).Value
        H_O2.Text = DG_H.Rows(0).Cells(1).Value
        H_O3.Text = DG_H.Rows(0).Cells(2).Value
        H_O4.Text = DG_H.Rows(0).Cells(3).Value
        H_O5.Text = DG_H.Rows(0).Cells(4).Value
        H_O6.Text = DG_H.Rows(0).Cells(5).Value
        H_O7.Text = DG_H.Rows(0).Cells(6).Value
        H_O8.Text = DG_H.Rows(0).Cells(7).Value

        H_C1.Text = DG_H.Rows(0).Cells(8).Value
        H_C2.Text = DG_H.Rows(0).Cells(9).Value
        H_C3.Text = DG_H.Rows(0).Cells(10).Value
        H_C4.Text = DG_H.Rows(0).Cells(11).Value

        H_S1.Text = DG_H.Rows(0).Cells(12).Value
        H_S2.Text = DG_H.Rows(0).Cells(13).Value

        H_F1.Text = DG_H.Rows(0).Cells(14).Value
        H_F2.Text = DG_H.Rows(0).Cells(15).Value



        Return True

    End Function



    Private Sub H_O1_KeyDown(sender As Object, e As KeyEventArgs) Handles H_O1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(0).Value = H_O1.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_O1=@H_O1 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_O1", DG_H.Rows(0).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                H_O2.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_O2.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub H_O2_KeyDown(sender As Object, e As KeyEventArgs) Handles H_O2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(1).Value = H_O2.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_O2=@H_O2 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_O2", DG_H.Rows(0).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                H_O3.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_O3.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_O3_KeyDown(sender As Object, e As KeyEventArgs) Handles H_O3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(2).Value = H_O3.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_O3=@H_O3 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_O3", DG_H.Rows(0).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                H_O4.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_O4.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_O4_KeyDown(sender As Object, e As KeyEventArgs) Handles H_O4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(3).Value = H_O4.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_O4=@H_O4 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_O4", DG_H.Rows(0).Cells(3).Value)
                COMANDO.ExecuteNonQuery()
                H_O5.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_O5.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_O5_KeyDown(sender As Object, e As KeyEventArgs) Handles H_O5.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(4).Value = H_O5.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_O5=@H_O5 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_O5", DG_H.Rows(0).Cells(4).Value)
                COMANDO.ExecuteNonQuery()
                H_O6.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_O6.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_O6_KeyDown(sender As Object, e As KeyEventArgs) Handles H_O6.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(5).Value = H_O6.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_O6=@H_O6 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_O6", DG_H.Rows(0).Cells(5).Value)
                COMANDO.ExecuteNonQuery()
                H_O7.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_O7.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_O7_KeyDown(sender As Object, e As KeyEventArgs) Handles H_O7.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(6).Value = H_O7.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_O7=@H_O7 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_O7", DG_H.Rows(0).Cells(6).Value)
                COMANDO.ExecuteNonQuery()
                H_O8.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_O8.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_O8_KeyDown(sender As Object, e As KeyEventArgs) Handles H_O8.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(7).Value = H_O8.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_O8=@H_O8 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_O8", DG_H.Rows(0).Cells(7).Value)
                COMANDO.ExecuteNonQuery()
                H_C1.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_C1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_C1_KeyDown(sender As Object, e As KeyEventArgs) Handles H_C1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(8).Value = H_C1.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_C1=@H_C1 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_C1", DG_H.Rows(0).Cells(8).Value)
                COMANDO.ExecuteNonQuery()
                H_C2.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_C2.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_C2_KeyDown(sender As Object, e As KeyEventArgs) Handles H_C2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(9).Value = H_C2.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_C2=@H_C2 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_C2", DG_H.Rows(0).Cells(9).Value)
                COMANDO.ExecuteNonQuery()
                H_C3.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_C3.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_C3_KeyDown(sender As Object, e As KeyEventArgs) Handles H_C3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(10).Value = H_C3.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_C3=@H_C3 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_C3", DG_H.Rows(0).Cells(10).Value)
                COMANDO.ExecuteNonQuery()
                H_C4.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_C4.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_C4_KeyDown(sender As Object, e As KeyEventArgs) Handles H_C4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(11).Value = H_C4.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_C4=@H_C4 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_C4", DG_H.Rows(0).Cells(11).Value)
                COMANDO.ExecuteNonQuery()
                H_S1.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_S1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_S1_KeyDown(sender As Object, e As KeyEventArgs) Handles H_S1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(12).Value = H_S1.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_S1=@H_S1 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_S1", DG_H.Rows(0).Cells(12).Value)
                COMANDO.ExecuteNonQuery()
                H_S2.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_S2.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_S2_KeyDown(sender As Object, e As KeyEventArgs) Handles H_S2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(13).Value = H_S2.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_S2=@H_S2 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_S2", DG_H.Rows(0).Cells(13).Value)
                COMANDO.ExecuteNonQuery()
                H_F1.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_F1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_F1_KeyDown(sender As Object, e As KeyEventArgs) Handles H_F1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(14).Value = H_F1.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_F1=@H_F1 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_F1", DG_H.Rows(0).Cells(14).Value)
                COMANDO.ExecuteNonQuery()
                H_F2.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_F2.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub H_F2_KeyDown(sender As Object, e As KeyEventArgs) Handles H_F2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_H.Rows(0).Cells(15).Value = H_F1.Text
                Dim CONSULTA As String = "UPDATE HORAS SET H_F2=@H_F2 WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@H_F2", DG_H.Rows(0).Cells(15).Value)
                COMANDO.ExecuteNonQuery()
                H_O1.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                H_O1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub




    ' RESULTADOS CRUCES


    Function CARGAR_GOLES_CRUCES() As Boolean


        Dim CONSULTA As String = "SELECT  G_O, G_C, G_S, G_F  FROM CRUCES "
        Dim DATA_SET As New DataSet
        Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)

        COMANDO.ExecuteNonQuery()
        Dim ADAPTADOR As New MySqlDataAdapter(COMANDO)
        ADAPTADOR.Fill(DATA_SET)
        DG_CRUCES.DataSource = DATA_SET.Tables(0)


        GOL_O1.Text = DG_CRUCES.Rows(0).Cells(0).Value
        GOL_O2.Text = DG_CRUCES.Rows(1).Cells(0).Value
        GOL_O3.Text = DG_CRUCES.Rows(2).Cells(0).Value
        GOL_O4.Text = DG_CRUCES.Rows(3).Cells(0).Value
        GOL_O5.Text = DG_CRUCES.Rows(4).Cells(0).Value
        GOL_O6.Text = DG_CRUCES.Rows(5).Cells(0).Value
        GOL_O7.Text = DG_CRUCES.Rows(6).Cells(0).Value
        GOL_O8.Text = DG_CRUCES.Rows(7).Cells(0).Value
        GOL_O9.Text = DG_CRUCES.Rows(8).Cells(0).Value
        GOL_O10.Text = DG_CRUCES.Rows(9).Cells(0).Value
        GOL_O11.Text = DG_CRUCES.Rows(10).Cells(0).Value
        GOL_O12.Text = DG_CRUCES.Rows(11).Cells(0).Value
        GOL_O13.Text = DG_CRUCES.Rows(12).Cells(0).Value
        GOL_O14.Text = DG_CRUCES.Rows(13).Cells(0).Value
        GOL_O15.Text = DG_CRUCES.Rows(14).Cells(0).Value
        GOL_O16.Text = DG_CRUCES.Rows(15).Cells(0).Value

        GOL_C1.Text = DG_CRUCES.Rows(0).Cells(1).Value.ToString
        GOL_C2.Text = DG_CRUCES.Rows(1).Cells(1).Value.ToString
        GOL_C3.Text = DG_CRUCES.Rows(2).Cells(1).Value.ToString
        GOL_C4.Text = DG_CRUCES.Rows(3).Cells(1).Value.ToString
        GOL_C5.Text = DG_CRUCES.Rows(4).Cells(1).Value.ToString
        GOL_C6.Text = DG_CRUCES.Rows(5).Cells(1).Value.ToString
        GOL_C7.Text = DG_CRUCES.Rows(6).Cells(1).Value.ToString
        GOL_C8.Text = DG_CRUCES.Rows(7).Cells(1).Value.ToString

        GOL_S1.Text = DG_CRUCES.Rows(0).Cells(2).Value.ToString
        GOL_S2.Text = DG_CRUCES.Rows(1).Cells(2).Value.ToString
        GOL_S3.Text = DG_CRUCES.Rows(2).Cells(2).Value.ToString
        GOL_S4.Text = DG_CRUCES.Rows(3).Cells(2).Value.ToString

        GOL_F1.Text = DG_CRUCES.Rows(3).Cells(3).Value.ToString
        GOL_F2.Text = DG_CRUCES.Rows(2).Cells(3).Value.ToString
        GOL_F3.Text = DG_CRUCES.Rows(1).Cells(3).Value.ToString
        GOL_F4.Text = DG_CRUCES.Rows(0).Cells(3).Value.ToString


        Return True

    End Function



    Private Sub GOL_O1_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(0).Cells(0).Value = GOL_O1.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(0).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O2.Focus()


                'PASE A CUARTOS 1


                If Val(GOL_O1.Text) > Val(GOL_O2.Text) Then
                    CUARTOS1.Text = A2.Text
                ElseIf Val(GOL_O1.Text) < Val(GOL_O2.Text) Then
                    CUARTOS1.Text = C2.Text
                Else

                    CUARTOS1.Text = " "

                End If
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O2.Focus()
            End If




        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_O2_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(1).Cells(0).Value = GOL_O2.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=2"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(1).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O3.Focus()

                'PASE A CUARTOS 1


                If Val(GOL_O1.Text) > Val(GOL_O2.Text) Then
                    CUARTOS2.Text = A2.Text
                ElseIf Val(GOL_O1.Text) < Val(GOL_O2.Text) Then
                    CUARTOS1.Text = C2.Text
                Else

                    CUARTOS1.Text = " "

                End If


            End If
            If e.KeyCode = Keys.Down Then
                GOL_O3.Focus()
            End If
        Catch ex As Exception






        End Try
    End Sub

    Private Sub GOL_O3_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(2).Cells(0).Value = GOL_O3.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=3"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(2).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O4.Focus()

                'PASE A CUARTOS 2

                If Val(GOL_O3.Text) > Val(GOL_O4.Text) Then
                    CUARTOS2.Text = D1.Text
                ElseIf Val(GOL_O3.Text) < Val(GOL_O4.Text) Then
                    CUARTOS2.Text = B3E3F3.Text
                Else

                    CUARTOS2.Text = " "

                End If



            End If
            If e.KeyCode = Keys.Down Then
                GOL_O4.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GOL_O4_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(3).Cells(0).Value = GOL_O4.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=4"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(3).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O5.Focus()

                'PASE A CUARTOS 2

                If Val(GOL_O3.Text) > Val(GOL_O4.Text) Then
                    CUARTOS3.Text = D1.Text
                ElseIf Val(GOL_O3.Text) < Val(GOL_O4.Text) Then
                    CUARTOS2.Text = B3E3F3.Text
                Else

                    CUARTOS2.Text = " "

                End If


            End If
            If e.KeyCode = Keys.Down Then
                GOL_O5.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GOL_O5_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O5.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(4).Cells(0).Value = GOL_O5.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=5"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(4).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O6.Focus()


                'PASE A CUARTOS 3

                If Val(GOL_O5.Text) > Val(GOL_O6.Text) Then
                    CUARTOS3.Text = C1.Text
                ElseIf Val(GOL_O5.Text) < Val(GOL_O6.Text) Then
                    CUARTOS3.Text = A3B3F3.Text

                Else

                    CUARTOS3.Text = " "

                End If



            End If
            If e.KeyCode = Keys.Down Then
                GOL_O6.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_O6_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O6.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(5).Cells(0).Value = GOL_O6.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=6"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(5).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O7.Focus()

                'PASE A CUARTOS 3

                If Val(GOL_O5.Text) > Val(GOL_O6.Text) Then
                    CUARTOS3.Text = C1.Text
                ElseIf Val(GOL_O5.Text) < Val(GOL_O6.Text) Then
                    CUARTOS3.Text = A3B3F3.Text
                Else

                    CUARTOS3.Text = " "

                End If



            End If
            If e.KeyCode = Keys.Down Then
                GOL_O7.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub GOL_O7_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O7.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(6).Cells(0).Value = GOL_O7.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=7"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(6).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O8.Focus()


                'PASE A CUARTOS 4

                If Val(GOL_O7.Text) > Val(GOL_O8.Text) Then
                    CUARTOS4.Text = E1.Text
                ElseIf Val(GOL_O7.Text) < Val(GOL_O8.Text) Then
                    CUARTOS4.Text = A3B3F3.Text
                Else

                    CUARTOS4.Text = " "

                End If


            End If
            If e.KeyCode = Keys.Down Then
                GOL_O8.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub




    Private Sub GOL_O8_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O8.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(7).Cells(0).Value = GOL_O8.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=8"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(7).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O9.Focus()


                'PASE A CUARTOS 4

                If Val(GOL_O7.Text) > Val(GOL_O8.Text) Then
                    CUARTOS4.Text = E1.Text
                ElseIf Val(GOL_O7.Text) < Val(GOL_O8.Text) Then
                    CUARTOS4.Text = A3B3F3.Text
                Else

                    CUARTOS4.Text = " "

                End If

            End If
            If e.KeyCode = Keys.Down Then
                GOL_O9.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_O9_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O9.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(8).Cells(0).Value = GOL_O9.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=9"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(8).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O10.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O10.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_O10_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O10.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(9).Cells(0).Value = GOL_O10.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=10"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(9).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O11.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O11.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_O11_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O11.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(10).Cells(0).Value = GOL_O11.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=11"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(10).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O12.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O12.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GOL_O12_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O12.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(11).Cells(0).Value = GOL_O12.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=12"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(11).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O13.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O13.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_O13_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O13.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(12).Cells(0).Value = GOL_O13.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=13"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(12).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O14.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O14.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_O14_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O14.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(13).Cells(0).Value = GOL_O14.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=14"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(13).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O15.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O15.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub GOL_O15_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O15.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(14).Cells(0).Value = GOL_O15.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=15"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(14).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O16.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O16.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_O16_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_O16.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(15).Cells(0).Value = GOL_O16.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_O=@G_O WHERE ID=16"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_O", DG_CRUCES.Rows(15).Cells(0).Value)
                COMANDO.ExecuteNonQuery()
                GOL_C1.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_C1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_C1_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_C1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(0).Cells(1).Value = GOL_C1.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_C=@G_C WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_C", DG_CRUCES.Rows(0).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                GOL_C2.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_C2.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub GOL_C2_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_C2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(1).Cells(1).Value = GOL_C2.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_C=@G_C WHERE ID=2"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_C", DG_CRUCES.Rows(1).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                GOL_C3.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_C3.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_C3_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_C3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(2).Cells(1).Value = GOL_C3.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_C=@G_C WHERE ID=3"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_C", DG_CRUCES.Rows(2).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                GOL_C4.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_C4.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GOL_C4_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_C4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(3).Cells(1).Value = GOL_C4.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_C=@G_C WHERE ID=4"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_C", DG_CRUCES.Rows(3).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                GOL_C5.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_C5.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_C5_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_C5.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(4).Cells(1).Value = GOL_C5.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_C=@G_C WHERE ID=5"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_C", DG_CRUCES.Rows(4).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                GOL_C6.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_C6.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_C6_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_C6.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(5).Cells(1).Value = GOL_C6.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_C=@G_C WHERE ID=6"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_C", DG_CRUCES.Rows(5).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                GOL_C7.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_C7.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_C7_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_C7.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(6).Cells(1).Value = GOL_C7.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_C=@G_C WHERE ID=7"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_C", DG_CRUCES.Rows(6).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                GOL_C8.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_C8.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_C8_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_C8.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(7).Cells(1).Value = GOL_C8.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_C=@G_C WHERE ID=8"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_C", DG_CRUCES.Rows(7).Cells(1).Value)
                COMANDO.ExecuteNonQuery()
                GOL_S1.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_S1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub GOL_S1_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_S1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(0).Cells(2).Value = GOL_S1.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_S=@G_S WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_S", DG_CRUCES.Rows(0).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                GOL_S2.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_S2.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_S2_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_S2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(1).Cells(2).Value = GOL_S2.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_S=@G_S WHERE ID=2"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_S", DG_CRUCES.Rows(1).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                GOL_S3.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_S3.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_S3_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_S3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(2).Cells(2).Value = GOL_S3.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_S=@G_S WHERE ID=3"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_S", DG_CRUCES.Rows(2).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                GOL_S4.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_S4.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub GOL_S4_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_S4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(3).Cells(2).Value = GOL_S4.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_S=@G_S WHERE ID=4"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_S", DG_CRUCES.Rows(3).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                GOL_F3.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_F3.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub







    Private Sub GOL_F3_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_F3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(0).Cells(2).Value = GOL_F3.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_F=@G_F WHERE ID=1"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_F", DG_CRUCES.Rows(0).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                GOL_F4.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_F4.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GOL_F4_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_F4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(1).Cells(2).Value = GOL_F4.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_F=@G_F WHERE ID=2"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_F", DG_CRUCES.Rows(1).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                GOL_F1.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_F1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GOL_F1_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_F1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(2).Cells(2).Value = GOL_F1.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_F=@G_F WHERE ID=3"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_F", DG_CRUCES.Rows(2).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                GOL_F2.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_F2.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub GOL_F2_KeyDown(sender As Object, e As KeyEventArgs) Handles GOL_F2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                DG_CRUCES.Rows(3).Cells(2).Value = GOL_F2.Text
                Dim CONSULTA As String = "UPDATE CRUCES SET G_F=@G_F WHERE ID=4"
                Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
                COMANDO.Parameters.Clear()
                COMANDO.Parameters.AddWithValue("@G_F", DG_CRUCES.Rows(3).Cells(2).Value)
                COMANDO.ExecuteNonQuery()
                GOL_O1.Focus()
            End If
            If e.KeyCode = Keys.Down Then
                GOL_O1.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GOL_O1_TextChanged(sender As Object, e As EventArgs) Handles GOL_O1.TextChanged
        Try
            GOL_O1.Text = Val(GOL_O1.Text)
            If GOL_O1.Text > 30 Then
                GOL_O1.Text = 0
                MessageBox.Show("NON TE PASES")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BT_NOVO_TORNEO_Click(sender As Object, e As EventArgs) Handles BT_NOVO_TORNEO.Click
        Try
            Dim NOME_TORNEO As String = TextBox1.Text
            Dim CONSULTA As String = "CREATE SCHEMA `" & NOME_TORNEO & "`"
            RUTA_SQL = "server=localhost;user id=root;password=toor"
            CONEXION_SQL = New MySqlConnection(RUTA_SQL)
            CONEXION_SQL.Open()

            Dim COMANDO As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO.ExecuteNonQuery()
            CONEXION_SQL.Close()

            RUTA_SQL = "server=localhost;user id=root;password=toor;database=" & NOME_TORNEO
            CONEXION_SQL = New MySqlConnection(RUTA_SQL)
            CONEXION_SQL.Open()



            CONSULTA = "CREATE TABLE `" & NOME_TORNEO & "` .`cruces` (`ID` INT(20) Not NULL, `G_O` INT(11) NULL DEFAULT NULL, `G_C` INT(11) NULL DEFAULT NULL, `G_S` INT(11) NULL DEFAULT NULL, `G_F` INT(11) NULL DEFAULT NULL, PRIMARY KEY(`ID`));"
            Dim COMANDO1 As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO1.ExecuteNonQuery()



            CONSULTA = "CREATE TABLE `" & NOME_TORNEO & "` .`grupo1` (`ID` INT(11) Not NULL AUTO_INCREMENT, `EQUIPO` VARCHAR(45) NULL DEFAULT NULL, `PARTIDO1L` INT(11) NULL DEFAULT 0, `PARTIDO1V` INT(11) NULL DEFAULT 0,
                 `PARTIDO2L` INT(11) NULL DEFAULT 0, `PARTIDO2V` INT(11) NULL DEFAULT 0, `PARTIDO3L` INT(11) NULL DEFAULT 0, `PARTIDO3V` INT(11) NULL DEFAULT 0, `GF` INT(11) NULL DEFAULT NULL,
                 `GC` INT(11) NULL DEFAULT NULL, `DG` INT(11) NULL DEFAULT NULL, `PTS` INT(11) NULL DEFAULT NULL, `CLAS` INT(11) NULL, PRIMARY KEY(`ID`));"
            Dim COMANDO2 As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO2.ExecuteNonQuery()

            CONSULTA = "CREATE TABLE `" & NOME_TORNEO & "` .`grupo2` (`ID` INT(11) Not NULL AUTO_INCREMENT, `EQUIPO` VARCHAR(45) NULL DEFAULT NULL, `PARTIDO1L` INT(11) NULL DEFAULT 0, `PARTIDO1V` INT(11) NULL DEFAULT 0,
                 `PARTIDO2L` INT(11) NULL DEFAULT 0, `PARTIDO2V` INT(11) NULL DEFAULT 0, `PARTIDO3L` INT(11) NULL DEFAULT 0, `PARTIDO3V` INT(11) NULL DEFAULT 0, `GF` INT(11) NULL DEFAULT NULL,
                 `GC` INT(11) NULL DEFAULT NULL, `DG` INT(11) NULL DEFAULT NULL, `PTS` INT(11) NULL DEFAULT NULL, `CLAS` INT(11) NULL, PRIMARY KEY(`ID`));"
            Dim COMANDO3 As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO3.ExecuteNonQuery()

            CONSULTA = "CREATE TABLE `" & NOME_TORNEO & "` .`grupo3` (`ID` INT(11) Not NULL AUTO_INCREMENT, `EQUIPO` VARCHAR(45) NULL DEFAULT NULL, `PARTIDO1L` INT(11) NULL DEFAULT 0, `PARTIDO1V` INT(11) NULL DEFAULT 0,
                 `PARTIDO2L` INT(11) NULL DEFAULT 0, `PARTIDO2V` INT(11) NULL DEFAULT 0, `PARTIDO3L` INT(11) NULL DEFAULT 0, `PARTIDO3V` INT(11) NULL DEFAULT 0, `GF` INT(11) NULL DEFAULT NULL,
                 `GC` INT(11) NULL DEFAULT NULL, `DG` INT(11) NULL DEFAULT NULL, `PTS` INT(11) NULL DEFAULT NULL, `CLAS` INT(11) NULL, PRIMARY KEY(`ID`));"
            Dim COMANDO4 As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO4.ExecuteNonQuery()

            CONSULTA = "CREATE TABLE `" & NOME_TORNEO & "` .`grupo4` (`ID` INT(11) Not NULL AUTO_INCREMENT, `EQUIPO` VARCHAR(45) NULL DEFAULT NULL, `PARTIDO1L` INT(11) NULL DEFAULT 0, `PARTIDO1V` INT(11) NULL DEFAULT 0,
                 `PARTIDO2L` INT(11) NULL DEFAULT 0, `PARTIDO2V` INT(11) NULL DEFAULT 0, `PARTIDO3L` INT(11) NULL DEFAULT 0, `PARTIDO3V` INT(11) NULL DEFAULT 0, `GF` INT(11) NULL DEFAULT NULL,
                 `GC` INT(11) NULL DEFAULT NULL, `DG` INT(11) NULL DEFAULT NULL, `PTS` INT(11) NULL DEFAULT NULL, `CLAS` INT(11) NULL, PRIMARY KEY(`ID`));"
            Dim COMANDO5 As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO5.ExecuteNonQuery()

            CONSULTA = "CREATE TABLE `" & NOME_TORNEO & "` .`grupo5` (`ID` INT(11) Not NULL AUTO_INCREMENT, `EQUIPO` VARCHAR(45) NULL DEFAULT NULL, `PARTIDO1L` INT(11) NULL DEFAULT 0, `PARTIDO1V` INT(11) NULL DEFAULT 0,
                 `PARTIDO2L` INT(11) NULL DEFAULT 0, `PARTIDO2V` INT(11) NULL DEFAULT 0, `PARTIDO3L` INT(11) NULL DEFAULT 0, `PARTIDO3V` INT(11) NULL DEFAULT 0, `GF` INT(11) NULL DEFAULT NULL,
                 `GC` INT(11) NULL DEFAULT NULL, `DG` INT(11) NULL DEFAULT NULL, `PTS` INT(11) NULL DEFAULT NULL, `CLAS` INT(11) NULL, PRIMARY KEY(`ID`));"
            Dim COMANDO6 As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO6.ExecuteNonQuery()

            CONSULTA = "CREATE TABLE `" & NOME_TORNEO & "` .`grupo6` (`ID` INT(11) Not NULL AUTO_INCREMENT, `EQUIPO` VARCHAR(45) NULL DEFAULT NULL, `PARTIDO1L` INT(11) NULL DEFAULT 0, `PARTIDO1V` INT(11) NULL DEFAULT 0,
                 `PARTIDO2L` INT(11) NULL DEFAULT 0, `PARTIDO2V` INT(11) NULL DEFAULT 0, `PARTIDO3L` INT(11) NULL DEFAULT 0, `PARTIDO3V` INT(11) NULL DEFAULT 0, `GF` INT(11) NULL DEFAULT NULL,
                 `GC` INT(11) NULL DEFAULT NULL, `DG` INT(11) NULL DEFAULT NULL, `PTS` INT(11) NULL DEFAULT NULL, `CLAS` INT(11) NULL, PRIMARY KEY(`ID`));"
            Dim COMANDO7 As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO7.ExecuteNonQuery()


            CONSULTA = "CREATE TABLE `" & NOME_TORNEO & "`.`horas` (`ID` INT(11) NOT NULL,`H_O1` VARCHAR(5) NULL DEFAULT NULL,`H_O2` VARCHAR(5) NULL DEFAULT NULL,`H_O3` VARCHAR(5) NULL DEFAULT NULL,`H_O4` VARCHAR(5) NULL DEFAULT NULL,`H_O5` VARCHAR(5) NULL DEFAULT NULL,
                   `H_O6` VARCHAR(5) NULL DEFAULT NULL,`H_O7` VARCHAR(5) NULL DEFAULT NULL,`H_O8` VARCHAR(5) NULL DEFAULT NULL,`H_C1` VARCHAR(5) NULL DEFAULT NULL,`H_C2` VARCHAR(5) NULL DEFAULT NULL,`H_C3` VARCHAR(5) NULL DEFAULT NULL,`H_C4` VARCHAR(5) NULL DEFAULT NULL,
                   `H_S1` VARCHAR(5) NULL DEFAULT NULL,`H_S2` VARCHAR(5) NULL DEFAULT NULL,`H_F1` VARCHAR(5) NULL DEFAULT NULL,`H_F2` VARCHAR(5) NULL DEFAULT NULL,PRIMARY KEY (`ID`));"
            Dim COMANDO8 As New MySqlCommand(CONSULTA, CONEXION_SQL)
            COMANDO8.ExecuteNonQuery()

            '/////////////////////////////////////////////////////////////////////////////////////


            Dim sql As String
            Dim cn As MySqlConnection
            Dim cm As MySqlCommand
            Dim da As MySqlDataAdapter
            Dim ds As DataSet
            cn = New MySqlConnection(RUTA_SQL)

            sql = "show  databases LIKE 'TORNEO%';" 'DEVOLVECHE TODAS AS BASES DE DATOS NAS QUE O SEU NOME EMPECE POR TORNEO




            'sql = "show  databases ;"

            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.CommandType = CommandType.Text
            cm.Connection = cn

            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)

            Dim list As New List(Of String)




            CB_TORNEO.DataSource = ds.Tables(0)

            CB_TORNEO.DisplayMember = "Database (TORNEO%)"

            Dim ARRAY_IT(100) As String




            For I = 0 To CB_TORNEO.Items.Count - 1
                If CB_TORNEO.Items(I) = "'information_schema'" Then
                    ARRAY_IT(I) = CB_TORNEO.Items(I)


                End If
            Next







            '///////////////////////////////////////////////////////////////////////////////////////

            'JUU7
        Catch ex As Exception

        End Try





    End Sub


End Class