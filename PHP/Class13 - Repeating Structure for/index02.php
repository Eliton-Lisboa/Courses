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
            <select name='number'>
                <?php
                    for ($x = 1; $x <= 10; ++$x) {
                        echo "<option>$x</option>";
                    }
                ?>
            </select>
            <input type='submit' value='Multiplication Table'/>
        </form>
    </div>
</body>
</html>