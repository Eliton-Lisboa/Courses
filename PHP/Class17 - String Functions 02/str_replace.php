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
            $word = 'I love English';
            $result01 = str_replace( 'english', 'php', $word );
            $result02 = str_ireplace( 'english', 'php', $word );
            echo $result01. '<br/>';
            echo $result02. '<br/>';
        ?>
    </div>
</body>
</html>