#include <stdio.h>
#include <stdlib.h>
#define TAM 3

void main() {
    int vector[TAM];

    for (int x = 0; x < TAM; x++)
    {
        vector[x] = (x + 1) * 5;
    }

    printf("\nFirst potion: %d", vector[0]);
    printf("\nSecond position: %d", vector[1]);
    printf("\nThird position: %d\n", vector[2]);

    for (int x = 0; x < TAM; x++)
    {
        printf("\nThe this vector's value is equal to: %d", vector[x]);
    }

}
