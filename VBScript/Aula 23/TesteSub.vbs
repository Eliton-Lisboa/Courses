erros = ""

a = InputBox( "Informe o primeiro numero: " )
b = InputBox( "Informe o segundo numero: " )

validarParametro( a )
validarParametro( b )

If len( trim( erros ) ) > 0 then
    MsgBox erros, 16, "Warning"
Else
    MsgBox "A soma do primeiro com o segundo numero e: " & ( CDbl( a ) + CDbl( b ) ), 64, "Resultado"
end if

sub validarParametro( text )
    If not IsNumeric( text ) then
        erros = erros & " Os valores devem ser numericos " & chr( 10 )
    Else
        If text < 0 then
            erros = erros & " Os valores devem ser maiores que zero " & chr( 10 )
        end if

    end if

end sub