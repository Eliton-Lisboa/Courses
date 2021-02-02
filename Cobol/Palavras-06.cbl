      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
      *Tipos de palavras:
      *    1. Reservadas       ^ ?
      *    2. Nomes do sistema ^ Divisions, sections
      *        1. Precisa conter ponto no final da linha
      *    3. Nomes de funçoes
      *        1. Precisa conter ponto no final da linha
      *    4. Variaveis
      *        1. Nao pode ter mais de 31 caracteres
      *        2. Não pode começar com acentos
      *        3. Apenas de 0-9 e de A-Z

       IDENTIFICATION DIVISION.
       PROGRAM-ID. PROGRAM-NAME.
       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
       PROCEDURE DIVISION.
           DISPLAY 'Hello, world!'.
           STOP RUN.
       END PROGRAM PROGRAM-NAME.