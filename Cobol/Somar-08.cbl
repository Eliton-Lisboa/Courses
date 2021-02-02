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
           DISPLAY 'O resultado somado e: ' RESULTADO

           SUBTRACT NUM1 FROM NUM2 GIVING RESULTADO.
           DISPLAY 'O resultado subtraido e: ' RESULTADO

           MULTIPLY NUM1 BY NUM2 GIVING RESULTADO.
           DISPLAY 'O resultado multiplicado e: ' RESULTADO

           DIVIDE NUM1 BY NUM2 GIVING RESULTADO.
           DISPLAY 'O resultado dividido e: ' RESULTADO

           STOP RUN.
       END PROGRAM PROGRAM-NAME.
