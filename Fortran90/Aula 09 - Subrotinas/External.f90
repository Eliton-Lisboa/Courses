program program_name
implicit none
    
    double precision, dimension(1:2, 1:2) :: matriz
    matriz(1, 1) = 10.00
    matriz(1, 2) = 15.00
    matriz(2, 1) = 20.00
    matriz(2, 2) = 25.00

    print *, ''
    print *, 'Antes da subrotina: '
    print *, '(1:1) ', matriz(1, 1)
    print *, '(1:2) ', matriz(1, 2)
    print *, '(2:1) ', matriz(2, 1)
    print *, '(2:2) ', matriz(2, 2)

    call MinhaSub(matriz)

    print *, ''
    print *, 'Depois da subrotina: '
    print *, '(1:1) ', matriz(1, 1)
    print *, '(1:2) ', matriz(1, 2)
    print *, '(2:1) ', matriz(2, 1)
    print *, '(2:2) ', matriz(2, 2)

end program program_name