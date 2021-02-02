import std.stdio;

// void : função sem retorno
void main() {
    int i;
    char c;
    bool b;
    float f;

    writeln("Valor inicial de [ i ] = ", i.init);
    writeln("Valor inicial de [ c ] = ", c.init);
    writeln("Valor inicial de [ b ] = ", b.init);
    writeln("Valor inicial de [ f ] = ", f.init);
    i = 5;
    c = 'y';
    b = true;
    f = 100.0 / 3.0;
    writeln("Valor de [ i ] = ", i);
    writeln("Valor de [ c ] = ", c);
    writeln("Valor de [ b ] = ", b);
    writeln("Valor de [ f ] = ", f);
}
