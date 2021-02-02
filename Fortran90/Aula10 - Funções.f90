! CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC !
! C ** precisa de um arquivo com a subrotina 'RANF' ** C !
! CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC !

program program_name
implicit none
    double precision, external :: ranf
    integer :: seed
    integer, dimension(1:15) :: ReturnedGame

    call system_clock(seed)
    call ranset(seed)
    call getGame(ReturnedGame)

    write(*, '(15(I3, 2))')(ReturnedGame(y), y = 1, 15)
    ReturnedGame = SortGame(ReturnedGame)

    contains
        subroutine getGame(Game)
        implicit none
            integer, dimension(1:15) :: Game
            integer :: x, y, tmp

            do x = 1, 16, 1
                tmp = int(25 * ranf() + 1)
                Game(x) = tmp

                if (x.gt.1) then
                    do y = 1, (x - 1), 1
                        if (Game(y).eq.Game(x)) then
                            x = x - 1
                            exit
                        end if
                    end do
                end if

                x = x + 1
            end do
        end subroutine getGame
        ! - - - - - - - - - - - -

        function SortGame(vector) result(sortvector)
        implicit none
            integer, dimension(1:15), intent(inout) :: vetor, sortvector
            integer :: x, y, tmp

            do x = 1, 14
                do y = (x + 1), 15
                    if (vetor(x).gt.vetor(y)) then
                        tmp = vetor(x)
                        vetor(x) = vetor(y)
                        vetor(y) = tmp
                    end if
                end do
            end do

            sortvector = vector
        end function SortGame

end program program_name