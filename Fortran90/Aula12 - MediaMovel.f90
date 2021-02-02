program program_name
implicit none
    type dados
        double precision :: x
        double precision :: y
        double precision :: media

    end type dados

    integer                                 :: periodo = 5, alllines = 0, x, y, z
    type (dados), allocatable, dimension(:) :: line
    double precision                        :: soma

    open(unit = 1, file = './media.303')
        do
            read(1, *, end = 303) alllines

        end do
        303 continue
    close(unit = 1)

    allocate(line(1:alllines))
        open(unit = 1, file = './media.303')
            do x = 1, alllines
                read(1, *)line(x)%x, line(x)%y
            end do
        close(unit = 1)

        do x = 1, (alllines - periodo)
            y = x - 1
            soma = 0.00

            do z = x, (periodo + y)
                soma = soma + line(z)%y
            end do
            line(x + periodo)%media = soma / periodo
        end do

        open(unit = 2, file = 'saida.303')
            do x = periodo, alllines
                write(2, *)line(x)%x, line(x)%media
            end do
        close (unit = 2)
    deallocate(line)
    
end program program_name