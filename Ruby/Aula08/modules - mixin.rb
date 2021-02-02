module ImpressaoDecorada
    # método imprimir que recebe o parametro 'text'
    def imprimir text
        # Repete a string 100 vezes
        decoracao = '#' * 100
        puts decoracao
        puts text
        puts decoracao
    end
end

module Pernas
    # Inclui o mixin ImpressaoDecorada
    include ImpressaoDecorada
    
    def chute_frontal
        # Chamando o méto incluido neste mixin pelo include
        imprimir 'Chute Frontal'
    end
    
    def chute_lateral
      imprimir 'Chute Lateral'
    end
end

module Bracos
    # Inclui o mixin ImpressaoDecorada
    include ImpressaoDecorada
    
    def jab_de_direita
        imprimir 'Jab de direita'
    end
    
    def jab_de_esquerda
        imprimir 'Jab de esquerda'
    end
    
    def gancho
      imprimir 'Gancho'
    end
end

# Apenas classes incluindo mixins
class LutadorX
    include Pernas
    include Bracos
end

class LutadorY
    include Pernas
end

# instanciando e executando os métodos de suas classes
lutadorx = LutadorX.new
lutadorx.chute_frontal
lutadorx.jab_de_direita

lutadory = LutadorY.new
lutadory.chute_lateral