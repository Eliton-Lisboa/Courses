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
            $x = 1;
            while ($x <= 10) {
                echo $x. '<br/>';
                ++$x;
            }
            echo '<br/>';

            $x = 10;
            while ($x >= 1) {
                echo $x. '<br/>';
                --$x;
            }
            echo '<br/>';

            $x = 10;
            while ($x >= 0) {
                echo $x. '<br/>';
                $x -= 2;
            }
        ?>

    </div>
    
</body>
</html>