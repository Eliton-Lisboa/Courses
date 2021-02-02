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
            $number = $_GET['number'];

            for ($x = 1; $x <= 10; ++$x) {
                echo "$number x $x = ". ($number * $x). '<br/>';
            }
        ?>
        <br/><a href='javascript:history.go(-1)' class='button'>Come back</a>
    </div>
</body>
</html>