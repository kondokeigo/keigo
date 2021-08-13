<!DOCTYPE html>
<html lang="ja">
    <head>
        <meta charset="UTF-8">
        <title>m5_1</title>
    </head>
    <body>
        <?php
            echo "ミッション５−１でーす！<br><hr><br>";
            echo "Qみんなに質問<br>";
            echo "明日、急遽休みになりました。<br>";
            echo "みんなは明日何をする？<br><hr><br>";
            $dsn='データベース名';
            $user='ユーザー名';
            $password='パスワード';
            $pdo = new PDO($dsn,$user,$password);
            $sql="CREATE TABLE IF NOT EXISTS soccer5"
            ."("
            ."id INT AUTO_INCREMENT PRIMARY KEY,"
            ."name char(32),"
            ."comment TEXT,"
            ."pp TEXT,"
            ."date TEXT"
            .");";
            $stmt=$pdo->query($sql);
            if(!empty($_POST["edi"])&&!empty($_POST["pe"])){
                $edi=$_POST["edi"];
                $pe=$_POST["pe"];
                $id=$edi;
                $sql='SELECT*FROM soccer5 WHERE id=:id';
                $stmt=$pdo->prepare($sql);
                $stmt->bindParam(':id',$id,PDO::PARAM_INT);
                $stmt->execute();
                $results=$stmt->fetchAll();
                foreach($results as $row){
                    if($row['id']==$edi&&$row['pp']==$pe){
                        $ediname=$row['name'];
                        $edicomment=$row['comment'];
                        $redi=$edi;
                    }
                }
            }
        ?>
        <form action="" method="post">
            入力欄<br>
            <input type="text" name="name" placeholder="名前" value="<?php if(!empty($ediname)){echo $ediname;}?>"><br>
            <input type="text" name="comment" placeholder="コメント" value="<?php if(!empty($edicomment)){echo $edicomment;}?>"><br>
            <input type="password" name="pp" placeholder="パスワード">
            <input type="submit"><br><br><hr>
            削除欄<br>
            <input type="text" name="delete" placeholder="削除したい番号"><br>
            <input type="password" name="pd" placeholder="パスワード">
            <input type="submit" value="削除"><br><br><hr>
            編集欄<br>
            <input type="text" name="edi" placeholder="編集したい番号"><br>
            <input type="password" name="pe" placeholder="パスワード">
            <input type="hidden" name="hid" value="<?php if(!empty($redi)){echo $redi;}?>">
            <input type="submit" value="編集"><br><br><hr>
        </form>
        <?php
            if(!empty($_POST["hid"])){
                if(!empty($_POST["name"])&&!empty($_POST["comment"])){
                    $id=$_POST["hid"];
                    $name=$_POST["name"];
                    $comment=$_POST["comment"];
                    $date=date("Y/m/d H:i:s");
                    $sql='UPDATE soccer5 SET name=:name,comment=:comment,date=:date WHERE id=:id';
                    $stmt=$pdo->prepare($sql);
                    $stmt->bindParam(':name',$name,PDO::PARAM_STR);
                    $stmt->bindParam(':comment',$comment,PDO::PARAM_STR);
                    $stmt->bindParam(':date',$date,PDO::PARAM_STR);
                    $stmt->bindParam(':id',$id,PDO::PARAM_INT);
                    $stmt->execute();
                    $sql='SELECT*FROM soccer5';
                    $stmt=$pdo->query($sql);
                    $results=$stmt->fetchAll();
                    foreach($results as $row){
                        echo $row['id'].':';
                        echo $row['name'].' ';
                        echo $row['comment'].' ';
                        echo $row['date'].'<br>';
                    }
                }
            }elseif(!empty($_POST["delete"])&&!empty($_POST["pd"])){
                $delete=$_POST["delete"];
                $pd=$_POST["pd"];
                $id=$delete;
                $sql='SELECT*FROM soccer5 WHERE id=:id';
                $stmt=$pdo->prepare($sql);
                $stmt->bindParam(':id',$id,PDO::PARAM_INT);
                $stmt->execute();
                $results=$stmt->fetchAll();
                foreach($results as $row){
                    if($row['id']==$delete&&$row['pp']==$pd){
                        $sql='delete from soccer5 where id=:id';
                        $stmt=$pdo->prepare($sql);
                        $stmt->bindParam(':id',$id,PDO::PARAM_INT);
                        $stmt->execute();
                    }
                }
                $sql='SELECT*FROM soccer5';
                $stmt=$pdo->query($sql);
                $results=$stmt->fetchAll();
                foreach($results as $row){
                    echo $row['id'].':';
                    echo $row['name'].' ';
                    echo $row['comment'].' ';
                    echo $row['date'].'<br>';
                }
            }elseif(!empty($_POST["name"])&&!empty($_POST["comment"])&&!empty($_POST["pp"])){
                $sql=$pdo->prepare("INSERT INTO soccer5 (name,comment,pp,date) VALUES(:name,:comment,:pp,:date)");
                $sql->bindParam(':name',$name,PDO::PARAM_STR);
                $sql->bindParam(':comment',$comment,PDO::PARAM_STR);
                $sql->bindParam(':pp',$pp,PDO::PARAM_STR);
                $sql->bindParam(':date',$date,PDO::PARAM_STR);
                $name=$_POST["name"];
                $comment=$_POST["comment"];
                $pp=$_POST["pp"];
                $date=date("Y/m/d H:i:s");
                $sql->execute();
                $sql='SELECT*FROM soccer5';
                $stmt=$pdo->query($sql);
                $results=$stmt->fetchAll();
                foreach($results as $row){
                    echo $row['id'].':';
                    echo $row['name'].' ';
                    echo $row['comment'].' ';
                    echo $row['date'].'<br>';
                }
            }else{
                $sql='SELECT*FROM soccer5';
                $stmt=$pdo->query($sql);
                $results=$stmt->fetchAll();
                foreach($results as $row){
                    echo $row['id'].':';
                    echo $row['name'].' ';
                    echo $row['comment'].' ';
                    echo $row['date'].'<br>';
                }
            }
        ?>
    </body>
</html>
