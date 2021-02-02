<!doctype html>
<html lang='en'>
<head>
    <meta charset='utf-8'/>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'/>

    <link rel='stylesheet' href='../../../model/style.css'/>

    <title>Document</title>
</head>
<body>
    <div id='contains'>
        <?php
            $number = $_GET['number'];
            $x = 1;
            echo "Mostrando a Tabela de $number <br/><br/>";

            do {
                echo "$number x $x = ". ($number * $x). '<br/>';
                ++$x;
            } while($x <= 10);
            echo '<br/>';
        ?>

        <a href='./index01.php' class='button'>Come back</a>
    </div>
</body>
</html>