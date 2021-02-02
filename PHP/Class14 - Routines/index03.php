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
            function sum() {
                $vector = func_get_args();
                $total = func_num_args();
                $result = 0;

                for ($x = 0; $x < $total; ++$x) {
                    $result += $vector[$x];
                }

                return $result;
            }

            echo 'A soma dos valores é '. sum(1, 4, 8, 2);
        ?>
    </div>
</body>
</html>