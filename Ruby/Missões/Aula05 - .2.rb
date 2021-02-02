# Siga a documentação da gem cpf_cnpj para criar um
# programa que recebe como entrada um número de cpf e
# em um método verifique se este número é válido.

require 'cpf_cnpj'

def validate(cpf)
    
    if !CPF.valid?(cpf)
        'não é valido!'
    else
        'é totalmente valido!'
    end
end
result = ''

loop do
    system 'cls'
    puts ''
    puts '0. Sair'
    puts ''
    print 'Digite um cpf para verificar: '
    cpf = gets.chomp
    case cpf
    when '0'
        break
    else
        puts "O cpf indicado #{validate(cpf)}"
    end

    exit = gets.chomp

end