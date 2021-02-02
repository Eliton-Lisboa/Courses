
On error resume next
    A = InputBox( "Informe o primeiro numero" )
    A = InputBox( "Informe o segundo numero" )

    C = A / B

    If err.number <> 0 then
        MsgBox( "Erro tratado" )
    Else
        MsgBox( "O resultado e " & C )
    end if

On error goto 0
