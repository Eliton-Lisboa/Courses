Set eng = CreateObject( "DAO.BDEngine.36" )
Set cn = CreateObject( "../DataBase/DBVBScript.mdb" )

cn.Execute "delete * from usuario"
cn.Execute "alter table usuario alter column senha char(255)"

cn.Close
MsgBox "Successfull"
