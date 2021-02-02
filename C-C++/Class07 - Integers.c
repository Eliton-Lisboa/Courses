#include <stdio.h>
#include <stdlib.h>

void main() {
    int x = 303;
    printf("The value of variable x is: %d", x);

    x = x * 2;
    printf("\nNow the value of variable x is: %d", x);

    printf("\n\nEnter: ");
    scanf("%d", &x);
    printf("\nNow the value of variable x is: %d", x);
    
}
