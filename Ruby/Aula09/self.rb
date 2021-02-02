# V.01
class Foo1
    def bar
        puts self
    end
end

foo = Foo1.new
puts foo
foo.bar

# V.2
class Foo2
    def self.bar
        puts self
    end
end

Foo2.bar

# V.3
class Pen
    attr_accessor :color
    def pen_color
        puts "The color is " + self.color
    end
end

pen = Pen.new
pen.color = "blue"
pen.pen_color
