var x3 = 0;
var speed3 = 8;

var x2 = -30;
var y2 = -25;
var speed2 = 0.2;

function preload() {
  p1 = loadImage('assests/planet1.png');
  p2 = loadImage('assests/planet2.png');
  p3 = loadImage('assests/planet3.png');

}

function setup() {
  // put setup code here
  createCanvas(windowWidth, windowHeight);

}

function setGradient(x, y, w, h, c1, c2, axis) {
  noFill();
  if (axis == "Y") {  // Top to bottom gradient
    for (let i = y; i <= y+h; i++) {
      var inter = map(i, y, y+h, 0, 1);
      var c = lerpColor(c1, c2, inter);
      stroke(c);
      line(x, i, x+w, i);
    }
  }
  else if (axis == "X") {  // Left to right gradient
    for (let j = x; j <= x+w; j++) {
      var inter2 = map(j, x, x+w, 0, 1);
      var d = lerpColor(c1, c2, inter2);
      stroke(d);
      line(j, y, j, y+h);
    }
  }
}

function star(x, y, radius1, radius2, npoints) {
  var angle = TWO_PI / npoints;
  var halfAngle = angle/2.0;
  beginShape();
  for (var a = 0; a < TWO_PI; a += angle) {
    var sx = x + cos(a) * radius2;
    var sy = y + sin(a) * radius2;
    vertex(sx, sy);
    sx = x + cos(a+halfAngle) * radius1;
    sy = y + sin(a+halfAngle) * radius1;
    vertex(sx, sy);
  }
  endShape(CLOSE);
}

function draw() {
  // put drawing code here
  background(255);
  var color1 = color('#362f41');
  var color2 = color('#eeacae');

  if(mouseY <= windowHeight/2){
    setGradient(0, 0, windowWidth, windowHeight, color1, color2, "Y");
  }else if(mouseY > windowHeight/2){
    setGradient(0, 0, windowWidth, windowHeight, color2, color1, "Y")
  }

  //fill(255,80);
  //noStroke();

  push();
  translate(windowWidth*0.2, windowHeight*0.5);
  rotate(frameCount / 80.0);
  star(0, 0, 10, 20, 5);
  pop();

  push();
  translate(windowWidth*0.4, windowHeight*0.5);
  rotate(frameCount / -80.0);
  star(0, 0, 10, 20, 5);
  pop();

  push();
  translate(windowWidth*0.6, windowHeight*0.5);
  rotate(frameCount / 80.0);
  star(0, 0, 10, 20, 5);
  pop();

  push();
  translate(windowWidth*0.8, windowHeight*0.5);
  rotate(frameCount / -80.0);
  star(0, 0, 10, 20, 5);
  pop();

  tint(255, 120);

//p3 move from left to right
  image(p3, x3, windowHeight*0.75, p3.width/2, p3.height/2);

  if(x3 > windowWidth-p3.width/2 || x3 < 0){
    speed3 = speed3 * -1;
  }
  x3 = x3 + speed3;

//p1 rotate
  push();
  translate(windowWidth*0.85, windowHeight*0.2);
  rotate(frameCount / 120.0);
  imageMode(CENTER);
  image(p1, 0, 0, p1.width/2, p1.height/2);
  pop();

//p2 move drop down
  image(p2, x2, y2, p2.width/2, p2.height/2);

    x2 = x2 + speed2;
    y2 = y2 + speed2;
  //console.log(x2.value);

  //words mousepressed


}
