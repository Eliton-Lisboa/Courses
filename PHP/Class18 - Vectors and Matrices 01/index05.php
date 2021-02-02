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
                $vector = array('name' => 'Eliton', 'age' => 15, 'languages' => 20);
                $vector['love'] = 'false';

                foreach ($vector as $key => $value) {
                    echo 'The '. $key. ' field has the value '. $value. '<br/>';
                }
            ?>
        </pre>
    </div>
</body>
</html>