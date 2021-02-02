import std.stdio;

void main() {
    int x = 10, y = 5, resultado;

    // '+'  --> = x + y; --> 15 
    // '-'  --> = x - y; --> 5
    // '*'  --> = x * y; --> 50
    // '/'  --> = x / y; --> 2
    // '%'  --> = x % y; --> 0
    // '++' --> = x ++;  --> 11
    // '--' --> = x --;  --> 9

    writeln();
    writeln("x = ", x, " : y = ", y);

    resultado = x + y;
    writeln("'+'  --> x + y --> ", resultado);
    resultado = x - y;
    writeln("'-'  --> x - y --> ", resultado);
    resultado = x * y;
    writeln("'*'  --> x * y --> ", resultado);
    resultado = x / y;
    writeln("'/'  --> x / y --> ", resultado);
    resultado = x % y;
    writeln("'%'  --> x % y --> ", resultado);
    resultado = x++;
    writeln("'++' --> x++   --> ", resultado);
    resultado = x--;
    writeln("'--' --> x--   --> ", resultado);
}
