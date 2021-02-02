<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='utf-8'/>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'/>

    <link rel='stylesheet' href='../model/style.css'/>

    <title>Document</title>
</head>
<body>

    <div id='contains'>
        <?php
            $value = $_GET['value'];
            $squareroot = sqrt($value);
            echo "The root of $value is equal to ". number_format($squareroot, 2). '<br/>';
        ?>

        <a href='./index.html'>Voltar</a>
    </div>

</body>
</html>