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
        <pre>
            <?php
                $vector = array(3 => 5, 1 => 9, 0 => 8, 7 => 7);
                unset($vector[0]);
                print_r($vector);
            ?>
        </pre>
    </div>
</body>
</html>