var handPosX = 200;
var handPosY = 180;
var charColor = "white";
var num1 = 5;
var color1 = 'orange';
var color2 = 'green';
var color3 = '#ffde00';
var radius1 = 60;
var radius2 = 20;
var color4 = '#4f6cbf';

function setup() {
  // put setup code here
  createCanvas(800,600);
  background(color1);

}

function draw() {
  // put drawing code here
  background(color2);
  handPosX = mouseX;
  handPosY = mouseY;
  stroke(charColor);
  noFill();
  //left hand
  strokeCap(ROUND);
  strokeWeight(num1);
  line(handPosX,handPosY,handPosX-40,handPosY-30);
  //right hand
  line(handPosX+60,handPosY,handPosX+100,handPosY-30);
  //head
  ellipse(handPosX+30,handPosY-50,radius1,radius1);
  //body
  strokeJoin(ROUND);
  beginShape();
  vertex(handPosX+15,handPosY-20);
  vertex(handPosX-15,handPosY+40);
  vertex(handPosX+75,handPosY+40);
  vertex(handPosX+45,handPosY-20);
  endShape();
  //left leg
  line(handPosX+15,handPosY+40,handPosX-5,handPosY+90);
  //right leg
  line(handPosX+45,handPosY+40,handPosX+65,handPosY+90);
  //translate
  translate(mouseX,mouseY);
  //ball
  stroke(color4);
  fill(143);
  ellipse(handPosX-20,handPosY-200,radius2,radius2);
}

function mousePressed() {
  charColor = color3;
}
