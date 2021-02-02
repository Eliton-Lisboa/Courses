Dim vArray() ' Declarar variável

contador = 1

On error resume next

    Do while true
        Redim preserve vArray(contador)
        vArray(contador) = WeekDayName(contador)
        If err.number <> o then
            exit do
        end if

        contador = contador + 1
    loop

On error goto 0

For x = 1 to ubound(vArray) - 1
    MsgBox vArray(x)
Next

' Filter tem até 4 parâmetros
'     Array   - para fazer a busca
'     Value   - valor a buscar
'     Include - buscar com ou sem o valor
'     Compare - comparação por texto ou binário

B = Filter(vArray, "-", false, 0)

For x  = 0 to ubound(B)
    MsgBox B(x)
Next