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
            $start = isset( $_GET['start'] ) ? $_GET['start'] : 0;
            $end = isset( $_GET['end'] ) ? $_GET['end'] : 10;
            $inclement = isset( $_GET['inclement'] ) ? $_GET['inclement'] : 1;

            if ($start < $end) {
                while ($start <= $end) {
                    echo "$start ";
                    $start += $inclement;
                }
            }
            else {
                while ($start >= $end) {
                    echo "$start ";
                    $start -= $inclement;
                }
                
            }
        ?>
    </div>
</body>
</html>