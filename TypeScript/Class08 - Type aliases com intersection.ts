// AccountInfo
// CharInfo
// PlayerInfo

type AccountInfo = {
    id: number | string,
    name: string,
    email?: string
}

const account: AccountInfo = {
    id: 182,
    name: 'Helliot',
}

type CharInfo = {
    nickname: string,
    level: number
}

const char: CharInfo = {
    nickname: 'Helliot',
    level: 100
}

// Intersection
type PlayerInfo = AccountInfo & CharInfo

const Player: PlayerInfo = {
    id: 182,
    name: 'Helliot',
    nickname: 'Helliot',
    level: 100
}