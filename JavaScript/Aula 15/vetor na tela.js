let values = [8, 1, 7, 4, 2, 9]

console.log(values)
/*
console.log(values[0])
console.log(values[1])
console.log(values[2])
console.log(values[3])
console.log(values[4])
console.log(values[5])
*/

/*
for (let pos = 0; pos < values.length; pos++) {
    console.log(`A posição ${pos} tem o valor ${values[pos]}`)
}
*/

for (let pos in values) { //Foreach
    console.log(values[pos])
}