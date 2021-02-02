program program_name
implicit none

    character(len=10) :: maiorSaldoNome
    character(len=10), allocatable, dimension(:) :: col1
    real, allocatable, dimension(:) :: col2
    real :: maiorSaldo
    integer :: x, nNames

    ! nNames = 16
    open (unit = 1, file = 'filecode.303')
        x = 0
        do
            read(1, *, end = 303)
            x = x + 1
        end do
        303 continue
    close (unit = 1)
    nNames = x - 1

    allocate(col1(1:nNames))
    allocate(col2(1:nNames))

    open (unit = 1, file = 'filecode.303')
        read(1, *)  ! jump first line
        read(1, *) col1(1), col2(1)
        maiorSaldoNome = col1(1)
        maiorSaldo = col2(1)

        do x = 2, nNames
            read (1, *) col1(x), col2(x)
            if ( col2(x).gt.maiorSaldo ) then
                maiorSaldoNome = col1(x)
                maiorSaldo = col2(x)

            end if

        end do

    close (unit = 1)


    print*, 'O maior saldo e: ', maiorSaldo, ' sendo de: ', maiorSaldoNome

    deallocate(col1)
    deallocate(col2)

    
end program program_name