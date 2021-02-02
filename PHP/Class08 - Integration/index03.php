<!DOCTYPE html>
<html lang='en'>
<head>
    <?php
        $text = isset( $_GET['text'] ) ? $_GET['text'] : '[ generic text ]';
        $size = isset( $_GET['size'] ) ? $_GET['size'] : '12pt';
        $color = isset( $_GET['ucolor'] ) ? $_GET['ucolor'] : '#000000';
    ?>

    <meta charset='utf-8'/>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'/>

    <link rel='stylesheet' href='../../../model/style.css'/>
    <style>
        span.text {
            font-size: <?php echo $size; ?>;
            color: <?php echo $color; ?>;
        }
    </style>

    <title>Document</title>
</head>
<body>
    
    <div id='contains'>
        <?php
            echo "<span class='text'>$text</span>";
        ?>
    </div>

</body>
</html>