import std.stdio;
import runnable;

void main() {
    // Ex. 01
    writeln("Demo de uso do foreach");
    writeln(" -----------------------------------");
    foreach (x; 1..10) {
        writeln(" Valor atual de n: ", x);
    }
    writeln(" -----------------------------------");
    writeln("Valores de n [1;9]");
    readln();

    writeln();
    // Ex. 02
    writeln("Foreach - array");
    writeln(" -----------------------------------");
    int[] array = new int[10];

    foreach (x; 0..array.length)
        array[x] = x + 1;

    foreach (element; array)
        writeln("Elemento: ", element);

    writeln(" -----------------------------------");
    readln();

}
