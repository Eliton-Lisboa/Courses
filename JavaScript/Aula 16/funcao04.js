function fato(number) {
    let fat = 1
    for (let x = number; x > 1; x--) {
        fat *= x
    }
    return fat
}

console.log(fato(5))