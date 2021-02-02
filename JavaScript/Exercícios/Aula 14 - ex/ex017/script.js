function calc() {
    var txb = document.getElementById('txbNumber')
    var list = document.getElementById('Resultado')
    if (txb.value.length == 0) {
        alert('Por favor, digite um número!')
        return
    }

    let number = Number(txb.value)
    let x = 1

    list.innerHTML = ''
    while (x <= 10) {
        let item = document.createElement('option')
        item.text = `${number} x ${x} = ${number * x}`
        item.value = `tab${x}`
        list.appendChild(item)
        x++
    }
}