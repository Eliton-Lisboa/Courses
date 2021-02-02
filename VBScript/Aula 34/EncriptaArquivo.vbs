Set oEncoder = CreateObject( "Scripting.Encoder" )
Set arquivo = CreateObject( "Scripting.FileSystemObject" )

Nome_arquivo = "./EscreverArquivo.vbs"
Set arq = arquivo.GetFile( Nome_arquivo )

Set vStream = arq.OpenAsTextStream( 1 )
vVarStream = vStream.ReadAll

vStream.Close

vDestino = oEncoder.EncodeScriptFile( ".vbs", vVarStream, 0, "" )
Arquivo_saida = "./EscreverArquivo.vbe"
Set Arq_saida = arquivo.CreateTextFile( Arquivo_saida )
Arq_saida.Write vDestino
Arq_saida.Close
