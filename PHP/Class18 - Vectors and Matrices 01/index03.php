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
            <table border='1'>
                <?php
                    $vector = range(4, 20, 2);
                    
                    foreach ($vector as $value) {
                        echo "<td>$value ";
                    }
                ?>
            </table>
        </pre>
    </div>
</body>
</html>