import std.stdio;

void main() {
    string word, key;

    write("Enter a word: ");
    word = readln();

    const int word_length = word.length;
    char[] cripto = word.dup;

    write("Enter a key: ");
    key = readln();
    int key_length = key.length

    // Loop de criptografia xor
    for (int x = 0; x < word_length; x++)
    {
        cripto[x] = word[x] ^ key[x % key_length];
    }

    writeln("Original word: ", word);
    write("Cryptography word: ");
    write(cripto);
    writeln();
    readln();
    char[] descripto = cripto.dup;
    for (int x = 0; x < word_length; x++)
    {
        descripto[x] = cripto[x] ^ key[x % key_length];
    }
    write("Descryptography word: ", descripto);
    readln();
}
