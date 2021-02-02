      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. PROGRAM-NAME.
       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.

       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
           77  NUM1 PIC 9(2) VALUE 16.
           77  NUM2 PIC 9(2) VALUE 10.
           77  NUM3 PIC 9(2) VALUE 20.

       PROCEDURE DIVISION.

           EVALUATE TRUE
               WHEN NUM1 = 1
                   COMPUTE NUM1 = NUM2 + NUM3
                   DISPLAY NUM1

               WHEN NUM1 = 10
                   COMPUTE NUM1 = NUM1 + NUM3
                   DISPLAY NUM1

               WHEN NUM1 = 15
                   COMPUTE NUM1 = NUM2 - NUM3
                   DISPLAY NUM1

               WHEN OTHER
                   DISPLAY 'Valor no contemplado'
           END-EVALUATE.

           STOP RUN.
       END PROGRAM PROGRAM-NAME.
