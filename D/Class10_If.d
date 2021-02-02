import std.stdio;

void main() {
    int a = 2, b = 5;

    // Ex. 01
    if (a < b) {
        writeln("a e menor do que b");
    }

    // Ex. 02
    if ( (a < b) && (b < a) ) {
        writeln("a e menor que b e b e menor que a");
    }
    else {
        writeln("a nao pode ser ao mesmo tempo menor e maior do que b.");
    }

    // Ex. 03
    // Operador ? substitui if ... else
    (a < b) ? writeln("a e menor do que b") : writeln("a e maior do que b");
}
