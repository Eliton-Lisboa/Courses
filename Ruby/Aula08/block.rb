# V.1
5.times { puts 'Exec the block' }

# V.2
sum = 0
numbers = [5, 10, 5]
numbers.each { |number| sum += number }
puts sum

# V.3
foo = {2 => 3, 4 => 5}

foo.each do |key , value|
    puts "key = #{key}"
    puts "Value = #{value}"
    puts "Key * Value = #{key * value}"
    puts '...'
end

# V.4 Que recebe um método
def foo1
    #Call the block
    yield
    yield
end

foo1 { puts "Exec the block" }

foo1 do
    puts "Exec the block"
end

# V.4 Que recebe um método - Verificar
def foo2
    if block_given?
        # Call the block
        yield
    else
        puts "Sem parâmetro do tipo bloco"
    end
end

foo2
foo2 { puts "Com parâmetro do tipo bloco"}

# V.5
def foo3(numbers, &block)
    if block_given?
        numbers.each do |key, value|
            block.call(key, value)
        end

    end

end

numbers = { 2 => 2, 3 => 3, 4 => 4 }
    
    
foo3(numbers) do |key, value|
    puts "#{key} * #{value} = #{key * value}"
    puts "#{key} + #{value} = #{key + value}"
    puts "---"
end