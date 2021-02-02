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
            $word = '   Video Course   ';
            echo 'The normal is: '. str_replace( ' ', '_', $word). '<br/><br/>';

            $result = str_replace( ' ', '_', trim($word) );
            echo 'trim: '. $result. '<br/>';

            $result = str_replace( ' ', '_', ltrim($word) );
            echo 'ltrim: '. $result. '<br/>';

            $result = str_replace( ' ', '_', rtrim($word) );
            echo 'rtrim: '. $result. '<br/>';
        ?>
    </div>
</body>
</html>