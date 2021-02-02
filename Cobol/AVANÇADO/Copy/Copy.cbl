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
       COPY 'Archivo-fisico.cbl'

       DATA DIVISION.
       FILE SECTION.
       COPY 'Archivo-logico.cbl'

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
               VALUE 'Introduce un numero de telefono: '.
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
           OPEN I-O EMPEADOS-ARCHIVO.

       PROCEDIMENTO-DE-CIERRE.
           CLOSE EMPEADOS-ARCHIVO.

       AGREGAR-REGISTROS.
           MOVE 'N' TO ENTRADA.
           PERFORM OBTENER-CAMPOS
           UNTIL ENTRADA = 'S'.
           PERFORM ESCRIBIR-REGISTRO.
           PERFORM REINICIAR.

       OBTENER-CAMPOS.
           MOVE SPACE TO EMPLEADOS-REGISTRO.
           DISPLAY IDENTIFICADOR.
           ACCEPT EMPLEADOS-ID.
           DISPLAY NOMBRE.
           ACCEPT EMPLEADOS-NOMBRE.
           DISPLAY APELLIDOS.
           ACCEPT EMPLEADOS-APELLIDOS.
           DISPLAY EDAD.
           ACCEPT EMPLEADOS-EDAD.
           DISPLAY TELEFONO.
           ACCEPT EMPLEADOS-TELEFONO
           DISPLAY DIRECCION.
           ACCEPT EMPLEADOS-DIRECCION.
           PERFORM CONTINUAR.

       CONTINUAR.
           MOVE "S" TO ENTRADA.
           IF  EMPLEADOS-NOMBRE = SPACE
           MOVE "N" TO ENTRADA.

       ESCRIBIR-REGISTRO.
           WRITE EMPLEADOS-REGISTRO.

       REINICIAR.
           DISPLAY
           'Desea almacenar otro registro en la base de datos?'.
           ACCEPT SI-NO.
           IF SI-NO = "s"
               MOVE "S" TO SI-NO.
           IF SI-NO NOT = "S"
               MOVE "N" TO SI-NO.

       END PROGRAM PROGRAM-NAME.
