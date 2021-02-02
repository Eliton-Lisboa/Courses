Set eng = CreateObject( "DAO.DBEngine.36" )
Set cn = eng.OpenDataBase( "../DataBase/DBVBScript.mdb" )

On error resume next
    cn.Execute "drop table cadMenu"
On error goto 0

cn.Execute "create table cadMenu (ID autoincrement, Menu String, Tela String)"

cn.Execute "insert into cadMenu (Menu, Tela)" & _
           "values ('Menu -> Administração -> Gestão de usuários -> Cadastro de usuários -> ', " & _
           "'cadUsuario.html')"

cn.Execute "insert into cadMenu (Menu, Tela)" & _
           "values ('Menu -> Administração -> Gestão de menus -> Cadastro de menus -> ', " & _
           "'cadUsuario.html')"

cn.Execute "insert into cadMenu (Menu, Tela)" & _
           "values ('Menu -> Nome menu -> Gestão de usuários -> Cadastro de usuários -> ', " & _
           "cadUsuario.html')"

MsgBox "Tabela Criada"
