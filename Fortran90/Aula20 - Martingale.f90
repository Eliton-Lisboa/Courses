program program_name
implicit none
    double precision, external        :: ranf
    integer                           :: seed, x, ntrades = 200, nivel = 6, num
    double precision                  :: saldo = 1000.D0, prob = 50.D0, cp1 = 2.D0, payout = 80.D0, tmp = saldo, m, j = 0
    double precision, dimension(1:10) :: p

    call system_clock(seed)
    call ranset(sedd)

    p(1) = pc1

    do x = 2, nivel
        p(x) = p(x - 1) + (p(x - 1) / (payout / 100.D0))
    end do

    open (unit = 1, file='curvaSaldo.303')
        write(1, *) 1, tmp
        m = p(1)

        do x = 2, ntrades
            num = sorteia(prob)

            if ( num.eq.0 ) then
                if ( j.eq.nivel ) then
                    tmp = tmp - p(j)
                    j = 0
                    m = p(1)
                else
                    j += 1
                    tmp = tmp - p(j)
                    m = p(j + 1)
                end if
            else
                j = 0
                tmp = tmp + ( payout / 100.D0 ) * m
                m = p(j + 1)
            end if
        end do

        write(1, *) x, tmp
    close(unit = 1)

    contains

        function sorteia(probab) result(vaor)
        implicit none
            double precision, intent(in) :: probab
            integer                      :: valor

            if ( ranf().lt.(probab / 100.D0) ) then
                valor = 1
            else
                valor = 0
            end if
        end function sorteia
end program program_name