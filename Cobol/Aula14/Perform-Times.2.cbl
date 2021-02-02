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
           PERFORM OPERATION 100 TIMES.
           STOP RUN.

       OPERATION.
           ADD 1 TO NUMERO.
           DISPLAY NUMERO.
           
       END PROGRAM PROGRAM-NAME.