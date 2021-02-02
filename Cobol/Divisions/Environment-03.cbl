      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. PROGRAM-NAME.

       ENVIRONMENT DIVISION.
       CONFIGURATION SECTION.

      * Aonde foi escrito o código
       SOURCE-COMPUTER. IBM*****.

      * Aonde vai poder rodar o programa
       OBJECT-COMPUTER. IBM*****.

      * Colocar constantes de linguagem ^ ?
       SPECIAL-NAMES.

       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
       SELECT [OPTIONAL] 'Nome do arquivo'.
       ASSIGN TO 'Tipo de dispositivo'.
       ORGANIZATION IS 'Tipo de organização'
       ACCESS MODE IS 'Modo de acesso ao arquivo'.
       RECORD KEY IS 'Chave do registro'.
       WITH DUPLICATES
       STATUS IS. 'Estado do arquivo'

       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
       PROCEDURE DIVISION.
           DISPLAY 'Hello, world!'.
           STOP RUN.
       END PROGRAM PROGRAM-NAME.