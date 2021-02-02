<!doctype html>
<html lang='en'>
<head>
    <meta charset='utf-8'/>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'/>

    <link rel='stylesheet' href='../../model/style.css'/>

    <title>Document</title>
</head>
<body>
    <div id='contains'>
        <?php
            $number = isset( $_GET['number'] ) ? $_GET['number'] : 1;
            echo "Analisando o numero $number... <br/><br/>";
            $repeat_number = 0;
            $repeat_string = "";
            
            if ($number > 0) {

                for ($x = $number; $x >= 1; --$x) {
    
                    if (($number % $x) == 0) {
                        ++$repeat_number;
                        $repeat_string = "$x $repeat_string";
                    }
                }
                $result=($repeat_number == 2) ? 'É PRIMO!' : 'NÃO É PRIMO!';
            }
            else {
                        for ($x = $number; $x <= -1; ++$x) {
            
                            if (($number % $x) == 0) {
                                ++$repeat_number;
                                $repeat_string = "$x $repeat_string";
                            }
                        }
                        $result=($repeat_number == 2) ? 'É PRIMO!' : 'NÃO É PRIMO!';

            }

            echo "valores múltiplos: $repeat_string <br/>";
            echo "Total de múltiplos: $repeat_number <br/>";
            echo "Resultado: $number <span class='foco'>$result</span> <br/>";
        ?>

        <a href='./index.html' class='button'>Come back</a>
    </div>
</body>
</html>