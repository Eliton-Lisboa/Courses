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
                $result = $a + $b;
                echo "<p>The sum is $result</p>";
            }

            Sum(3, 4);
            Sum(8, 2);
            $x = 9;
            $y = 15;
            Sum($x, $y);
        ?>
    </div>
</body>
</html>