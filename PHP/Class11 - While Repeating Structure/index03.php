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
            while ($x <= 5) {
                $tmp = 'num'. $x;
                $url = 'value'. $x;
                $$tmp = isset( $_GET[$url] ) ? $_GET[$url] : 0;
                ++$x;
            }

            $x = 1;
            while ($x <= 5) {
                $tmp = 'num'. $x;
                echo "Value $x : ". $$tmp. '<br/>';
                ++$x;
            }
        ?>

    </div>
    
</body>
</html>