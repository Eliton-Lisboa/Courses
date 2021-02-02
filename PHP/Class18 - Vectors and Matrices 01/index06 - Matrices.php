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
                $vector = array( 'array1' => array(6, 4), 'array2' => array(4, 9), 'array3' => array(3, 2) );
                $vector['array1'][1] = $vector['array3'][0];

                print_r($vector);
            ?>
        </pre>
    </div>
</body>
</html>