#include <stdio.h>
#include <stdlib.h>
#include <string>
#include <iostream>

using namespace std;

int main() {
    float array[2][2];

    array[0][0] = 0.0;
    array[0][1] = 0.1;
    array[1][0] = 1.0;
    array[1][1] = 1.1;

    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++) {
            cout << "\n" << array[x][y];
        }

        cout << "\n";
    }
}
