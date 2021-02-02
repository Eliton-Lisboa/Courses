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
            $vector[0] = 'Video';
            $vector[1] = 'Curse';

            $text = implode( ' ', $vector ); # or join function
            print( $text );
        ?>
    </div>
</body>
</html>