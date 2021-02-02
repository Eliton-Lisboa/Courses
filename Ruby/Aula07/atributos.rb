# V.1
class Dog
    def name
        @name
    end

    def name= name
        @name = name
    end
end

dog = Dog.new 
dog.name = 'Marlon'    
puts dog.name

# V.2

class Dog
    attr_accessor :name, :age
end

dog = Dog.new
dog.name = 'Marlon'
puts dog.name

dog.age = '1 ano'
puts dog.age