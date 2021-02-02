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
       77  VARIABLE-SIMPLES PIC 9 VALUE ZERO.
      * Para indentificar melhor oque é uma variavel simbles e composta

       01  VARIABLES-COMPUESTA.
           02  SUB-VARIABLE1 PIC X VALUE SPACE.
           02  SUB-VARIABLE2 PIC 9 VALUE ZERO.

       01  VARIABLES-COMPUESTA2 PIC 999.
           88  SUB-VARIABLE3 VALUE 12.
           88  SUB-VARIABLE4 VALUE 2.

       PROCEDURE DIVISION.
           DISPLAY 'Hello, World!'.
           STOP RUN.
       END PROGRAM PROGRAM-NAME.
