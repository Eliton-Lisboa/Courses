' InStr possui até 3 parametros
' Caracter inicial (opcional). se nao informado = 1
' Texto orígínal
' Texto procurado

Z = InputBox("Informe o indice do caracter inicial") + 0
A = InputBox("Informe qualquer valor")
B = InputBox("Caracter de procura")

C = InStr(Z, A, B)

MsgBox "O(s) caracter(es) " & B & " esta na posicao " & C