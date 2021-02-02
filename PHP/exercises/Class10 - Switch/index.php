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
            $state = $_GET['state'];
            $result = '';

            switch ($state) {
                case 'Acre':
                case 'Amapá':
                case 'Amazonas':
                case 'Pará':
                case 'Rondônia':
                case 'Roraima':
                case 'Tocantins':
                    $result = 'Região Norte';
                    break;
                case 'Alagoas':
                case 'Bahia':
                case 'Ceará':
                case 'Maranhão':
                case 'Paraíba':
                case 'Pernambuco':
                case 'Piauí':
                case 'Rio Grande do Norte':
                case 'Sergipe':
                    $result = 'Região Nordeste';
                    break;
                case 'Distrito Federal':
                case 'Goiás':
                case 'Mato Grosso':
                case 'Mato Grosso do Sul':
                    $result = 'Região Centro-Oeste';
                    break;
                case 'Espírito Santo':
                case 'Minas Gerais':
                case 'Rio de Janeiro':
                case 'São Paulo':
                    $result = 'Região Sudeste';
                    break;
                case 'Paraná':
                case 'Santa Catarina':
                    $result = 'Região Sul';
                    break;
            }

            echo "Você mora na <span class=\"foco\">$result</span>";
        ?>
    </div>
</body>
</html>