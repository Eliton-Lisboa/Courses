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
      * Arquivos fisicos
           SELECT OPTIONAL EMPLEADOS-ARCHIVO
           ASSIGN TO 'empleados.dat'
           ORGANIZATION IS SEQUENTIAL.

       DATA DIVISION.
       FILE SECTION.
      * Arquivos logicos
       FD  EMPLEADOS-ARCHIVO.
           01 EMPLEADOS-REGISTROS.
               05 EMPLEMEADOS-ID PIC X(6).
               05 EMPLEMEADOS-NOMBRE PIC X(25).
               05 EMPLEMEADOS-APELLIDOS PIC X(35).
               05 EMPLEMEADOS-EDAD PIC X(3).
               05 EMPLEMEADOS-TELEFONO PIC X(9).
               05 EMPLEMEADOS-DIRECCION PIC X(35).

       WORKING-STORAGE SECTION.
           01 INDENTIFICADOR PIC X(36)
               VALUE 'Introduce un ID del nuevo empleado: '.
           01 NOMBRE PIC X(25)
               VALUE 'Introduce un nombre de empleado: '.
           01 APELLIDOS PIC X(25)
               VALUE 'Introduce los apeidos: '.



       PROCEDURE DIVISION.
           DISPLAY 'Hello, World!'.

           STOP RUN.
       END PROGRAM PROGRAM-NAME.
