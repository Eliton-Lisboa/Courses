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
       01  NUM1 PIC 9(4).
       01  NUM2 PIC 9(4).
       01  RESULTADO PIC 9(5).

       PROCEDURE DIVISION.
           DISPLAY 'Digite o primeiro numero: '.
           ACCEPT NUM1.
           DISPLAY 'Digite o segundo numero: '.
           ACCEPT NUM2.

           ADD NUM1 TO NUM2 GIVING RESULTADO.

           IF RESULTADO > 50
               DISPLAY 'RESULTADO e maior que 50'
           ELSE
               DISPLAY 'RESULTADO e menor ou igual a 50'
           END-IF.

           STOP RUN.
       END PROGRAM PROGRAM-NAME.
