Set eng = CreateObject( "DAO.BDEngine.36" )
Set cn = CreateObject( "../DataBase/DBVBScript.mdb" )

cn.Execute "create table usuario (login String, senha String, nome String)"
cn.Close

MsgBox "Successfull"
