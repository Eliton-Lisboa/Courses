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
        <form method='get' action='./index02.php'>
            Number:
            <select name='number'>
                <?php
                    $x = 1;
                    do {
                        echo "<option value='$x'> $x </option>";
                        ++$x;
                    } while ($x <= 10);
                ?>
            </select>
            <input type='submit' value='Multiplication Table'/>
        </form>
    </div>
</body>
</html>