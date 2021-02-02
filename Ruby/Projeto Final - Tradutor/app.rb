# Crie um software que permita que o
# usuário entre com um texto, o idioma
# em que o texto está escrito e também
# o idioma para qual ele deseja traduzir
# o texto, e receba como resposta na
# tela o texto traduzido.

# Critérios:
# Você deve utilizar orientação a objetos no seu software
# O resultado de cada tradução (junto com a frase original),
# deve ser guardado em um arquivo que possua no nome a
# data e horário da tradução (exp: 10-10-18_10:30.txt)

# [Recursos]
# Para realizar as chamadas Web utilize a Gem Rest Client (documentação): https://github.com/rest-client/rest-client
# Para realizar a tradução utilize a API do Yandex.
# Crie sua conta e pegue seu Token de autenticação nesta URL: https://translate.yandex.com/developers/keys
# Veja como realizar a chamada nessa URL: https://tech.yandex.com/translate/doc/dg/reference/translate-docpage/
require 'easy_translate'

loop do
    system 'cls'
    puts ' '
    puts '0. Sair'
    puts ' '
    print 'Digite em qual idioma sera o texto: '
    idioma = gets.chomp
    if idioma == '0'
        break
    else
        puts ' '
        print 'Digite o texto para traduzir: '
        text = gets.chomp
        puts ' '
        print 'Digite para qual idioma deseja traduzir: '
        translateto = gets.chomp

        EasyTranslate.translate('Hola, mundo', :from => :spanish, :to => :en) # => "Hello, world"

        # puts translate


        gets.chomp
    end

end