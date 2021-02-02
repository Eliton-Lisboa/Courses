      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. PROGRAM-NAME.
       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
       01  NOMBRE PIC X(15).
       01  APELIDO PIC X(20).
       01  EDAD PIC 99.

       PROCEDURE DIVISION.
       SOLICITAR-DADOS.
           PERFORM SOLICITAR-NOMBRE THRU SOLICITAR-APELIDOS.
           PERFORM SOLICITAR-EDAD.
           DISPLAY 'Nombre: ' NOMBRE ', Apelido: ' APELIDO
                   ', EDAD:' EDAD.

           STOP RUN.

       SOLICITAR-NOMBRE.
           DISPLAY 'Introduce tu nombre:'.
           ACCEPT NOMBRE.

       SOLICITAR-APELIDOS.
           DISPLAY 'Introduce tus apellidos:'.
           ACCEPT APELIDO.

       SOLICITAR-EDAD.
           DISPLAY 'Introduce tu edad:'.
           ACCEPT EDAD.

       END PROGRAM PROGRAM-NAME.
