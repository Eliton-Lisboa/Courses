erros = ""

a = InputBox( "Informe o primeiro numero: " )
b = InputBox( "Informe o segundo numero: " )

If not validarParametro( a, b ) then
    MsgBox erros, 16, "Warning"
Else
    MsgBox "A soma do primeiro com o segundo numero e: " & ( CDbl( a ) + CDbl( b ) ), 64, "Resultado"
end if

function validarParametro( text1, text2 )
    If not IsNumeric( text1 ) then
        erros = erros & " O valor do parametro text1 deve ser numerico " & chr( 10 )
    Else
        If text1 < 0 then
            erros = erros & " O valor do parametro text1 deve ser maior que zero " & chr( 10 )
        end if

    end if

    If not IsNumeric( text2 ) then
        erros = erros & " O valor do parametro text2 deve ser numerico " & chr( 10 )
    Else
        If text2 < 0 then
            erros = erros & " O valor do parametro text2 deve ser maior que zero " & chr( 10 )
        end if

    end if

    If len( trim( erros ) ) > 0 then
        validarParametro = false
    Else
        validarParametro = true
    end if


end function
