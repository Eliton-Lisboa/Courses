#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void main() {
    char word[255];

    printf("Enter a word: ");

    setbuf(stdin, 0);
    fgets(word, 255, stdin);

    // Clean unused vectors
    word[strlen(word) - 1] = '\0';

    printf("%s", word);

}
