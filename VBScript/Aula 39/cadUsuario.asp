<%language=VBScript%>

<%

    Set eng = CreateObject( "DAO.DBEngine.36" )
    Set cn = CreateObject( "../DataBase/DBVBScript.mdb" )

    Set vEncoder = server.CreateObject( "Scripting.Encoder" )

    erros = ""

    login = request.QueryString( "login" )
    senha = request.QueryString( "senha" )
    repetirsenha = request.QueryString( "repetirsenha" )
    nome = request.QueryString( "nome" )

    If len( trim( login ) ) = 0 then
        erros = erros & "Campo login não pode ser nulo <br/>"
    end if

    Set rc = cn.OpenRecordSet( "select count(0) as qtd from usuario where login = '" & login & "'" )

    If rc.Fields(0).Value > 0 then
        erros = erros & "Login já existe <br/>"
    end if

    rc.Close

    If len( trim( senha ) ) = 0 or len( trim( repetirsenha ) ) = 0 then
        erros = erros & "Senhas tem que ser iguais <br/>"
    end if

    If len( trim( nome ) ) = 0 then
        erros = erros & "Nome não pode ser nulo <br/>"
    end if

    If len( trim( erros ) ) > 0 then
        response.Write( "Existem erros:<br/>" & erros )
    Else
        senhaEncriptada = vEncoder.EncodeScriptFile( ".vbs", senha, 0, "" )

        cn.Execute "insert into usuario (login, senha, nome)" & _
                   "values ('" & login & "', '" & mid( senhaEncriptada, 1, len( senhaEncriptada ) - 1 ) & "', '" & nome & "')"

        Set rc = cn.OpenRecordSet( "select * from usuario" )
        response.Write( "<table border=1><tr>" )

        For x = 0 to rc.Fields.Count - 1
            response.Write( "<td>" & rc.Fields(x).Name & "</td>" )
        Next

        response.Write( "</tr>" )

        If rc.RecordCount > 0 then
            rc.MoveFirst

            do while not rc.eof
                response.Write( "<tr>" )
                rc.MoveNext
            loop

        end if

        response.Write( "Gravado com sucesso<br/>" )
        rc.Close
    end if
    
    cn.Close
%>