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
       01 OPTION PIC X.

       PROCEDURE DIVISION.

       PERGUNTA.
           PERFORM CONTINUACAO.

           IF OPTION = 'N' OR OPTION = 'n'
               GO TO END-PROGRAM.
           IF OPTION = 'S' OR OPTION = 'S'
               PERFORM PROGRAMA
           ELSE
               DISPLAY "Por favor, digite 'S' ou 'N'"
           END-IF.

       END-PROGRAM.
           STOP RUN.

       CONTINUACAO.
           DISPLAY 'Executar o programa (S/N)? '.
           ACCEPT OPTION.

       PROGRAMA.
           DISPLAY 'Executa o programa! '.

           STOP RUN.
       END PROGRAM PROGRAM-NAME.
