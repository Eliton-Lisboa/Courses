<!doctype html>
<html lang='en'>
<head>
    <meta charset='utf-8'/>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'/>

    <link rel='stylesheet' href='../../../model/style.css'/>

    <title>Document</title>
</head>
<body>
    
    <div id='contains'>
        <?php
            $year = isset( $_GET['year'] ) ? $_GET['year'] : '1900' ;
            $age = date('Y') - $year;
            echo "You were born in $year and is $age years old <br/>";

            if ($age < 16) {
                $votetype = 'cannot vote';
            }
            elseif ( ($age >= 16 and $age < 18) or ($age > 65) ) {
                $votetype = 'optional vote';
            }
            else {
                $votetype = 'compulsory vote';
            }

            echo "For that age, $votetype";
        ?>
    </div>

</body>
</html>