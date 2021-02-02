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
            $value = isset( $_GET['value'] ) ? $_GET['value'] : 1;

            echo "<h1>Calculating the $value factorial</h1>";
            $x = $value;
            $fat = 1;
            do {
                $fat *= $x;
                --$x;
            } while ($x >= 1);
            echo "<h2>$value! = $fat</h2>";
        ?>

        <p><a href='./index.html' class='button'>Come back</a></p>
    </div>
</body>
</html>