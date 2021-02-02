Set oEncoder = CreateObject( "Scripting.Encoder" )
Senha = InputBox( "Informe a senha: " )
SenhaEncriptada = oEncoder.EncodeScriptFile( ".vbs", Senha, 0, "" )

MsgBox SenhaEncriptada
