<?php

//change connection & password to suit yours
$conn=mysql_connect("localhost","root","PASSWORD") or die("mysql_error()");

//change database_name to your database name
$db=mysql_select_db("tera") or die(mysql_error());

?>