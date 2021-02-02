' FormatPercent      --> Possui até 5 parâmetros
'   Expression      --> Numero a transformar
'   NumDigAfterDec  --> Quantidade de decimais
'   IncLeadingDig   --> Indica se o numero zero aparece Ex: 0.5
'       -2. Configurado no Windows
'       -1. Aparecera em casos de frações menores de 1
'        0. Não aparecera em casos menores que 1
'   useParForNegNum --> Indica se valores negativos apareceram com "-" ou entre "()"
'       -2. Configurado no Windows
'       -1. Apresenta emtre "()"
'        0. Apresenta com "-"
'   GroupDig        --> Indica separação de Billião, Milhão, Mil
'       -2. Configurado no Windows
'       -1. Apresenta o "."
'        0. Não apresenta o "."

A = 1

'      FormatPercent("Expression", "NumDigAfterDec", "IncLeadingDig", "useParForNegNum", "GroupDig")
MsgBox FormatPercent(A, 3, -1)
MsgBox FormatPercent(A, 3, 0)

A = 0.5

MsgBox FormatPercent(A, 2, , , -1)
MsgBox FormatPercent(A, 2, , , 0)

A = 0.005

MsgBox FormatPercent(A, 2, , -1, -1)
MsgBox FormatPercent(A, 2, , 0, 0)