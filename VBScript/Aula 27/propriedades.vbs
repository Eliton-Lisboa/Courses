Set arquivo = CreateObject( "Scripting.FileSystemObject" )
Set arq = arquivo.GetFile( "../file.303" )

Propriedades = "Data da criacao -> [ " & arq.DateCreated & " ]"                 & Chr( 10 ) & _
               "Data do ultime acesso -> [ " & arq.DateLastAccessed & " ]"      & Chr( 10 ) & _
               "Data da ultima modificacao -> [ " & arq.DateLastModified & " ]" & Chr( 10 ) & _
               "Drive -> [ " & arq.Drive & " ]"                                 & Chr( 10 ) & _
               "Nome -> [ " & arq.Name & " ]"                                   & Chr( 10 ) & _
               "Diretorio -> [ " & arq.ParentFolder & " ]"                      & Chr( 10 ) & _
               "Nome completo -> [ " & arq.Path & " ]"                          & Chr( 10 ) & _
               "Nome DOS -> [ " & arq.ShortName & " ]"                          & Chr( 10 ) & _
               "Nome completo no DOS -> [ " & arq.ShortPath & " ]"              & Chr( 10 ) & _
               "Tamanho -> [ " & arq.Size & " ]"                                & Chr( 10 ) & _
               "Extensao -> [ " & arquivo.GetExtensionName( arq ) & " ]"        & Chr( 10 ) & _
               "Tipo -> [ " & arq.Type & " ]"

MsgBox Propriedades

Set rede = CreateObject( "Wscript.NetWork" )
MsgBox "Voce esta conectado com o usuario: " & rede.userName
