program program_name
    implicit none

    real::lado1, lado2, area

    print*,'Informe o valor do lado1: '
    read(*,*) lado1

    print*,'Informe o valor do lado2: '
    read(*,*) lado2

    area = (lado1 * lado2) / 2.0

    print*,'O valor da area e: ', area
end program program_name