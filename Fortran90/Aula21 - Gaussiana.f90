program program_name
implicit none
    double precision, external         ::ranf
    integer                            :: seed, n1 = 1, nniveis = 6, nparticulas = 10, npassos = 1000000, x, y, z, soma, emin, emax, rotulo
    integer, allocatable, dimension(:) :: particula, nz, energia

    call system_clock(seed)
    call ranset(seed)

    allocate(particula(1:nparticulas))
    allocate(nz(1:nniveis))
    open(unit = 1, file='saida.303')

    do x = 1, npassos
        do y = 1, nparticulas
            particula(1) = randomRange(n1, nniveis)
        end do
        nz = 0

        do y = 1, nparticulas
            do z = 1, nniveis
                if ( particula(y).eq.z ) then
                    nz(z) = nz(z) + 1
                end if
            end do
        end do

        soma = 0
        do z = 1, nniveis
            soma = soma + (nz(z) * z)
        end do
        write(1, *) soma

    end do

    close(unit = 1)
    deallocate(particula)
    deallocate(nz)

    emin = nparticulas
    emax = nniveis * nparticulas
    allocate(energia(emin:emax))

    open(unit = 2, file='saida.303')
        energia = 0

        do
            read(2, *, end = 303) rotulo
            energia(rotulo) = energia(rotulo) + 1
        end do
        303 continue
    close(unit = 2)

    open(unit = 3, file='plotar.303')
        do x = emin, emax
            write(3, *) x, energia(x)
        end do
    close(unit = 3)

    deallocate(energia)

    contains
        function randomRange(nmin, nmax) result(nivelEnergia)
        implicit none
            integer, intent(in) :: nmin, nmax
            integer             :: nivelEnergia

            nivelEnergia = int(nmax * ranf() + nmin)
        end function randomRange

end program program_name