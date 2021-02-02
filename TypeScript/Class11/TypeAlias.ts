// Type Alias

import { type } from "os"

// definição
type GameT = {
    title: string
}

type DLCT = {
    extra: string
}

// interaction

type GameCollectionT = Game & DLCT & { content: boolean }

// implements

class CreateGameT implements GameCollection {}

// declarar função

type getSimilarsT = (title: string) => void

// =============== Diferenças ===============

// permite declarar tipos primitivos

type IDT = string | number

// pode declarar tuplas normalmente

type TupleT = [number, number]

[2, 7, 3] as Tuple

// Apenas uma declaração por escopo

type JQueryT = { a: string }
type JQueryT = { b: string }

// Mais recomendado:
// na maioria das vezes
// React - Props

// CONSISTÊNCIA!
