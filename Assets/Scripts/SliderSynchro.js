#pragma strict

var myColor : Color;
var myString : String;
private var slideVal : float; 
private var textVal : String;
  
function Start() {
    slideVal = myColor.r;
    textVal = myColor.r.ToString();
}
 
function OnGUI() {
    var f : float;
 
    f = GUI.HorizontalSlider (Rect (225, 25, 200, 30), slideVal, 0, 1);
     
    if (f != slideVal) {
        slideVal = f;
        myColor.r = f;
        textVal = f.ToString();
    }
      
    myString = GUI.TextField (Rect (155, 25, 100, 30), textVal);
    if (textVal != myString) {
        textVal = myString;
         
        if (float.TryParse(myString, f)) {
            textVal = myString;
            myColor.r = Mathf.Clamp01(f);
            slideVal = myColor.r;
        }
    }
}