# .to_i transforma a string em um número inteiro

print 'Digite o primeiro numero inteiro: '
number1 = gets.chomp.to_i

print 'Digite o primeiro numero segundo: '
number2 = gets.chomp.to_i

result = number1 + number2
puts "O resultado da soma emtre esses numeros é #{result}"
