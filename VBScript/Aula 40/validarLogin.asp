<%language=VBScript%>
<%
    Set vEncode = Server.CreateObject( "Scripting.Encoder" )

    vSenhaDecript = request.QueryString( "senha" )
    vSenha = vEncode.EncodeScriptFile( ".vbs", vSenhaDecript, 0, "" )

    vSenha = mid( vSenha, 1, len( vSenha ) - 1 )
    vUsuario = request.QueryString( "login" )

    Set eng = server.CreateObject( "DAO.DBEngine.36" )
    Set cn = eng.OpenDataBase( "../DataBase/DBVBScript.mdb" )

    Set rc = cn.OpenRecordSet( "select * from usuario where login = '" & vUsuario & "' and senha = '" & vSenha & "'" )

    If rc.RecordCount > 0 then
        response.Write( "ol&aacute; " & rc.Fields( "nome" ).Value )
    Else
        response.Write( "Senha ou usuario inv&aacute;lidos" )
    end if
%>