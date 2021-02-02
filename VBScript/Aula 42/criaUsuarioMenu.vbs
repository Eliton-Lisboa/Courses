Set eng = CreateObject( "DAO.DBEngine.36" )
Set cn = eng.OpenDataBase( "../DataBase/DBVBScript.mdb" )

On error resume next
    cn.Execute "drop table usuarioXMenu"
On error goto 0

cn.Execute "create table usuarioXMenu (ID_menu integer, login String)"

cn.Execute "insert into usuarioXMenu (ID_menu, login)" & _
           "values (1, 'Eliton')"

cn.Execute "insert into usuarioXMenu (ID_menu, login)" & _
           "values (2, 'Eliton')"

cn.Execute "insert into usuarioXMenu (ID_menu, login)" & _
           "values (1, 'KK')"

cn.Execute "insert into usuarioXMenu (ID_menu, login)" & _
           "values (3, 'Eliton')"

MsgBox "Tabela criada"
