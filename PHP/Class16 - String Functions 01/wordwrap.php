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
            $word = 'This is an example of big string ...';
            $result = wordwrap($word, 5, "<br/>\n", false);
            echo $result;
        ?>
    </div>
</body>
</html>