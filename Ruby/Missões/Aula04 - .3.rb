# Dado o seguinte hash:
# Numbers = {a: 10, b: 30 2, c: 20, d: 25, e: 15}
# Crie uma instrução que seleciona o maior valor deste hash e no final imprima
# a chave e valor do elemento resultante.

Numbers = {a: 10, b: 30, c: 20, d: 25, e: 15}

largeNumber = Numbers.values.max
mlargeKey = ''

largeKey = Numbers.select do |key, value|
    value == largeNumber
    if value == largeNumber
        mlargeKey = key
    end
end
largeKey = mlargeKey
puts "A chave do maior valor é #{largeKey} e seu valor é #{largeNumber}"