import std.stdio;

void main() {
    auto t = true, i = 5, c = 'a', d = 0.5;

    writeln("O tipo da variável [ t ]: ", TypeId(TypeOf(t)));
    writeln("O tipo da variável [ i ]: ", TypeId(TypeOf(i)));
    writeln("O tipo da variável [ c ]: ", TypeId(TypeOf(c)));
    writeln("O tipo da variável [ d ]: ", TypeId(TypeOf(d)));

}
