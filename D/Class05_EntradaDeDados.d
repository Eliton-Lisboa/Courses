import std.stdio;

void main() {
    float raio, diametro, circunferencia;
    const PI = 3.141592654;

    writeln();
    writeln(" /------------------------------------------------\\");
    writeln(" :  Calculo do comprimento de uma circunferencia  :");
    writeln(" \\------------------------------------------------/");
    writeln();

    write("Quanto mede o diametro da circunferencia? ");
    readf(" %f", diametro);

    raio = diametro / 2;
    circunferencia = 2 * PI * raio;

    writeln("Comprimento da circunferencia = ", circunferencia);

}
