' FormatDateTime é composto de 2 parâmetros
'   Valor de tempo               -->  Ex: now()
'   Formato de saida para texto  -->  Format
'     0. vbGeneralDate - (dd/mm/aaaa hh:mm:ss) "Default"
'     1. vbLongDate    - "day", "day number" de "month" de "Yers"
'     2. vbShortDate   - (dd/mm/aaa)
'     3. vbLongTime    - (hh:mm:ss)
'     4. vbShortTime   - (hh:mm)
A = now()

MsgBox FormatDateTime(A)
MsgBox FormatDateTime(A,0)
MsgBox FormatDateTime(A,1)
MsgBox FormatDateTime(A,2)
MsgBox FormatDateTime(A,3)
MsgBox FormatDateTime(A,4)
