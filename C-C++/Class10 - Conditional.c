#include <stdio.h>
#include <stdlib.h>

void main() {
    int x = 5;
    char y = 'n';

    if (x == 5) {
        printf("\nThe variable x is equal to: %d", x);
    }

    if ((x % 2) != 0) {
        printf("\nThe variable x is prime");
    }
    else {
        printf("\nThe variable x is even");
    }

    if (y == 'y')
        printf("\nThe variable y is 'y'");
    
    else if (y == 'n') {
        printf("\nThe variable y is 'n'");
    }
    else {
        printf("\nThe variable y is different of 'y' and different of 'n'");
    }

}
