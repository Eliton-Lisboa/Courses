' Missão
'     Senário01 - Número informado for 0
'         Resultado: -"O campo informado é igual a zero."
'     Senário02 - Número informado for >0
'         Resultado: -"O campo informado é menor a zero."
'     Senário03 - Número informado for <0
'         Resultado: -"O campo informado é maior a zero."

Numero = InputBox( "Informe um numero: " ) + 0
Resultado = " "

' =  - Igual
' <  - Menor
' >  - Maior
' <= - Menor ou igual
' >= - Maior ou igual
' <> - Diferente

If Numero = 0 then
    Resultado = "O campo informado e igual a zero."
ElseIf Numero < 0 then
    Resultado = "O campo informado e menor a zero."
Else
    Resultado = "O campo informado e maior a zero."
end if

MsgBox Resultado