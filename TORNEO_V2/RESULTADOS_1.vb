
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class RESULTADOS_1

    Public GOLES_C As Integer
    Public GOLES_F As Integer

    'GRUPO 1

    Private Sub RESULTADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGA_NOMES()
    End Sub


    Function CARGA_NOMES() As Boolean



        'GRUPO 1
        If Form1.CARGAR_RESULTADOS_G1 = True Then
            Try
                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G1.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(1).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G1.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(0).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G1.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(3).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G1.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(2).Cells(0).Value
                        End Select
                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G1.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(2).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G1.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(3).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G1.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(0).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G1.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(0).Cells(0).Value
                        End Select
                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G1.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(3).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G1.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(2).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G1.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(1).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G1.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G1.Rows(10).Cells(0).Value
                        End Select

                End Select




            Catch ex As Exception

            End Try
        End If

        'GRUPO 2
        If Form1.CARGAR_RESULTADOS_G2 = True Then
            Try
                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G2.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(1).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G2.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(0).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G2.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(3).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G2.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(2).Cells(0).Value
                        End Select
                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G2.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(2).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G2.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(3).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G2.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(0).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G2.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(0).Cells(0).Value
                        End Select
                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G2.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(3).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G2.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(2).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G2.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(1).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G2.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(10).Cells(0).Value
                        End Select

                End Select




            Catch ex As Exception

            End Try
        End If


        'GRUPO 3
        If Form1.CARGAR_RESULTADOS_G3 = True Then
            Try
                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G3.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(1).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G3.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(0).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G3.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G2.Rows(3).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G2.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(2).Cells(0).Value
                        End Select
                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G3.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(2).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G3.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(3).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G3.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(0).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G3.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(0).Cells(0).Value
                        End Select
                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G3.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(3).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G3.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(2).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G3.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(1).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G3.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G3.Rows(10).Cells(0).Value
                        End Select

                End Select




            Catch ex As Exception

            End Try
        End If


        'GRUPO 4
        If Form1.CARGAR_RESULTADOS_G4 = True Then
            Try
                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G4.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(1).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G4.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(0).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G4.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(3).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G4.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(2).Cells(0).Value
                        End Select
                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G4.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(2).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G4.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(3).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G4.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(0).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G4.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(0).Cells(0).Value
                        End Select
                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G4.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(3).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G4.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(2).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G4.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(1).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G4.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G4.Rows(10).Cells(0).Value
                        End Select
                End Select
            Catch ex As Exception

            End Try
        End If




        'GRUPO 5
        If Form1.CARGAR_RESULTADOS_G5 = True Then
            Try
                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G5.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(1).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G5.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(0).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G5.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(3).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G5.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(2).Cells(0).Value
                        End Select
                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G5.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(2).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G5.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(3).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G5.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(0).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G5.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(0).Cells(0).Value
                        End Select
                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G5.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(3).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G5.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(2).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G5.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(1).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G5.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G5.Rows(10).Cells(0).Value
                        End Select
                End Select
            Catch ex As Exception

            End Try
        End If


        'GRUPO 6
        If Form1.CARGAR_RESULTADOS_G6 = True Then
            Try
                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G6.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(1).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G6.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(0).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G6.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(3).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G6.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(2).Cells(0).Value
                        End Select
                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G6.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(2).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G6.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(3).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G6.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(0).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G6.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(0).Cells(0).Value
                        End Select
                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Label1.Text = Form1.DG_G6.Rows(0).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(3).Cells(0).Value
                            Case 1
                                Label1.Text = Form1.DG_G6.Rows(1).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(2).Cells(0).Value
                            Case 2
                                Label1.Text = Form1.DG_G6.Rows(2).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(1).Cells(0).Value
                            Case 3
                                Label1.Text = Form1.DG_G6.Rows(3).Cells(0).Value & "  VS  " & Form1.DG_G6.Rows(10).Cells(0).Value
                        End Select
                End Select
            Catch ex As Exception

            End Try
        End If




        Return True
    End Function

    Private Sub TB_1_TextChanged(sender As Object, e As EventArgs) Handles TB_1.TextChanged
        Try
            TB_1.Text = Val(TB_1.Text)
            If Val(TB_1.Text) < 0 Then
                TB_1.Text = (Val(TB_1.Text) * -1)
            End If
            TB_1.BackColor = Color.Azure
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TB_1_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_1.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                If Val(TB_1.Text) < 0 Then
                    TB_1.Text = (Val(TB_1.Text) * -1)
                End If
                GOLES_C = CInt(TB_1.Text)
                TB_1.BackColor = Color.White
                TB_2.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TB_2_TextChanged(sender As Object, e As EventArgs) Handles TB_2.TextChanged
        Try
            TB_2.Text = CInt(TB_2.Text)
            If Val(TB_2.Text) < 0 Then
                TB_2.Text = (Val(TB_2.Text) * -1)
            End If
            TB_2.BackColor = Color.Azure
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TB_2_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_2.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                If Val(TB_2.Text) < 0 Then
                    TB_2.Text = (Val(TB_2.Text) * -1)
                End If
                GOLES_C = CInt(TB_2.Text)
                TB_2.BackColor = Color.White
                B_ACEPTAR.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub B_ACEPTAR_Click(sender As Object, e As EventArgs) Handles B_ACEPTAR.Click


        'GRUPO 1
        If Form1.CARGAR_RESULTADOS_G1 = True Then
            Try

                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO1 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO1 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                        End Select


                End Select
            Catch ex As Exception
            End Try
        End If




        'GRUPO 2
        If Form1.CARGAR_RESULTADOS_G2 = True Then
            Try

                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO2 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO2 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                        End Select


                End Select
            Catch ex As Exception
            End Try
        End If




        'GRUPO 3
        If Form1.CARGAR_RESULTADOS_G3 = True Then
            Try

                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO3 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO3 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                        End Select


                End Select
            Catch ex As Exception
            End Try
        End If



        'GRUPO 4
        If Form1.CARGAR_RESULTADOS_G4 = True Then
            Try

                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO4 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO4 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                        End Select


                End Select
            Catch ex As Exception
            End Try
        End If



        'GRUPO 5
        If Form1.CARGAR_RESULTADOS_G5 = True Then
            Try

                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO5 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                        End Select


                End Select
            Catch ex As Exception
            End Try
        End If


        'GRUPO 6
        If Form1.CARGAR_RESULTADOS_G6 = True Then
            Try

                Select Case Form1.COL_SEL
                    Case 1
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO1L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO1V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO1L=@PARTIDO1L, PARTIDO1V=@PARTIDO1V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO1V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 2
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO2L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO2V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO5 SET PARTIDO2L=@PARTIDO2L, PARTIDO2V=@PARTIDO2V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO2V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                        End Select

                    Case 3
                        Select Case Form1.ROW_SEL
                            Case 0
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 1)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 4)
                                COMANDO2.ExecuteNonQuery()

                            Case 1
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 2)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 3)
                                COMANDO2.ExecuteNonQuery()

                            Case 2
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 3)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 2)
                                COMANDO2.ExecuteNonQuery()

                            Case 3
                                Dim CONSULTA As String = "UPDATE GRUPO6 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO As New MySqlCommand(CONSULTA, Form1.CONEXION_SQL)
                                COMANDO.Parameters.AddWithValue("@PARTIDO3L", Val(TB_1.Text))
                                COMANDO.Parameters.AddWithValue("@PARTIDO3V", Val(TB_2.Text))
                                COMANDO.Parameters.AddWithValue("@ID", 4)
                                COMANDO.ExecuteNonQuery()

                                Dim CONSULTA2 As String = "UPDATE GRUPO6 SET PARTIDO3L=@PARTIDO3L, PARTIDO3V=@PARTIDO3V  WHERE ID=@ID"
                                Dim COMANDO2 As New MySqlCommand(CONSULTA2, Form1.CONEXION_SQL)
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3L", Val(TB_2.Text))
                                COMANDO2.Parameters.AddWithValue("@PARTIDO3V", Val(TB_1.Text))
                                COMANDO2.Parameters.AddWithValue("@ID", 1)
                                COMANDO2.ExecuteNonQuery()

                        End Select


                End Select
            Catch ex As Exception
            End Try
        End If











        Form1.CARGA_SQL()
        Form1.DG_G1.Refresh()
        Form1.DG_G2.Refresh()
        Form1.DG_G3.Refresh()
        Form1.DG_G4.Refresh()
        Form1.DG_G5.Refresh()
        Form1.DG_G6.Refresh()

        Form1.CARGAR_RESULTADOS_G1 = False
        Form1.CARGAR_RESULTADOS_G2 = False
        Form1.CARGAR_RESULTADOS_G3 = False
        Form1.CARGAR_RESULTADOS_G4 = False
        Form1.CARGAR_RESULTADOS_G5 = False
        Form1.CARGAR_RESULTADOS_G6 = False


        Me.Close()

    End Sub

    Private Sub B_CANCELAR_Click(sender As Object, e As EventArgs) Handles B_CANCELAR.Click
        Form1.CARGAR_RESULTADOS_G1 = False
        Form1.CARGAR_RESULTADOS_G2 = False
        Form1.CARGAR_RESULTADOS_G3 = False
        Form1.CARGAR_RESULTADOS_G4 = False
        Form1.CARGAR_RESULTADOS_G5 = False
        Form1.CARGAR_RESULTADOS_G6 = False
        Me.Close()
    End Sub
End Class