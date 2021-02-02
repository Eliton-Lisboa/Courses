program program_name
implicit none
    double precision, external :: ranf
    double precision           :: tmp
    integer                    :: seed, x, y = 0, xmax = 200, xinclement = 1, xmin = 0

    call system_clock( seed )
    call ranset( seed )

    x = xmin

    open ( unit = 1, file = 'saida.303' )
    do while ( x.le.xmax )
        tmp = ranf()

        if ( tmp.gt.0.5 ) then
            y = y + 1
        else
            y = y - 1
        end if
        write(1, *)x, y

        x = x + xinclement
    end do

    close ( unit = 1 )
end program program_name