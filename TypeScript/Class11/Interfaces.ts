// Interfaces

// definição
interface Game {
    title: string
}

interface DLC {
    extra: string
}

// interseção | extend

interface GameCollection extends Game, DLC {}

// implements

class CreateGame implements GameCollection {}

// declarar função

interface getSimilars {
    (title: string): void
}

// =============== Diferenças ===============
interface ID extends number {}

// não consigo definir tuplas na interface 
interface Tuple {
    0: number
    1: number
}

[1, 7, 3, 9, "tuple"] as Tuple

// Pode ter múltiplas declarações e ele une de mesmo nome

interface JQuery {
    a: string
}

interface JQuery {
    b: string
}

const $: JQuery = {
    a: "bla",
    b: "foo"
}

// vantagem: quando tiver criando libs, prefira Interface, porque
// são mais extensíveis

// criando objetos / classes (POO)