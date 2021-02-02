Set ArquivoExterno = CreateObject( "Scripting.FileSystemObject" ) ' Object
TextoFinal = ""

Set arqLeitura = ArquivoExterno.GetFile( "../file.303" )
Set arqStream = arqLeitura.OpenAsTextStream( 1, -2 )

Do while not arqStream.AtEndOfStream
    sRecord = arqStream.ReadLine
    TextoFinal = TextoFinal & sRecord & chr( 10 )
loop

arqStream.close
MsgBox TextoFinal
