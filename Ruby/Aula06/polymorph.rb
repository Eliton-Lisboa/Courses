class Instrumento
    def escrever
        puts 'Escrevendo'
    end
end

class Teclado < Instrumento
    def escrever
        puts "Escrevendo no teclado"
        super
    end
end

class Lapis < Instrumento
    def escrever
        puts 'Escrevendo à Lápis'
    end
end

class Caneta < Instrumento
    def escrever
        puts 'Escrevendo à Caneta'
    end
end
   
   
Instrumentos = [Lapis.new, Caneta.new, Teclado.new]
# Chamamos o método escrever pra qualquer instrumento
Instrumentos.each do |instrumento|
    instrumento.escrever
end