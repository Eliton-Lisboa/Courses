program program_name
implicit none
    double precision, external     :: ranf
    integer                        :: seed, x, y
    double precision               :: probZero = 0.5D0
    integer, dimension(1:10, 1:10) :: Spin

    call system_clock(seed)
    call ranset(seed)

    do x = 1, 10
        do y = 1, 10
            Spin(x, y) = state(probZero)
        end do
    end do

    do x = 1, 10
        write( *, '(10(I4))' ) ( Spin(x, y), y=1, 10 )
    end do

    contains

    function state(prob) result(value)
    implicit none
        double precision, intent(in) :: prob
        double precision             :: randomnumber = ranf()
        integer                      :: value

        if ( randomnumber.lt.prob ) then
            value = 0
        else
            value = 1
        end if

    end function state
end program program_name