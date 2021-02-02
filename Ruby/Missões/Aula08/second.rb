# Crie um módulo chamado Person com as classes Juridic e Physical.
# Seu código deverá retornar:
#           Pessoa Juridica adicionada
#           nome: M. C. Investimentos
#           cnpj: 4241.123/0001
# Ao Executar a instrução: Person::Juridic.new('M. C. Investimentos', '4241.123/0001').add

# E a instrução: Person::Physical.new('José Almeida', '425.123.123-123').add
#           Pessoa Juridica adicionada
#           nome: José almeida
#           cpf: 425.123.123-123


module Person
    class Juridic
        def initialize name, cnpj
            puts ' '
            @name = name
            @cnpj = cnpj
        end

        def add
            puts 'Pessoa Juridica '
            puts "nome: #{@name}"
            puts "cnpj: #{@cnpj}"
        end
    end

    class Physical
        def initialize name, cpf
            puts ' '
            @name = name
            @cpf = cpf
        end
  
        def add
            puts 'Pessoa Juridica '
            puts "nome: #{@name}"
            puts "cnpj: #{@cpf}"
        end
    end
end

Person::Juridic.new('M. C. Investimentos', '4241.123/0001').add
Person::Physical.new('José Almeida', '425.123.123-123').add
