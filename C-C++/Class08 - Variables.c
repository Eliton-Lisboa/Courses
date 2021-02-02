#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

void main() {
    int i = 303;
    float f = 303.0;
    char c = 'y';
    bool b = false;

    scanf("%d", &i);
    scanf("%f", &f);
    scanf(" %c", &c);
    scanf("%d", &b);

    printf ("%d\n", i);
    printf ("%f\n", f);
    printf ("%c\n", c);
    printf ("%d\n", b);

}
