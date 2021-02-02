// S => State
// T => Type
// K => Key
// V => Value
// E => Element

type numOrStr = number | string
//               |  Tipos aceitos   |  default
function useState<S extends numOrStr = string>() {
    let state: S

    function getState() {
        return state
    }

    function setState(newState: S) {
        state = newState
    }

    return { getState, setState }
}

const newState = useState()

newState.setState('foo') // é uma string
console.log(newState.getState())

newState.setState(374) // dê erro
console.log(newState.getState())

newState.setState('test')
console.log(newState.getState())
