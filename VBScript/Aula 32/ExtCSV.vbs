Set eng = CreateObject( "DAO.DBEngine.36" )
Set cn = eng.OpenDataBase( "../DataBase/DBVBScript.mdb" )
Set rc = cn.OpenRecordSet( "select * from agenda" )

Set Arquivo = CreateObject( "Scripting.FileSystemObject" )
Set arq = Arquivo.OpenTextFile( "../DataBase/ExtAgenda.csv", 2, 1 )

If rc.RecordCount > 0 then
    rc.MoveFirst
    retorno = ""

    For x = 0 to rc.Fields.Count - 1
        retorno = retorno & rc.Fields(x).Name & " ; "
    Next
    arq.WriteLine retorno
    retorno = ""

    do while rc.eof

        For x = 0 to rc.Fields.Count - 1
            retorno = retorno & rc.Fields(x).Value & " ; "
        Next
        arq.WriteLine retorno
        retorno = ""

        rc.MoveNext
    loop
end if

MsgBox "Finalizou"
