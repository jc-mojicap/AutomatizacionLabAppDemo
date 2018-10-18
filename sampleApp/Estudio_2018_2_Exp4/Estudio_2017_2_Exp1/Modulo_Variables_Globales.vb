Module Modulo_Variables_Globales

    Public cerrar As MsgBoxResult
    Public sujeto, experimento, grupo, codigo As String 'Declaración de la variable grupo como variable global
    Public Archivo As String = My.Computer.FileSystem.SpecialDirectories.Desktop
    Public oBook As Object
    Public oExcel As Object
    Public oSheet As Object

    Public vtipoEnsayo, vInstrucciones, vcheckFinalPublic As String
    Public aFase, aContador, aRespuestaDada, aTiempodeReaccion As String
    Public aEnsayos((1000), (4))
    Public aNumerosaleatoreos(1000)
    Public sigFase, FaseAux, fs, VnumFase, acierto, vSesion, bloque, auxBloque, repetirF1_NpF3, cant_bloque_F3, Instr_Audio, numero_Celda, auxcNumero_Celda, contBloqueFase_3 As Integer
    Public vMostrarMensaje As Boolean
    Public RepiteFase, auxMsjRepoteFase, pasoSesion1 As Boolean
    Public varInstruccion As Integer
    Public numeroFase As Integer


    Public nombre_Carpeta_Resultados As String = "RESULTADOS - Estudio 2018-2 (Exp_4)" 'Asigna nombre a la carpeta del participante
    Public nombre_archivo_txt As String
    Public nombre_Repite_Fase As String
End Module
