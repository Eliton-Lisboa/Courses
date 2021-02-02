#include <stdio.h>
#include <stdlib.h>

void main() {
    int x = 10;

    if (x > 5 && x < 15) {
        printf("\nThe variable x this between 5 and 15");
    }

    if (x < 5 || x < 15) {
        printf("\nThe variable x this between 5 or 15");
    }

    if ((x > 5 && x < 15) || x == 20) {
        printf("\nThe variable x this between 5 or 15 or x is equal to 20");
    }

}
