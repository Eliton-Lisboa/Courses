import std.stdio;

// return type | name | parameters
//        ref: serve para que a variaveis de parametro sofra a alteração sem isso nada acontece
void test(ref byte i, byte j) {
    i = 32;
    j = 64;
}

void main() {
    byte x = 8, y = 24;

    writeln(" /------------------------------------------\\");
    writeln(" : Valores de X e Y andes de chamar o test  :");
    writeln("X: ", x);
    writeln("Y: ", y);
    writeln();
    test(x, y);
    writeln(" /------------------------------------------\\");
    writeln(" : Valores de X e Y depois de chamar o test :");
    writeln("X: ", x);
    writeln("Y: ", y);
    writeln();
}
