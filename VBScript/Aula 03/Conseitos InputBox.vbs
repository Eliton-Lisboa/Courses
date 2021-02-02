' INPUTBOX pode ter até 7 parâmetros
' PROMPT -> Menssagem do centro
' TITLE  -> Menssage que aparece no título
' DEFAULT-> Valor pré-definido da caixa de inserção
' X      -> Posição x de coordenada da caixa
' Y      -> Posição y de coordenada da caixa
' HELPFILE->  O endereço do arquivo de ajuda
' CONTEXT ->  Contexto do arquivo de ajuda (obrigatório se colocar o HelpFile)


'      InputBox ("PROMPT", "TITLE", "DEFAULT", "X", "Y")
nome = InputBox("Informe seu nome", "cadastro de pesso", "Eliton l. Lopes", 0, 3000)
MsgBox nome
