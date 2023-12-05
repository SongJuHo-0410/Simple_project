var num = 0;
var op = '';
var dot = false;

function numberBtnHandler(number)
{
	setText(getText() + number);
}

function setText(text)
{
	if(getText() == '0' && text != '0.' && text != ""){
		alert("it already has zero");
	}else{
		document.getElementById("textBox").value = text;	
	}
}

function getText()
{
	return document.getElementById("textBox").value;
}

function reset()
{
	op = '';
	num = 0;
	dot = false;
	setText("");
	document.getElementById("textBox").placeholder = num;
}


function operator(oper) 
{
	dot = false;
	if(getText() =='' || getText() =='0.' || getText()=='-')
	{
		alert("input value error");
	}else{
		if(op == ''){
			num = parseFloat(getText());
		}else if(op == '+'){
			num += parseFloat(getText());
		}else if(op == '-'){
			num -= parseFloat(getText());
		}else if(op == '*'){
			num *= parseFloat(getText());
		}else if(op == '/' && parseFloat(getText()) != 0){
			num /= parseFloat(getText());
		}else{
			alert("Can't be div by 0");
		}
	}
	op = oper;
	setText("");
	document.getElementById("textBox").placeholder = num;
}
 
function decimal()
{
	if(dot == true){
		alert("Can't be twice");
	}else{
		if(getText() == ''){
			setText("0");
		}
		setText(getText() + ".");
		dot = true;
	}
}


function minus(){
	if(getText() == ''){
		setText('-');
	}else{
		operator('-');
	}

}

function equals(){
	operator("");
	setText(num); 
	dot = false;
	num = 0;
}