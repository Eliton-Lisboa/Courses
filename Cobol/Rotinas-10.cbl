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

       PROCEDURE DIVISION.
       ROTINA01.
           DISPLAY 'Esta e a rotina 01.'.
           PERFORM ROTINA03.

       ROTINA02.
           DISPLAY 'Esta e a rotina 02.'.
           PERFORM ROTINA04.

       ROTINA03.
           DISPLAY 'Esta e a rotina 03.'.
           PERFORM ROTINA02.

       ROTINA04.
           DISPLAY 'Esta e a rotina 04.'.

           DISPLAY 'Finaliza o programa'.
           STOP RUN.
       END PROGRAM PROGRAM-NAME.
