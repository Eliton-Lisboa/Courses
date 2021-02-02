<%language=VBScript%>

<%
    validaLogin

    sub validaLogin()
        Set vEncode = server.CreateObject( "Scripting.Encoder" )

        vSenhaDecript = request.QueryString( "senha" )
        vSenha = vEncode.EncodeScriptFile( ".vbs", vSenhaDecript, 0, "" )

        vSenha = mid( vSenha, 1, len( vSenha ) - 1 )
        vUsuario = request.QueryString( "login" )

        Set eng = CreateObject( "DAO.DBEngine.36" )
        Set cn = eng.OpenDataBase( "../DataBase/DBVBScript.mdb" )

        Set rc = cn.OpenRecordSet( "select * " & _
                                   "from usuario " & _
                                   "where login = '" & vUsuario & "'" & _
                                   " and senha = '" & vSenha & "'")

        If rc.RecordCount > 0 Then
            response.Write( "ol&aacute; " & rc.Fields( "nome" ).Value & "<br/>" )
            visualizaMenu
        Else
            response.Write( "Senha ou usuario inv&aacute;lidos" )
        end if
    end sub

    sub visualizaMenu()
        Set eng = CreateObject( "DAO.DBEngine.36" )
        Set cn = eng.OpenDataBase( "../DataBase/DBVBScript.mdb" )

        ultDescricao = ""

        Set rc = cn.OpenRecordSet( Replace( _
                                   "select mid(vMenu, 1, instr(vMenu, '->') - 1), " & _
                                   " '<clique>' & mid(vMenu, 1, instr(vMenu, '->') + 2), menu, tela" & _
                                   " from  (select mid(Menu, len('<clique>') + 1, 1000) as vMenu, menu tela " & _
                                   " from cadMenu a inner join UsuarioXMenu b on a.id = b.id_menu " & _
                                   " where b.login = '" & request.QueryString( "login" ) & "'" & _
                                   " and Menu like '<clique>*' order by menu)", "<clique>", request.QueryString( "clique" )))

        If rc.RecordCount > 0 then
            rc.MoveNext
            response.Write( "<br/>" )

            do while not rc.eof
                If ultDescricao <> rc.Fields( 0 ).Value then
                    If
                        response.Write( "<a href='" & rc.Fields( 3 ).Value & "'>" & rc.Fields( 0 ).Value & "</a><br/>" )
                    Else
                        response.Write("<a href='visualizaMenu.asp?click=" & trim( rc.Fields( 1 ).Value ) & "'>" & rc.Fiels( 0 ).Value & "</a><br/>")
                    end if
                    ultDescricao = rc.Fields( 0 ).Value
                end if
                rc.MoveNext
            loop
        Else
            response.Write( "Sem menu" )
        end if
    end sub
%>