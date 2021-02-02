program program_name
implicit none
    integer::x
    x = 1

    do while (x.le.5)
        print*,'Hello, World!'
        x = x + 1
    end do

end program program_name