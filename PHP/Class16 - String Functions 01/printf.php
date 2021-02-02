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
            $product = 'Milk';
            $price = 99.9;

            echo "The $product costs R$". number_format($price, 2);
            echo '<br/>';
            printf('The %s costs R$%.2f', $product, $price);
        ?>
    </div>
</body>
</html>