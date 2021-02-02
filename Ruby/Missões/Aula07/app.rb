require_relative 'produto.rb'
require_relative 'mercado.rb'

productclass = Produto.new('bolsa', '1500,00')
marketclass = Mercado.new(productclass)

puts marketclass.comprar
