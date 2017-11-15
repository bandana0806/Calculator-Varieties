
function operand(txt)
{
	calculator.screen.value+=txt;
}
function display()
{
	calculator.screen.value=0;
}
function del(str)
    {
    calculator.screen.value = calculator.screen.value.substring(0, calculator.screen.value.length - 1);	
    }