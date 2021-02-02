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
            function Sum($a, $b) {
                return $a + $b;
            }

            $x = 3;
            $y = 4;
            $result = sum($x, $y);
            echo "A soma entre $x e $y é igual a $result";
        ?>
    </div>
</body>
</html>