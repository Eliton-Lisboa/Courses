program program_name
implicit none
    
    integer :: x1 = 34, x2 = 50
    call MinhaSub(x1, x2)



    contains
        subroutine MinhaSub(a, b)
        implicit none
            integer, intent(in)  :: a, b   ! impossibilita editar os valores extenrnos.
            ! integer, intent(out) :: c, d ^ possibilita editar os valores extenrnos.

            print *, 'x1: ', a
            print *, 'x2: ', b
        end subroutine MinhaSub

end program program_name