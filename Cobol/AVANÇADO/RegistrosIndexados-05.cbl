      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. PROGRAM-NAME.
       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.

       FILE-CONTROL.
       SELECT OPTIONAL EMPEADOS-ARCHIVO
       ASSIGN TO 'empleados.dat'
       ORGANIZATION IS INDEXED
       RECORD KEY IS EMPEADOS-ID
       ACCESS MODE IS DYNAMIC.

       DATA DIVISION.
       FILE SECTION.
       FD  EMPEADOS-ARCHIVO.
           01  EMPEADOS-REGISTRO.
               05  EMPEADOS-ID PIC 9(6).
               05  EMPEADOS-NOMBRE PIC X(25).
               05  EMPEADOS-APELLIDOS PIC X(35).
               05  EMPEADOS-EDAD PIC 9(3).
               05  EMPEADOS-TELEFONO PIC X(9).
               05  EMPEADOS-DIRECCION PIC X(35).

       WORKING-STORAGE SECTION.
           01  INDENTIFICADOR PIC X(36)
               VALUE 'Introduce un ID del nuevo empleados:'.
           01  NOMBRE PIC X(33)
               VALUE 'Introduce un Nombre de empleado:'.
           01  APELLIDOS PIC X(25)
               VALUE 'Introduce los Apelliodos:'.
           01  EDAD PIC X(19)
               VALUE 'Introduce la Edad:'.
           01  TELEFONO PIC X(33)
               VALUE 'Introduce un numero de telefono:'.
           01 DIRECCION PIC X(25)
               VALUE 'Introduce una direcction:'.

           01  SI-NO PIC X.
           01  ENTRADA PIC X.

       PROCEDURE DIVISION.
       MAIN-LOGIC SECTION.
       PROGRAM-BEGIN.

           PERFORM PROCEDIMENTO-DE-APERTURA.
           MOVE 'S' TO SI-NO.
           PERFORM AGREGAR-REGISTROS
           UNTIL SI-NO = 'N'.
           PERFORM PROCEDIMENTO-DE-CIERRE.

       FINALIZA-PROGRAMA.
           STOP RUN.

       PROCEDIMENTO-DE-APERTURA.
           OPEN OUTPUT EMPEADOS-ARCHIVO.

       PROCEDIMENTO-DE-CIERRE.
           CLOSE EMPEADOS-ARCHIVO.

       AGREGAR-REGISTROS.
           MOVE 'N' TO ENTRADA.
           PERFORM OBTENER-CAMPOS
           UNTIL ENTRADA = 'S'.
           PERFORM ESCRIBIR-REGISTRO.
           PERFORM REINICIAR.

       OBTENER-CAMPOS.
           MOVE SPACE TO EMPEADOS-REGISTRO.
           DISPLAY INDENTIFICADOR.
           ACCEPT EMPEADOS-ID.
           DISPLAY NOMBRE.
           ACCEPT EMPEADOS-NOMBRE.
           DISPLAY APELLIDOS.
           ACCEPT EMPEADOS-APELLIDOS.
           DISPLAY EDAD.
           ACCEPT EMPEADOS-EDAD.
           DISPLAY TELEFONO.
           ACCEPT EMPEADOS-TELEFONO
           DISPLAY DIRECCION.
           ACCEPT EMPEADOS-DIRECCION.
           PERFORM CONTINUAR.

       CONTINUAR.
           MOVE "S" TO ENTRADA.
           IF  EMPEADOS-NOMBRE = SPACE
           MOVE "N" TO ENTRADA.

       ESCRIBIR-REGISTRO.
           WRITE EMPEADOS-REGISTRO.

       REINICIAR.
           DISPLAY
               "¿Desea almacenar otro registro en la base de datos?".
           ACCEPT SI-NO.
           IF SI-NO = "s"
               MOVE "S" TO SI-NO.
           IF SI-NO NOT = "S"
               MOVE "N" TO SI-NO.

       END PROGRAM PROGRAM-NAME.
