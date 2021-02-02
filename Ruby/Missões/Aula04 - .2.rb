# Crie uma collection do tipo Hash e permita que o usuário crie três elementos
# informando a chave e o valor. No final do programa para cada um desses
# elementos imprima a frase “Uma das chaves é **** e o seu valor é ****”

loop do
    system 'cls'
    array = {}

    puts ''
    puts '0. Sair'
    puts ''

    print ''
    print 'Digite a primeira chave: '
    key1 = gets.chomp

    case key1
    when '0'
        break
    else
        print 'Digite o primeiro valor: '
        value1 = gets.chomp

        print 'Digite a segunda chave: '
        key2 = gets.chomp

        print 'Digite o segundo valor: '
        value2 = gets.chomp

        print 'Digite a terceira chave: '
        key3 = gets.chomp

        print 'Digite o terceiro valor: '
        value3 = gets.chomp

        array = {key1 => value1, key2 => value2, key3 => value3}
        array.each do |key, value|
            puts "Uma das chaves é #{key} e o seu valor é #{value}"
        end

    end



    exit = gets.chomp
end