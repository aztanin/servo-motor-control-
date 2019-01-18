<?php
		$host="localhost";
		$user="root";
		$password="";
		$database="survo";
		$con = new mysqli($host, $user, $password,$database);
		
		if(!$con)
		{
			die("Not Connected");
		}
		
	if(isset($_GET['val']))
	{
		
		$id=1;
		$deg=$_GET['val'];
		$con->query("UPDATE degnum SET num='$deg' WHERE id='$id'");
		
		echo $deg;
		
		
	}
	else
	{
		echo "I am not message";
	}
?>