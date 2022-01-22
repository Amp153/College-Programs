<?php
//Change class
class Change{
	private $AmountOwed;
	private $AmountPaid;
	private $Denominations = array(
		array("name" => "\$50 Bill", "value" => 50),
		array("name" => "\$20 Bill", "value" => 20),
		array("name" => "\$10 Bill", "value" => 10),
		array("name" => "\$5 Bill", "value" => 5),
		array("name" => "\$1 Bill", "value" => 1),
		array("name" => "Quarter", "value" => .25),
		array("name" => "Dime", "value" => .1),
		array("name" => "Nickel", "value" => .05),
		array("name" => "Penny", "name_plural" => "Pennies",
			"value" => .01));
	private $DemCount;
	
	//constructor
	function __construct() {
		$this->DemCount = count($this->Denominations);
	}
	
	//Accessor - gets
	public function GetAmountOwed() {
		return $this->AmountOwed;
	}
	
	public function GetAmountPaid() {
		return $this->AmountPaid;
	}
	
	//Mutator - sets
	public function SetAmountOwed($Owed) {
		$this->AmountOwed = round($Owed,2);
	}
	
	public function SetAmountPaid($Paid) {
		$this->AmountPaid = round($Paid,2);
	}
	
	public function ShowChange(){
		$ChangeDue = $this->AmountPaid - $this->AmountOwed;
		echo "<p>";
		echo "The price of the transaction was \$".
			trim(sprintf("%54.2f",$this->AmountOwed)."<br />");
		echo "The amount paid was \$".
			trim(sprintf("%54.2f",$this->AmountPaid)."<br />");
		echo "The change due \$".
			trim(sprintf("%54.2f",$ChangeDue)."<br />");
		echo "</p>";
		
		
		if($ChangeDue < 0){
			$ChangeDue *= -1;
			echo "The customer still owes \$$ChangeDue";
		}
		else{
			if($ChangeDue == 0)
				echo "The customer paid the exact amount";
			//To be Continued
			else{
				echo "Return the following denominations as change: <br 
				/>";
				$RemDue = $ChangeDue;
				//echo $RemDue;
				//echo $this->DemCount;
				for($i = 0; $i < $this->DemCount; $i++){
					$CurrCount = 
					floor($RemDue/$this->Denominations[$i]["value"]);
					//echo $CurrCount;
					
					if($CurrCount > 0){
						$RemDue -= 
						($CurrCount * $this->Denominations[$i]["value"]);
						$RemDue = round($RemDue, 2);
						if($CurrCount == 1)
							echo "&nbsp; 1 ". $this->Denominations[$i][
							"name"]. "<br />";
						else if (isset($this->Denominations[$i][
						"name_plural"]))
							echo "&nbsp; $CurrCount ". $this->Denominations[$i][
							"name_plural"]. "<br />";
						else
							echo "&nbsp; $CurrCount". $this->Denominations[$i][
							"name"]. "s<br />";
					}
				}
				//echo $ChangeDue;
			}
		}
	}
}
?>