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
       01  SALUDO PIC A(26).
       01  TITULO PIC A(40) VALUE 'Tutoria de cobol'.
       01  NUMERO PIC 9(1) VALUE 5.

      * Todo o programa ^ html: body
       PROCEDURE DIVISION.

      * Mostrar na tela
           DISPLAY 'Hello, World!'.
      * Dar valor a variaveis
           MOVE 'teste de move value to var' TO SALUDO.
           DISPLAY 'Este e um ' SALUDO.
           DISPLAY 'Titulo: ' TITULO.
           DISPLAY 'Esta e a aula de numero ' NUMERO.
      * Parar programa
           STOP RUN.
       END PROGRAM PROGRAM-NAME.
