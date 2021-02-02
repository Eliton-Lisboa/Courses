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
            $name = 'Eliton';
            $new = str_pad($name, 48, '&nbsp;', STR_PAD_RIGHT);
            print('I '. $new. 'love php');
            // STR_PAD_RIGHT
            // STR_PAD_CENTER
            // STR_PAD_LEFT
        ?>
    </div>
</body>
</html>