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
           05  TEXTO1 PIC X(11) VALUE 'Este texto.'.
           05  TEXTO2 PIC X(36) VALUE
           'Pertence a la estrutura principal.'.
           05  SUB-VARIABLE-COMPUESTA.
               10  TEXTO1 PIC X(11) VALUE 'Este texto.'.
               10  TEXTO2 PIC X(36) VALUE
               'Pertence a la estrutura principal.'.
               10 SUB-SUB-VARIABLE-COMPUESTA.
                   15  TEXTO1 PIC X(11) VALUE 'Este texto.'.
                   15  TEXTO2 PIC X(36) VALUE
                   'Pertence a la estrutura principal.'.
      
       PROCEDURE DIVISION.
           DISPLAY VARIABLE-COMPUESTA.
           DISPLAY SUB-VARIABLE-COMPUESTA.
           DISPLAY SUB-SUB-VARIABLE-COMPUESTA.
           STOP RUN.
       END PROGRAM PROGRAM-NAME.
