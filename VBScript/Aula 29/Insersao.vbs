Set eng = CreateObject( "DAO.DBEngine.36" )
Set tb = eng.OpenDataBase( "../DataBase/DBVBScript.mdb" )

vCodInfPessoa = InputBox( "Informe o codigo da pessoa: " )
vNome = InputBox( "Informe o nome da pessoa: " )
vDDD = InputBox( "Informe o ddd do telefone da pessoa: " )
vTelefone = InputBox( "Informe o telefone da pessoa: " )
vTipoTelefone = InputBox( "Informe o tipo de telefone da pessoa: " )
vResultado = ""

tb.Execute "insert into agenda ( CodInfPessoa, Nome, DDD, Telefone, TipoTelefone )" & _
           "values ( " & vCodInfPessoa & ", '" & vNome & "', " & vDDD & ", " & vTelefone & ", '" & vTipoTelefone & "' )"

Set rc = tb.OpenRecordSet( "select * from agenda" )
rc.MoveFirst

Do while not rc.eof
    vResultado = vResultado & "Codigo -> [ " & rc.Fields("CodInfPessoa") & " ]" & _
                              "Nome -> [ " & rc.Fields("Nome") & " ]"           & _
                              "DDD -> [ " & rc.Fields("DDD") & " ]"             & _
                              "Telefone -> [ " & rc.Fields("Telefone") & " ]"   & _
                              "Tipo -> [ " & rc.Fields("TipoTelefone") & " ]"   & Chr( 10 )

    rc.MoveNext
loop

MsgBox vResultado