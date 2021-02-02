subroutine MinhaSub(tmp)
implicit none
    double precision, dimension(1:2, 1:2), intent(inout) :: tmp

    tmp(1, 1) = tmp(1, 1) * 2
    tmp(1, 2) = tmp(1, 2) * 2
    tmp(2, 1) = tmp(2, 1) * 2
    tmp(2, 2) = tmp(2, 2) * 2

end subroutine MinhaSub