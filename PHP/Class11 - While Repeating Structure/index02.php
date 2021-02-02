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
        <form method='get' action='./index03.php'>
            <?php
                $x = 1;
                while ($x <= 5) {
                    echo "Value $x: <input type='number' name='value$x' max='100' min='0' value='0'/> <br/>";
                    ++$x;
                }
            ?>
            <input type='submit' value='Send' class='button'/>
        </form>

    </div>
    
</body>
</html>