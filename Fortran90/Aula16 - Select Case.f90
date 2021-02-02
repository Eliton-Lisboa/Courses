program program_name
implicit none
    character( len = 20 ) :: name, time
    double precision      :: result1, result2, result3

    open( unit = 1, file = './dadosentrada.303' )
        do
            read( 1, *, end = 303 ) name, time

            call returnForamatedTime(time, 1, result1)
            call returnForamatedTime(time, 2, result2)
            call returnForamatedTime(time, 3, result3)

            print *, name, time, result1, result2, result3
        end do
        303 continue

    close( unit = 1 )

    contains
        subroutine returnForamatedTime(time, type, result)
        implicit none
            character( len = 20 ), intent(in) :: time
            integer                           :: type
            double precision, intent(out)     :: result
            double precision                  :: hour, minute, second

            read( time(1:2), * ) hour
            read( time(4:5), * ) minute
            read( time(7:8), * ) second

            select case( type )
                case (1) result = hour + (minute / 6.D1) + (second / 36.D2)
                case (2) result = (hour * 6.D1) + minute + (second * 6.D1)
                case (3) result = (hour * 36.D2) + (minute * 6.D1) + second

                case default
                    print *, 'Variable type out of flaw [1, 3]'
                    stop

            end select

        end subroutine returnForamatedTime

end program program_name