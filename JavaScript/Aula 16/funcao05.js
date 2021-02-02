function fato(number) {
    if (number == 1) {
        return 1
    } else {
        return number * fato(number - 1)
    }
}

console.log(fato(5))
