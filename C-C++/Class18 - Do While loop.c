#include <stdio.h>
#include <stdlib.h>

void main() {
    int x = 0;
    do {
        printf("\n%d", x);
        x++;
    } while (x <= 10);

    x = 10;
    do {
        printf("\n%d", x);
        x--;
    } while (x >= 0);

}
