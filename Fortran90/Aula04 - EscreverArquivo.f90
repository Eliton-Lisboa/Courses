program name
implicit none
    integer::x
    real::y

    open(unit = 1, file='filecode.303')

        do x = 1, 30
            y = sin(float(x))
            write(1,*) 'linha: ', y
        end do

    close(unit = 1)


end program name