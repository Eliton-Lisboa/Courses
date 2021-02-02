puts '--- Lista de compreas no shopping ---'
puts ' '

file = File.open('./shopping-list.303')

file.each do |line|
    puts line
end
puts ' '