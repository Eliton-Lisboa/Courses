# Utilizando uma collection do tipo Array, escreva um programa que receba 3
# números e no final exiba o resultado de cada um deles elevado a segunda potência.

loop do
    system 'cls'
    puts ''
    puts '0. Sair'
    puts ''
    print 'Digite o primeiro número: '
    number1 = gets.chomp.to_i
    if number1 == 0
        break
    end

    print 'Digite o segundo número: '
    number2 = gets.chomp.to_i
    if number2 == 0
        break
    end

    print 'Digite o terceiro número: '
    number3 = gets.chomp.to_i
    if number3 == 0
        break
    end

    puts ''
    puts "#{number1} elevado a segunda potência fica #{number1 ** 2}"
    puts "#{number2} elevado a segunda potência fica #{number2 ** 2}"
    puts "#{number3} elevado a segunda potência fica #{number3 ** 2}"

    exit = gets.chomp
end
