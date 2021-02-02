Set tb = CreateObject( "ADODB.Connection" )
set rc = CreateObject( "ADODB.RecordSet" )
tb.Open "Provider=Microsoft.Jet.OLEDB.4.0; Data source=../DataBase/DBVBScript.mdb"

vCodInfPessoa = ""
vNome         = ""
vDDD          = ""
vTelefone     = ""
vTipoTelefone = ""
erros         = ""
vResultado    = ""

do while true

    WScript.StdOut.Write "Informe o codigo da pessoa [ " & vCodInfPessoa & " ]"
    vCodInfPessoa = WScript.StdIn.ReadLine
    WScript.StdOut.Write "Informe o nome da pessoa [ " & vNome & " ]"
    vNome = WScript.StdIn.ReadLine
    WScript.StdOut.Write "Informe o DDD do telefone da pessoa [ " & vDDD & " ]"
    vDDD = WScript.StdIn.ReadLine
    WScript.StdOut.Write "Informe o telefone da pessoa [ " & vTelefone & " ]"
    vTelefone = WScript.StdIn.ReadLine
    WScript.StdOut.Write "Informe o tipo do telefone da pessoa [ " & vTipoTelefone & " ]"
    vTipoTelefone = WScript.StdIn.ReadLine

    validarCampos

    If len( trim( erros ) ) = 0 then
        tb.Execute "insert into agenda (CodInfPessoa, Nome, DDD, Telefone, TipoTelefone)" & _
                   "values (" & vCodInfPessoa & ", '" & vNome & "', " & vDDD & ", " & vTelefone & ", '" & vTipoTelefone & "')"

        exit do
    Else
        Resposta = MsgBox( "Ocorreram erros no procedimento:" & Chr( 10 ) & erros, 16+5, "Warning" )
        erros = ""

        If Resposta <> 4 then
            exit do
        end if

    end if

loop

rc.CursorLocation = 3
rc.Open "select * from agenda", tb, 2, 3
rc.MoveFirst

Do while not rc.eof
    vResultado = vResultado & "Codigo -> [ " & rc.Fields( "CodInfPessoa" ).Value & " ]" & _
                              "Nome -> [ " & rc.Fields( "Nome" ).Value & " ]"           & _
                              "DDD -> [ " & rc.Fields( "DDD" ).Value & " ]"             & _
                              "Telefone -> [ " & rc.Fields( "Telefone" ).Value & " ]"   & _
                              "Tipo -> [ " & rc.Fields( "TipoTelefone" ).Value & " ]"
    
    rc.MoveNext
loop

MsgBox vResultado

sub validarCampos
    If not IsNumeric( vCodInfPessoa ) then
        erros = erros & " O campo codigo deve ser numerico " & Chr( 10 )
    Else
        If CDbl( vCodInfPessoa ) <= 0 then
            erros = erros & " O campo codigo deve ser maior que zero " & Chr( 10 )
        end if

        If CDbl( vCodInfPessoa ) <> Round( CDbl( vCodInfPessoa ) ) then
            erros = erros & " O campo codigo deve ser inteiro " & Chr( 10 )
        end if
    end if

    If not IsNumeric( vDDD ) then
        erros = erros & " O campo DDD deve ser numerico " & Chr( 10 )
    Else
        If CDbl( vDDD ) <= 0 then
            erros = erros & " O campo DDD deve ser maior que zero " & Chr( 10 )
        end if

        If CDbl( vDDD ) <> Round( CDbl( vDDD ) ) then
            erros = erros & " O campo DDD deve ser inteiro " & Chr( 10 )
        end if

        If not ( CDbl( vDDD ) >= 10 and CDbl( vDDD ) <= 99 ) then
            erros = erros & " O campo DDD deve estar entre 10 e 99 " & Chr( 10 )
        end if
    end if

    If not IsNumeric( vTelefone ) then
        erros = erros & " O campo telefone deve ser numerico " & Chr( 10 )
    Else
        If CDbl( vTelefone ) <= 0 then
            erros = erros & " O campo telefone deve ser maior que zero " & Chr( 10 )
        end if

        If CDbl( vTelefone ) <> Round( CDbl( vTelefone ) ) then
            erros = erros & " O campo telefone deve ser inteiro " & Chr( 10 )
        end if

        If not ( CDbl( vTelefone ) >= 10000000 and CDbl( vTelefone ) <= 99999999 ) then
            erros = erros & " O campo telefone deve estar entre 10000000 e 99999999 " & Chr( 10 )
        end if
    end if

    If len( trim( vCodInfPessoa ) ) = 0 then
        erros = erros & " O campo nome e obrigatorio " & Chr( 10 )
    end if

    If len( trim( vCodInfPessoa ) ) = 0 then
        erros = erros & " O campo tipo e obrigatorio " & Chr( 10 )
    end if

end sub
