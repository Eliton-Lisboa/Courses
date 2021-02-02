Set eng = CreateObject( "DAO.DBEngine.36" )
Set tb = eng.CreateDataBase( "../DataBase/DBVBScript.mdb", "Jet 3.x;LANGID=0x0409;CP=1252;COUNTRY=0" )

tb.Execute "create table agenda ( CodInfPessoa Integer, Nome String, DDD Integer, Telefone Integer, TipoTelefone String )"


tb.Execute "insert into agenda ( CodInfPessoa, Nome, DDD, Telefone, TipoTelefone )" & _
           "values ( 1, 'Eliton', 51, 94077635, 'Celular' )"

Set rc = tb.OpenRecordSet( "Select * from agenda" )
rc.MoveFirst

MsgBox "Codigo -> [ " & rc.Fields( "CodInfPessoa" ).Value & " ]" & Chr( 10 ) & _
       "Nome -> [ " & rc.Fields( "Nome" ).Value & " ]"           & Chr( 10 ) & _
       "DDD -> [ " & rc.Fields( "DDD" ).Value & " ]"             & Chr( 10 ) & _
       "Telefone -> [ " & rc.Fields( "Telefone" ).Value & " ]"   & Chr( 10 ) & _
       "Tipo -> [ " & rc.Fields( "TipoTelefone" ).Value & " ]"

rc.Close
tb.Close
