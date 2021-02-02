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
       77  NUM1 PIC 9(5).
      *> 77  NUM3 PIC 9(5).  ^ Error
       77  NUM2 REDEFINES NUM1 PIC X(5).
      
       PROCEDURE DIVISION.
           
           MOVE 10 TO NUM1.
           MOVE 10 TO NUM2.

           DISPLAY NUM1 NUM2.
      
           STOP RUN.
       END PROGRAM PROGRAM-NAME.