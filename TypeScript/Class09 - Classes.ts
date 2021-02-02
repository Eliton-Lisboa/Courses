abstract class UserAccount {
    public name: string
    protected age: number

    constructor(name: string, age: number) {
        this.name = name
        this.age = age
    }

    logDetails():void {
        console.log(`The player ${this.name} is ${this.age} years old.`)
    }

}

class CharAccount extends UserAccount {
    private nickname: string
    readonly level: number

    constructor(name: string, age: number, nickname: string, level: number) {
        super(name, age)

        this.nickname = nickname
        this.level = level
    }

    get getLevel() {
        console.log('--- get ---')
        return this.level
    }

    set setLevel(level: number) {
        this.level = level
    }

    logCharDetails():void {
        console.log(`The player ${this.name} has the char ${this.nickname} at level ${this.level}`)
    }
}

// const will = new UserAccount('Helliot', 30)
// console.log(will)
// will.logDetails()

const john = new CharAccount('John', 35, 'John', 40)
john.logDetails()
john.setLevel = 499