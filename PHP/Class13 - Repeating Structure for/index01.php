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
            for ($x = 0; $x <= 10; ++$x) {
                echo "$x ";
            }
            echo '<br/><br/>';

            for ($x = 10; $x >= 0; --$x) {
                echo "$x ";
            }
            echo '<br/><br/>';

            for ($x = 0; $x <= 50; $x += 5) {
                echo "$x ";
            }
            echo '<br/><br/>';

            for ($x = 20; $x >= 0; $x -= 2) {
                print "$x ";
            }
        ?>
    </div>
</body>
</html>