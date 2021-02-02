program program_name
    implicit none

    integer::numAcertos
    real::result

    print*,'Digite um valor entre 5 e 15: '
    read(*,*) numAcertos
    
    if ( (numAcertos.lt.5).or.(numAcertos.gt.15) ) then
        print*,'Error: not is posible write this number!'

    else if (numAcertos.le.10) then
        print*,'Nao foi desta vez!'

    else if (numAcertos.eq.11) then
        print*,'Voce ganhou 5 reais.'

    else if (numAcertos.eq.12) then
        print*,'Voce ganhou 10 reais.'

    else if (numAcertos.eq.13) then
        print*,'Voce ganhou 20 reais.'

    else if (numAcertos.eq.14) then
        print*,'Voce ganhou 2 mil reais.'

    else if (numAcertos.eq.15) then
        print*,'Voce ganhou 1 milhao de reais.'

    end if

end program program_name