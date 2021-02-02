Set ArquivoExterno = CreateObject( "Scripting.FileSystemObject" ) ' Object
Set arq = ArquivoExterno.OpenTextFile( "../file.303", 2, 1 )

arq.WriteLine "Primeira linha"
arq.WriteLine "Segunda linha"
arq.WriteLine "Terceira linha"
arq.WriteLine "Quarta linha"
arq.WriteLine "Quinta linha"

arq.Close

MsgBox "Finalizado", 64, "Arquivo texto"
