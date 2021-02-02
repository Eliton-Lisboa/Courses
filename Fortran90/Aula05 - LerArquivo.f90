program program_name
implicit none

    character(len=10) :: col1, maiorSaldoNome
    real :: col2, maiorSaldo

    open(unit=1, file='filecode.303')

        read(1, *) ! jump one line
        read(1, *) col1, col2

        maiorSaldo = col2
        maiorSaldoNome = col1
        do
            read(1, *, end=303) col1, col2
            if ( col2 > maiorSaldo ) then
                maiorSaldo = col2
                maiorSaldoNome = col1
            end if

            print*, col1, col2
        end do

        303 continue
    close(unit=1)

    print*, 'O maior saldo e de ', maiorSaldoNome, 'com', maiorSaldo, 'de saldo!'
    
end program program_name