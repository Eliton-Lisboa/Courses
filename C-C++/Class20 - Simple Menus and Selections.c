#include <stdio.h>
#include <stdlib.h>

void main() {
    int option = 0;

    while (option < 1 || option > 2) {

        printf("\nEnter a option: ");
        printf("\n1. Entrar");
        printf("\n2. Sair\n");
        
        scanf("%d", &option);

        switch (option) {
            case 1:
                printf("\nThe selected option is 1");
                break;

            case 2:
                printf("\nThe selected option is 2");
                break;

            default:
                printf("\nThe selected option not is valid!");
        }

    }

}
