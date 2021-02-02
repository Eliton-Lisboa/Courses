program program_name
implicit none
    double precision      :: hour, minute, second
    character( len = 20 ) :: name, time

    open( unit = 1, file = './dadosentrada.303' )
        do
            read( 1, *, end = 303 ) name, time
            read( time(1:2), * ) hour
            read( time(4:5), * ) minute
            read( time(7:8), * ) second

            print *, returnHours(hour, minute, second), &
                     & returnMinutes(hour, minute, second), &
                     & returnSeconds(hour, minute, second)
        end do
        303 continue

    close( unit = 1 )

    contains
        function returnHours(hour, minute, second) result(result)
        implicit none
            double precision :: hour, minute, second, result

            result = hour + (minute / 6.D1) + (second / 36.D2)
        end function returnHours

        function returnMinutes(hour, minute, second) result(result)
        implicit none
            double precision :: hour, minute, second, result

            result = (hour * 6.D1) + minute + (second * 6.D1)
        end function returnMinutes

        function returnSeconds(hour, minute, second) result(result)
        implicit none
            double precision :: hour, minute, second, result

            result = (hour * 36.D2) + (minute * 6.D1) + second
        end function returnSeconds

end program program_name