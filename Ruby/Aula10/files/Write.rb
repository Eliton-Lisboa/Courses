File.open('./shopping-list.303', 'a') do |line|
    line.puts('< ~Arroz')
    line.puts('< ~Feijão')
    line.print('< *Leite')
    line.print('<  Celular')
    line.puts('< *Computador')
    line.print('<  Lapis')
end