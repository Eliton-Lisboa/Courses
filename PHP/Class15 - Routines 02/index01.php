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
            function teste(&$x) {
                $x += 2;
                echo 'O valor de X é '. $x;
            }

            $a = 3;
            teste($a);
            echo "<p>O valor de A é $a</p>";
        ?>
    </div>
</body>
</html>