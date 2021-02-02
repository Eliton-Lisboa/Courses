program program_name
    implicit none

    integer :: numAcertos
    real :: result

    print*, 'Digite um valor entre 5 e 15: '
    read(*, *) numAcertos

    select case (numAcertos)
        case (11)
            print*, 'Voce ganhou 5 reais.'
        case (12)
            print*, 'Voce ganhou 10 reais.'
        case (13)
            print*, 'Voce ganhou 20 reais.'
        case (14)
            print*, 'Voce ganhou 2 mil reais.'
        case (15)
            print*, 'Voce ganhou a milhao de reais.'
        case default

            if ( ( numAcertos.ge.5 ).and.( numAcertos.le.10 ) ) then
                print*, 'Nao foi desta vez!'
            else
                print*, 'Error: not is posible write this number!'
            end if

    end select

end program program_name