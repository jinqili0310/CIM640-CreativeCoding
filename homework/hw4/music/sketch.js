var b1, b2, b3, b4, b5, b6, b7, b8, b9;

var sq1, sq2, sq3, sq4, sq5, sq6, sq7, sq8, sq9;

var m1, m2, m3, m4, m5, m6, m7, m8, m9;

var bp1 = false;
var bp2 = false;
var bp3 = false;
var bp4 = false;
var bp5 = false;
var bp6 = false;
var bp7 = false;
var bp8 = false;
var bp9 = false;

function preload() {
  b1 = loadSound('assets/1.mp3');
  b2 = loadSound('assets/2.mp3');
  b3 = loadSound('assets/3.mp3');
  b4 = loadSound('assets/4.mp3');
  b5 = loadSound('assets/5.mp3');
  b6 = loadSound('assets/6.mp3');
  b7 = loadSound('assets/7.mp3');
  b8 = loadSound('assets/8.mp3');
  b9 = loadSound('assets/9.mp3');
}

function setup() {
  // put setup code here
  createCanvas(900, 900);

  sq1 = createSprite(150,150, 300,300);
  sq2 = createSprite(450,150, 300,300);
  sq3 = createSprite(750,150, 300,300);
  sq4 = createSprite(150,450, 300,300);
  sq5 = createSprite(450,450, 300,300);
  sq6 = createSprite(750,450, 300,300);
  sq7 = createSprite(150,750, 300,300);
  sq8 = createSprite(450,750, 300,300);
  sq9 = createSprite(750,750, 300,300);
}

function draw() {
  // put drawing code here
  background(0);

  drawSprites();

  b1.setVolume(1/15);
  b2.setVolume(1/15);
  b3.setVolume(1/15);
  b4.setVolume(1/15);
  b5.setVolume(1/15);
  b6.setVolume(1/15);
  b7.setVolume(1/15);
  b8.setVolume(1/15);
  b9.setVolume(1/15);

  if(bp1 == true){
    b1.play();
  }else{
    b1.stop();
  }
  if(bp2 == true){
    b2.play();
  }else{
    b2.stop();
  }
  if(bp3 == true){
    b3.play();
  }else{
    b3.stop();
  }
  if(bp4 == true){
    b4.play();
  }else{
    b4.stop();
  }
  if(bp5 == true){
    b5.play();
  }else{
    b5.stop();
  }
  if(bp6 == true){
    b6.play();
  }else{
    b6.stop();
  }
  if(bp7 == true){
    b7.play();
  }else{
    b7.stop();
  }
  if(bp8 == true){
    b8.play();
  }else{
    b8.stop();
  }
  if(bp9 == true){
    b9.play();
  }else{
    b9.stop();
  }

}

function mousePressed() {
  if(mouseX>0 && mouseX<300 && mouseY>0 && mouseY<300){
    bp1 = true;
  }else{
    bp1 = false;
  }
  if(mouseX>300 && mouseX<600 && mouseY>0 && mouseY<300){
    bp2 = true;
  }else{
    bp2 = false;
  }
  if(mouseX>600 && mouseX<900 && mouseY>0 && mouseY<300){
    bp3 = true;
  }else{
    bp3 = false;
  }
  if(mouseX>0 && mouseX<300 && mouseY>300 && mouseY<600){
    bp4 = true;
  }else{
    bp4 = false;
  }
  if(mouseX>300 && mouseX<600 && mouseY>300 && mouseY<600){
    bp5 = true;
  }else{
    bp5 = false;
  }
  if(mouseX>600 && mouseX<900 && mouseY>300 && mouseY<600){
    bp6 = true;
  }else{
    bp6 = false;
  }
  if(mouseX>0 && mouseX<300 && mouseY>600 && mouseY<900){
    bp7 = true;
  }else{
    bp7 = false;
  }
  if(mouseX>300 && mouseX<600 && mouseY>600 && mouseY<900){
    bp8 = true;
  }else{
    bp8 = false;
  }
  if(mouseX>600 && mouseX<900 && mouseY>600 && mouseY<900){
    bp9 = true;
  }else{
    bp9 = false;
  }
}
