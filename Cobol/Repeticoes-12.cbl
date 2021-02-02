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
       01  NUMERO PIC 99.
       01  MULTIPLICADOR PIC 9999.
       01  RESULTADO PIC 9999.
       01  SALIDA PIC XXXXX.

       PROCEDURE DIVISION.

       INICIO.
           DISPLAY "Para salir introduce 'salir' en la consola".
           DISPLAY 'Para multiplicar pulsa intro.'.
           ACCEPT SALIDA.
           IF SALIDA = 'salir'
               GO TO FINALIZAR
           ELSE
               PERFORM REINICIAR-PROGRAMA.
               PERFORM INTRODUCE-NUMERO.
               PERFORM MOSTRAR-TABELA.

       FINALIZAR.
           STOP RUN.

       REINICIAR-PROGRAMA.
           MOVE 0 TO MULTIPLICADOR.

       INTRODUCE-NUMERO.
           DISPLAY 'Introduce um numero.'.
           ACCEPT NUMERO.

       MOSTRAR-TABELA.
           DISPLAY 'La tabela del ' NUMERO ':'.
           PERFORM CALCULOS.

       CALCULOS.
           ADD 1 TO MULTIPLICADOR.
           COMPUTE RESULTADO = NUMERO * MULTIPLICADOR.
           DISPLAY NUMERO ' * ' MULTIPLICADOR ' = 'RESULTADO.
           IF MULTIPLICADOR < 10
               GO TO CALCULOS.
           PERFORM INICIO.

       END PROGRAM PROGRAM-NAME.
