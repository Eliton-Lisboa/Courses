function btnContar_Click() {
    let Inicio = document.getElementById('txbInicio')
    let Fim = document.getElementById('txbFim')
    let Passo = document.getElementById('txbPasso')
    let result = document.getElementById('Resultado')

    if (Inicio.value.length == 0 || Fim.value.length == 0 || Passo.value.length == 0) {
        result.innerHTML = 'Impossivel contar!'
        //alert('[ERRO] Faltam dados!')
    } else {

        result.innerHTML = 'Contando: <br/>'
        if (parseInt(Passo.value) <= 0) {
            window.alert('Passo inválido! Considerado PASSO 1')
            Passo = '1'
        }
        if (parseInt(Inicio.value) > parseInt(Fim.value)) {

            for (var x = parseInt(Inicio.value); x <= parseInt(Fim.value); x += parseInt(Passo.value)) {
    
                result.innerHTML += ` ${x} \u{1f449}`
            }
        }else {
            for (let x = parseInt(Inicio.value); x >= parseInt(Fim.value); x -= parseInt(Passo.value)) {
                result.innerHTML += ` ${x} \u{1f449}`
            }
        }

        result.innerHTML += `\u{1f3c1}`
    }



}