module minhasDefinicoesDeTipo
implicit none
    
    public
    type tCarro
        character(len = 20) :: cor
        character(len = 50) :: nome
        integer             :: ano
        double precision    :: peso
    end type tCarro

    type tJogador
        character(len = 100) :: nome
        character(len = 14)  :: cpf
        character(len = 8)   :: rg
        integer              :: idade
        type (tCarro)        :: carro
        logical              :: ativo ! boolean
    end type tJogador

end module minhasDefinicoesDeTipo

program program_name
use minhasDefinicoesDeTipo
implicit none
    integer                         :: x
    type (tJogador), dimension(1:3) :: Jogador

    Jogador(1)%nome = 'Eliton lisboa'
    Jogador(1)%cpf = '123.456.789-12'
    Jogador(1)%carro%cor = 'black'
    Jogador(1)%carro%ano = '2020'

    do x = 1, 1000
        if (Jogador(x)%carro%cor.eq.'black') then
            print *, Jogador%nome
        end if
    end do

end program program_name