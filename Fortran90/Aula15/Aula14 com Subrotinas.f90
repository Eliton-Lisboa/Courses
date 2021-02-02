program program_name
implicit none
    double precision      :: hour, minute, second, tmp1, tmp2, tmp3
    character( len = 20 ) :: name, time

    open( unit = 1, file = './dadosentrada.303' )
        do
            read( 1, *, end = 303 ) name, time
            read( time(1:2), * ) hour
            read( time(4:5), * ) minute
            read( time(7:8), * ) second

            call returnHours(hour, minute, second, tmp1)
            call returnMinutes(hour, minute, second, tmp2)
            call returnSeconds(hour, minute, second, tmp3)

            print *, name, time, tmp1, tmp2, tmp3
        end do
        303 continue

    close( unit = 1 )

    contains
        subroutine returnHours(hour, minute, second, value)
        implicit none
            double precision, intent(in)  :: hour, minute, second
            double precision, intent(out) :: value

            value = hour + (minute / 6.D1) + (second / 36.D2)
        end subroutine returnHours

        subroutine returnMinutes(hour, minute, second, value)
        implicit none
            double precision, intent(in)  :: hour, minute, second
            double precision, intent(out) :: value

            value = (hour * 6.D1) + minute + (second * 6.D1)
        end subroutine returnMinutes

        subroutine returnSeconds(hour, minute, second, value)
        implicit none
            double precision, intent(in)  :: hour, minute, second
            double precision, intent(out) :: value

            value = (hour * 36.D2) + (minute * 6.D1) + second
        end subroutine returnSeconds

end program program_name