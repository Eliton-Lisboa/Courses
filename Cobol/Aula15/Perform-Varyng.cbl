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
       01  NUMERO PIC 999.
      
       PROCEDURE DIVISION.

       INICIO.
           PERFORM OPERATION VARYING FROM 1 BY 1 UNIT NUMERO > 100.
           STOP RUN.

       OPERATION.
           DISPLAY NUMERO.
           
       END PROGRAM PROGRAM-NAME.