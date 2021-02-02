# Pesquisar o que é o Proc em Ruby e descobrir as diferenças entre ele e o Lambda
# Result:


# Estando intimamente ligadas com os blocks, as procs são a transformação de um bloco em um objeto. Ou seja, as
# procedures são nada mais, nada menos que aquilo que o seu próprio nome indica: procedimentos; objetos que
# armazenam trechos reutilizáveis de código.

# Como declarar uma Proc?
#  ______________________________________________
# |   pr = Proc.new { puts ' Sou uma proc' }    |
# |                     or                      |
# |      pr = proc { puts ' Sou uma proc' }     |
# |_____________________________________________|


_lambda = lambda {|a, b| puts "[#{a}, #{b}]"}
_proc = Proc.new {|a, b| puts "[#{a}, #{b}]"}

_lambda.call(1, 2)
_proc.call(1, 2)