<!DOCTYPE html>
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
            $number = isset( $_GET['number'] ) ? $_GET['number'] : 0;
            $operation = isset( $_GET['opr'] ) ? $_GET['opr'] : 1;

            switch ($operation) {
                case 1:
                    $result = $number * 2;
                    break;
                case 2:
                    $result = $number ^ 3;
                    break;
                case 3:
                    $result = sqrt($number); 
                    break;
            }

            echo "The result of the operation is <span class=\"foco\">$result</span>". '<br/><br/>';

            $day = isset( $_GET['dow'] ) ? $_GET['dow'] : 0;

            switch($day) {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    echo 'Levanta e vai estudar! :)';
                    break;
                case 7:
                case 8:
                    echo 'Descanse, pequeno gafanhoto! ;)';
                    break;
                default:
                    echo 'Dia da semana invalido ';
            }
        ?>
        <a class='button' href='javascript:history.go(-1)'>Voltar</a>

    </div>
    
</body>
</html>