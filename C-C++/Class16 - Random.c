#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void main() {
    srand( (unsigned) time(NULL));

    int random = rand() % 3;
    printf("\nThe random number is: %d", random);

    random = (rand() % 5) + 1;
    printf("\nThe random number is: %d", random);

}
