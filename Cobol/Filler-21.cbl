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
       01  VARIABLE-COMPUESTA.
           05  TEXTO1 PIC X(15) VALUE 'Texto 1 - '.
           05  FILLER PIC X(15) VALUE 'Texto FILLER - '.
           05  TEXTO2 PIC X(15) VALUE 'Texto 2.'.
      
       PROCEDURE DIVISION.
           DISPLAY VARIABLE-COMPUESTA.
           MOVE 'Nuevo valor - ' TO TEXTO1.
           MOVE 'Nuevo valor - ' TO TEXTO2.
           MOVE 'Nuevo valor - ' TO FILLER.
      *                              ERRO
           DISPLAY VARIABLE-COMPUESTA.
           
           STOP RUN.
       END PROGRAM PROGRAM-NAME.
