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
           PERFORM VARYING NUMERO FROM 1 BY 1 UNTIL NUMERO > 100.
               DISPLAY NUMERO
           END-PERFORM
           STOP RUN.
           
       END PROGRAM PROGRAM-NAME.