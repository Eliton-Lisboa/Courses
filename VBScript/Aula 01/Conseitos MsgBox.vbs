' MSGBOX é composto de até 5 parâmetros
' PROMPT  ->  Mensagem do centro
' BUTTON  ->  É composto de 4 grupos de números
'             1. Configurações dos botões
'                   0. "Ok"
'                   1. "Ok", "Cancel"
'                   2. "Abort", "Retry", "Cancel"
'                   3. "Yes", "No", "Cancel"
'                   4. "Yes", "No"
'                   5. "Retry", "Cancel"
'             2. Ícones da caixa
'                   0 . "None"
'                   16. "Error"
'                   32. "Question"
'                   48. "Exclamation"
'                   64. "Information"
'             3. Botão padrão
'                   0  . O primeiro botão ficara focado.
'                   256. O segundo botão ficara focado
'                   512. O terceiro botão ficara focado
'                   768. O quarto botão ficara focado
'             4. Modal
'                   0   . Modal desativado
'                   4096. Modal ativado
' TITLE   ->  Mensagem que aparece no título
' HELPFILE->  O endereço do arquivo de ajuda
' CONTEXT ->  Contexto do arquivo de ajuda (obrigatório se colocar o HelpFile)


' MsgBox "Prompt", "Button"+"Icon"+"Default Button"+"Modal", "Title"
  MsgBox "Hello, World!", 2+16+256+4096, "Warning"