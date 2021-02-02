program program_name
implicit none
    integer::value, jump, x
    jump = 1
    value = 10

    print*,'Informe o valor de vezes: '
    read(*,*) value
    print*,'Informe o valor a ser pulado: '
    read(*,*) jump

!      valor ; até ; add
    do x = 0, value, jump
        print*,'Line: ', x
    end do

end program program_name