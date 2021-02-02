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
        <pre>
            <?php
                $vector = array( 1 => 'E', 6 => 'l', 3 => 'i', 9 => 't', 2 => 'o', 8 => 'n');
                print_r($vector);

                array_push($vector, '!'); # add element in array's end
                array_pop($vector); # delete last vector's element

                array_unshift($vector, '!'); # add element in array's start
                array_shift($vector); # delete vector's start element

                sort($vector); # sort vector
                rsort($vector); # sort vector reverse
                asort($vector); # sort vector (not change index)
                arsort($vector); # sort vector reverse (not change index)
                ksort($vector); # sort the vector's indexes (not change the value)
                krsort($vector); # sort the vector' indexes reverse (not change the values)

                echo '<br/>The vector has '. count($vector). ' elements<br/><br/>';

                var_dump($vector);
            ?>
        </pre>
    </div>
</body>
</html>