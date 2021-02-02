#include <stdio.h>
#include <stdlib.h>

void main() {
    int x = 0;
    while (x <= 10) {
        printf("\n%d", x);
        x++;
    }

    x = 10;
    while (x >= 0) {
        printf("\n%d", x);
        x--;
    }

}
