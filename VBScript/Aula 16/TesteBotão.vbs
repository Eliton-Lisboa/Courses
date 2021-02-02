' Retornos do MsgBox
'     1. Ok
'     2. Cancel
'     3. Abort
'     4. Retry
'     5. Ignore
'     6. Yes
'     7. No

A = MsgBox( "Teste o botao", 4 )
Resultado = ""

' Senário01 - Sim
'     Resultado: -"Foi precisando o botão Sim."
' Senário02 - Não
'     Resultado: -"Foi precisando o botão Não."

If A = 6 then
    Resultado = "Foi precisando o botao Sim."
ElseIf A = 7 then
    Resultado = "Foi precisando o botao Nao."
end if

MsgBox Resultado
