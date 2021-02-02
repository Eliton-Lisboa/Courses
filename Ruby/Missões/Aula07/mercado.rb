class Mercado

    def initialize product
        @product = product
    end

    def comprar
        "Voce comprou o produto #{@product.name} no valor de #{@product.prince}"
    end
end