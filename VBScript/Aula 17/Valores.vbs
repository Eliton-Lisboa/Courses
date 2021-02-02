' IsNumeric possui 1 parâmetro
'     Validar se o valor é numérico.
' IsDate possui 1 parâmetro
'     Validar se o valor é uma data ou hora.
' IsNull possui 1 parâmetro
'     Validar se o valor é nulo.
' IsEmpty possui 1 parâmetro
'     Validar se o valor é vazio.

A = InputBox( "Digite um valor qualquer: " )
B = null
Result = ""

If IsNumeric(A) then
    Result = "Valor informado e numerico."
ElseIf IsDate(A) then
    Result = "Valor informado e data."
Else
    Result = "Valor informado e caractere."
end if
MsgBox Result

If IsNull(B) then
    Result = "Valor B e igual a nulo."
end if
MsgBox Result

If IsEmpty(C) then
    Result = "Valor C esta vazio."
end if
MsgBox Result
