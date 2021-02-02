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
            $type = $_GET['op'];
            echo "The values ​​passed were $number1 and $number2 <br/>";
            $result = ($type == 's') ? $number1 + $number2 : $number1 * $number2;
            echo "The result is $result";

            // identic
            echo '<br/><br/>';
            
            $number1 = 303;
            $number2 = '303';
            
            $result = ($number1 === $number2) ? 'Yes' : 'No';
            echo "The variables \"number1\" and \"number2\" is equals? $result";
            
            // average
            echo '<br/><br/>';
            
            $value1 = $_GET['a'];
            $value2 = $_GET['b'];
            
            $average = ($value1 + $value2) / 2;
            echo "The average between $value1 and $value2 is $average <br/>";
            echo "The student's situation is ". ( ($average < 6) ? 'disapproved' : 'okay' );
            
            // logical operators
            echo '<br/><br/>';
             
            $year = $_GET['a'];
            $age = date('Y') - $year;
            echo "Who was born in the year $year is $age years old";
            $type = ($age >= 18 and $age < 65) ? 'is required' : 'not is obligatory';
            echo " and that way your vote $type";

        ?>
    </div>
</body>
</html>