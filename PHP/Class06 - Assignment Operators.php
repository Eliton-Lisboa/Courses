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
            $price = $_GET['p'];
            echo "The product price is R$". number_format($price, 2, ',', '.'). ' <br/>';
            $price += $price * 10 / 100;
            echo "The price with 10% increase will be R$". number_format($price, 2, ',', '.');

            echo '<br/><br/>';
            $price = $_GET['p'];
            $price -= $price * 10 / 100;
            echo "The price with 10% discount will be R$". number_format($price, 2, ',', '.');

            // year
            echo '<br/><br/>';

            $year = $_GET['year'];
            echo "The current year is $year and the previous year is ". --$year;

            // References
            echo '<br/><br/>';

            $a = 3;
            $b = &$a;
            $b += 5;
            echo "The variable \"a\" is worth $a <br/>";
            echo "The variable \"b\" is worth $b <br/>";

            // Variables of Variables
            echo '<br/><br/>';

            $x = 'abc';
            $$x = 'def';
            echo "The content of the variable \"x\" is \"$x\" <br/>";
            echo "The created variable \"abc\" received the value \"$abc\"";

        ?>
    </div>

</body>
</html>