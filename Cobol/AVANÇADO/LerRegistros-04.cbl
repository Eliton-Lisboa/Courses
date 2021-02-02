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
       ORGANIZATION IS LINE SEQUENTIAL.

       DATA DIVISION.
       FILE SECTION.
       FD  EMPEADOS-ARCHIVO.
           01  EMPEADOS-REGISTRO.
               05  EMPEADOS-ID PIC X(6).
               05  EMPEADOS-NOMBRE PIC X(25).
               05  EMPEADOS-APELLIDOS PIC X(35).
               05  EMPEADOS-EDAD PIC X(3).
               05  EMPEADOS-TELEFONO PIC X(9).
               05  EMPEADOS-DIRECCION PIC X(35).

       WORKING-STORAGE SECTION.
           01  PRESENTACION.
               05  TEXTO-ID PIC X(3) VALUE 'ID:'.
               05  MUESTRA-ID PIC X(6).
               05  TEXTO-NOMBRE PIC X(7) VALUE 'Nombre:'.
               05  MUESTRA-NOMBRE PIC X(15).
               05  TEXTO-APELLIDOS PIC X(10) VALUE 'Apellidos:'.
               05  MUESTRA-APELLIDOS PIC X(20).
               05  TEXTO-EDAD PIC X(5) VALUE 'Edad:'.
               05  MUESTRA-EDADE PIC X(3).
               05  TEXTO-TELEFONO PIC X(9) VALUE 'Telefono:'.
               05  MUESTRA-TELEFONO PIC X(10).
               05  TEXTO-DIRECCION PIC X(10) VALUE 'Direccion:'.
               05  MUESTRA-DIRECCION PIC X(35).

           01  FIN-DEL-ARCHIVO PIC X.
           01  MAXIMO-REGISTROS PIC 99.
           01  GUARDA-ENTER PIC X.

       PROCEDURE DIVISION.

       EMPIEZA-PROGRAMA.
           PERFORM APERTURA-ARCHIVO.
           MOVE ZEROES TO MAXIMO-REGISTROS.
           MOVE '1' TO FIN-DEL-ARCHIVO.
           PERFORM LEE-SIGUIENTE-REGISTRO.
           PERFORM MUESTRA-REGISTROS
           UNTIL FIN-DEL-ARCHIVO = '0'.
           PERFORM CIERRE-ARCHIVO.

       PROGRAM-DONE.
           STOP RUN.

       APERTURA-ARCHIVO.
           OPEN INPUT EMPEADOS-ARCHIVO.

       CIERRE-ARCHIVO.
           CLOSE EMPEADOS-ARCHIVO.

       MUESTRA-REGISTROS.
           PERFORM MUESTRA-CAMPOS.
           PERFORM LEE-SIGUIENTE-REGISTRO.

       MUESTRA-CAMPOS.
           IF MAXIMO-REGISTROS = 10
               PERFORM PULSAR-ENTER.
           MOVE EMPEADOS-ID TO MUESTRA-ID.
           MOVE EMPEADOS-NOMBRE TO MUESTRA-NOMBRE.
           MOVE EMPEADOS-APELLIDOS TO MUESTRA-APELLIDOS.
           MOVE EMPEADOS-EDAD TO MUESTRA-EDADE.
           MOVE EMPEADOS-TELEFONO TO MUESTRA-TELEFONO.
           MOVE EMPEADOS-DIRECCION TO MUESTRA-DIRECCION.
           DISPLAY PRESENTACION.
           ADD 1 TO MAXIMO-REGISTROS.

       LEE-SIGUIENTE-REGISTRO.
           READ EMPEADOS-ARCHIVO NEXT RECORD
           AT END
           MOVE '0' TO FIN-DEL-ARCHIVO.

       PULSAR-ENTER.
           DISPLAY
               'Presione la tecla ENTER para ver la seguinte pagina...'.
           ACCEPT GUARDA-ENTER.
           MOVE ZEROES TO MAXIMO-REGISTROS.

       END PROGRAM PROGRAM-NAME.
