function calc() {
    var pais = document.getElementById('txbPais')
    pais = pais.value
    var ress = document.getElementById('input')
    var result = 'Estrangeiro!'

    if (pais == 'Brasil') {
        result = 'Brasileiro!'
    }

    ress.innerHTML = `<p>Vivendo em ${pais}</p>`
    ress.innerHTML += `<p>Você é ${result}</p>`
}