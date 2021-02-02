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
            $first_note = isset( $_GET['note1'] ) ? number_format($_GET['note1'], 1) : 0.0;
            $second_note = isset( $_GET['note2'] ) ? number_format($_GET['note2'], 1) : 0.0;
            $sum = number_format( ( ($first_note + $second_note) / 2 ), 1);
            $situation = "<span class=\"foco\">REPROVADO</span>";

            echo "A média entre <span class=\"foco\">$first_note</span> and <span class=\"foco\">$second_note</span> é igual a <span class=\"foco\">". $sum. '</span> <br/>';

            if ($sum <= 5) {
                $situation = "<span class=\"foco\">REPROVADO</span>";
            }
            elseif ($sum <= 7) {
                $situation = "<span class=\"foco\">RECUPERAÇÃO</span>";
            }
            else {
                $situation = "<span class=\"foco\">APROVADO</span>";
            }

            echo "Situação do aluno: $situation <br/> <a class=\"button\" href=\"./index.html\">Voltar</a>";
        ?>
    </div>

</body>
</html>