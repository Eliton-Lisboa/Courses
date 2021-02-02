# Crie um programa que receba dois números
# inteiros e no final exiba a soma, a subtração
# a adção e a divisão entre eles.

print 'Digite o primeiro número inteiro: '
number1 = gets.chomp.to_i

print 'Digite o segundo número inteiro: '
number2 = gets.chomp.to_i

puts "A soma entre esses números é #{number1 + number2}, A subtração é #{number1 - number2}, A divisão é #{number1 / number2}"