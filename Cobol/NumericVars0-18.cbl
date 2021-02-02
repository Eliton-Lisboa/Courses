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
       01  NUM1 PIC 9999 VALUE 500.
       01  NUM2 PIC 9999 VALUE 100.
      *         O 'Z' Vai subrimir o Zero
       01  RESULTADO PIC Z9999.
      
       PROCEDURE DIVISION.
           COMPUTE RESULTADO = NUM1 + NUM2.
           DISPLAY RESULTADO.
           STOP RUN.
       END PROGRAM PROGRAM-NAME.