<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='utf-8'/>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'/>

    <link rel='stylesheet' href='../../model/style.css'/>

    <title>Document</title>
</head>
<body>

    <div id='contains'>
        <?php
            $name = isset( $_GET['name'] ) ? $_GET['name'] : '[ name not informed ]';
            $year = isset( $_GET['year'] ) ? $_GET['year'] : 0;
            $sex = isset( $_GET['sex'] ) ? $_GET['sex'] : '[ no sex ]';

            $age = date('Y') - $year;
            echo "$name is $sex and is $age age. <br/>";
        ?>

        <a href='./index.html'>Voltar</a>
    </div>

</body>
</html>