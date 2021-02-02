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
            $vector01[0] = 303;
            $vector01[1] = '303';
            $vector01[2] = 303.0;
            $vector01[3] = false;

            print_r($vector01);

            $vector02 = array(303, '303', 303.0, false);

            echo '<br/>';

            print_r($vector02);
        ?>
    </div>
</body>
</html>