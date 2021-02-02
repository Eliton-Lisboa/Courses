# Crie um programa que possua um método que resolva a
# potência dado um número base e seu expoente. Estes dois
# valores devem ser informados pelo usuário.

def exponenciacao(number = 1, expoente = 1)
    return number ** expoente
end
result = ''

loop do
    system 'cls'
    puts result
    puts ''
    puts '0. Sair'
    puts ''
    print 'Digite um número: '
    number = gets.chomp.to_i

    case number
    when 0
        break
    else
        print 'Digite o seu expoente: '
        expoente = gets.chomp.to_i
        puts ''
        puts exponenciacao(number, expoente)
    end

    exit = gets.chomp
end
