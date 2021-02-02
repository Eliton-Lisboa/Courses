import std.stdio;

void main() {
    int x = 10, y = 5, z = 5;

    writeln("x = ", x, " : y = ", y, " z = ", z);
    writeln("x >  y ? ", x >  y); // maior que
    writeln("x <  y ? ", x <  y); // menor que
    writeln("x =  y ? ", x == y); // igual a
    writeln("x != y ? ", x != y); // diferente de
    writeln("y >= z ? ", y >= z); // maior ou igual a
    writeln("y <= z ? ", y <= z); // menor ou igual a

    writeln("(    3 > 1    ) && ( 2 == 2 ) ?", ( 3 > 1 ) && ( 2 == 2 )); // and
    writeln("(    3 > 1    ) || ( 2 == 2 ) ?", ( 3 > 1 ) || ( 1 == 2 )); // or
    writeln("(    3 > 1    ) ^  ( 2 == 2 ) ?", ( 3 > 1 ) ^  ( 2 == 2 )); // xor
    writeln("( !( 2 == 2 ) )               ?", !( 2 == 2 ));             // not
}
