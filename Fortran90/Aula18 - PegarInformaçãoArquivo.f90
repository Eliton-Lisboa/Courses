program program_name
implicit none
    character( len = 100 ) :: stringList, tmp1, tmp2
    integer                :: x = 0, xs, xe
    logical                :: flag = .false.

    tmp1 = 'outcoor: Atomic coordinates (scaled):'
    tmp2 = 'superc: Internal auxiliary supercell:'

    open ( unit = 1, file = 'CGO.out' )
        do
            read( 1, '(A100)', end = 303 ) stringList
            x = x + 1

            if ( stringList(1:37).eq.tmp1(1:37) )  then
                flag = .true.
                xs = x
            end if
            if ( ( stringList(1:37).eq.tmp2(1:37) ).and.(flag.eqv..true.) ) then
                xe = x
                goto 303
            end if
        end do
        303 continue
    close ( unit = 1 )

    xe = xe - 2

    open ( unit = 1, file = 'CGO.out' )
    open ( unit = 2, file = 'saida.303' )
        do x = 1, ( xs - 1 )
            read( 1, * )
        end do

        do x = xs, xe
            read ( 1, '(A100)' ) stringList
            write( 2, '(A37)' ) stringList(1:37)
        end do
    close ( unit = 2 )
    close ( unit = 1 )

end program program_name