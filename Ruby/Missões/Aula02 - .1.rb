# Crie um programa que receba o nome e a idade de uma pessoa
# e no final exiba estes dois dados em uma única frase.

print 'Digite seu nome: '
name = gets.chomp

print "Olá #{name}, qual é a sua idade?: "
age = gets.chomp

puts "#{name} você tem #{age} anos de idade!"