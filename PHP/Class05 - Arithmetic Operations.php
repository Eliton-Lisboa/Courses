<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='utf-8'/>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'/>

    <link rel='stylesheet' href='./model/style.css'/>

    <title>Document</title>
</head>
<body>
    
    <div id='contains'>
        <?php
            $number1 = $_GET['a'];
            $number2 = $_GET['b'];
            $average = ($number1 + $number2) / 2;

            echo "The sum between $number1 and $number2 is ". ($number1 + $number2). '<br/>';
            echo "The subtraction between $number1 and $number2 is ". ($number1 - $number2). '<br/>';
            echo "The multiplication between $number1 and $number2 is ". ($number1 * $number2). '<br/>';
            echo "The division between $number1 and $number2 is ". ($number1 / $number2). '<br/>';
            echo "The module is worth ". ($number1 % $number2). '<br/>';
            echo "The average is ". ($number1 % $number2). '<br/>';

            // Functions
            echo '<br/>';

            $v1 = $_GET['x'];
            $v2 = $_GET['y'];
            echo "Amounts received: $v1 and $v2 <br/>";
            echo "The absolute value of $v2 is ". abs($v2). ' <br/>';
            echo "The value of $v1<sup>$v2</sup> is ". pow($v1, $v2). ' <br/>';
            echo "The root of $v1 is ". sqrt($v1). ' <br/>';
            echo "The value of $v2 rounded is ". round($v2). ' <br/>'; // ceil - rounded for up / floor - rounded for down
            echo "The entire portion of $v2 is ". intval($v2). ' <br/>';
            echo "The value of $v1 in currency is R$". number_format($v1, 2, ',', '.');

        ?>
    </div>

</body>
</html>