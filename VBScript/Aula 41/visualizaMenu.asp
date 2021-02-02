<%language=VBScript%>

<%
    Set eng = CreateObject( "DAO.DBEngine.36" )
    Set cn = eng.OpenDataBase( "../DataBase/DBVBScript.mdb" )

    request.QueryString( "clique" )
    ultDescricao = ""

    Set rc = cn.OpenRecordSet( Replace( _
                               "select mid(vMenu, 1, instr(vMenu, '->') - 1), " & _
                               " '<clique>' & mid(vMenu, 1, instr(vMenu, '->') + 2), menu, tela" & _
                               " from  (select mid(Menu, len('<clique>') + 1, 1000) as vMenu, menu tela " & _
                               " from cadMenu " & _
                               " where Menu  like '<clique>*' order by menu)", "<clique>", request.QueryString("clique")) )

    If rc.RecordCount > 0 then
        rc.MoveNext

        do while not rc.eof
            If ultDescricao <> rc.Fields(0).Value then
                If
                    response.Write("<a href='" & rc.Fields( 3 ).Value & ">" & rc.Fields( 0 ).Value & "</a><br/>")
                Else
                    response.Write("<a href='visualizaMenu.asp?click=" & trim( rc.Fields( 1 ).Value ) & "'>" & rc.Fiels( 0 ).Value & "</a><br/>")
                end if
                ultDescricao = rc.Fields(0).Value
            end if
            rc.MoveNext
        loop
    Else
        response.Write( "Sem menu" )
    end if
%>