// Boolean (true / false)
let isOpen: boolean

isOpen = false

// String ('foo', "foo", `foo`)
let message: string
message = `foo ${isOpen}`

// Number
let total: number
total = 0xff0
total = 20
total = 20.53

// Array (type[])
let items: number[]
items = [1, 5, 2, 9, 2]

let values: Array<number>
values = [1, 5, 8, 3]

// Tuple
let title: [number, string, number[]]
title = [7, 'foo', [1, 8, 3, 7, 4]]

// Enum
enum Colors {
    white = '#fff',
    black = '#000'
}

// Any (qualquer coisa) NÃO É LEGAL!
let coisa: any
coisa = true

// Void (Empty)
function logger() {
    console.log('foo')
}

// Null | Undefined
type Bla = string | undefined

// Never
function error(): never {
    throw new Error('error')
}

// Object
let cart: object
cart = {
    key: 'foo'
}

// Type Inference
let msg = 'Message'
msg = 'new Message'

window.addEventListener('click', (e) => {
    console.log(e.target)
})


