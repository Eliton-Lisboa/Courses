program program_name
implicit none

    integer   :: num1
    real      :: num2
    character :: num3
 
    num1 = 303
    num2 = 3.03
    num3 = '303'

    write (*, '(i8.6)') num1
    write (*, '(f8.6)') num2
    write (*, '(a8)') num3

    ! ----------- // -----------

    call system('cls')
    
end program program_name