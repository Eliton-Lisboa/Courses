<!doctype html>
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
            include './functions.php'; //       ^ se não encontrar ele continua
            // require './functions.php';       ^ se não encontrar ele para
            // include_once './functions.php';  ^ se já estiver rodando ele não faz
            // require_once './functions.php';  ^ se já estiver rodando ele não faz

            echo '<h1>Testando novas funções</h1>';

            hello();
            showValue(4);
            echo '<h2>Finalizando o programa...</h2>';
        ?>
    </div>
</body>
</html>