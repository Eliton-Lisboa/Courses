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

MsgBox "A variavel contador e array: " & isArray(contador)
MsgBox "A variavel vArray e array: " & isArray(vArray)

' Join retorna uma string da array passada
'     Array
'     Delimiter - delimitador dos valores do array: default = " "

text = MsgBox Join(vArray, " ; ")

' split transforma o texto em array
'     Text 
'     Delimiter - delimitador dos valores do array: default = " "
'     Count     - define a quantidade de vetores
'     Compare   - comparação por texto ou binário

vArray2 = split(text, " ; ", 4)
MsgBox "A variavel vArray e array: " & isArray(vArray2)

For Each x in vArray2
Next