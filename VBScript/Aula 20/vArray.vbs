Option Explicit ' Não pode dar valores a variáveis inexistentes

Dim vArray() ' Declarar variável
Dim x

For x = 0 to 10
    Redim preserve vArray(x) ' Redefine a variável preservando seu valor anterior
    vArray(x) = "Valor" & x  ' Dar valor ao vetor x da array
Next

MsgBox lbound(vArray) ' Retorna o menor índice
MsgBox ubound(vArray) ' Retorna o maior índice

For Each x in vArray
    MsgBox x
Next
