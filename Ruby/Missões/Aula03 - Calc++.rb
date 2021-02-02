# Utilizando as estruturas de iteração e condição,
# crie uma calculadora que ofereça ao usuário a opção de
# Multiplicar, Dividir, Adicionar ou Subtrair dois números.
# Não se esqueça de também permitir que o usuário feche
# o programa.
result = ''

loop do
    puts result
    puts ' '
    puts '1. Multiplicar'
    puts '2. Dividir'
    puts '3. Adicionar'
    puts '4. Subtrair dois números'
    puts ' '
    puts '0. Sair'
    puts ' '
    print 'Escolha uma opção: '
    option = gets.chomp
    
    if option != 4 and option != 0
        print 'Digite o primeiro número: '
        number1 = gets.chomp.to_i
        print 'Digite o segundo número: '
        number2 = gets.chomp.to_i
    end
    
    if option == '1'
        result = number1 * number2

    elsif option == '2'
        result = number1 / number2

    elsif option == '3'
        result = number1 + number2

    elsif option == '4'
        print 'Digite um número: '
        number = gets.chomp.to_i
        result = number - 2
        
    elsif option == '0'
        break
    else
        result = 'Erro: opção invalida!'
    end

    system "cls"
end