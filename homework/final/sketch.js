var stars = [];

//var planetColor = ['black', 'white', 'grey', 'blue', 'red', 'yellow', 'green', 'purple', 'orange', 'pink'];
// var	drawFill = true;
var radius = 30;
var type = ['moon', 'mercury', 'mars', 'jupiter', 'venus'];
var location_X = 0;
var location_Y = 0;

var gui, gplanet;

var rmoon = false, rmercury = false, rvenus = false, rmars = false, rjupiter = false;
var dmoon, dsun, dmercury, dvenus, dearth, dmars, djupiter, dsaturn, duranus, dneptune;

var angle = 0;
var planet, jupiter, saturn, sun, moon, mercury, venus, earth, mars, jupiter, uranus, neptune;

var vmoon, pmoon;
var rmoon = false, gmoon = false;

function preload() {
  planet = loadModel('assets/Planet.obj');
  jupiter = loadImage('assets/Jupiter.jpg');
  saturn = loadImage('assets/Saturn.jpg');
  sun = loadImage('assets/Sun.jpg');
  moon = loadImage('assets/Moon.jpg');
  earth = loadImage('assets/Earth.jpg');
  mars = loadImage('assets/Mars.jpg');
  mercury = loadImage('assets/Mercury.jpg');
  neptune = loadImage('assets/Neptune.jpg');
  uranus = loadImage('assets/Uranus.jpg');
  venus = loadImage('assets/Venus.jpg');
  //vmoon = createVideo('assets/sailor.mp4');
}

function setup() {
  // put setup code here
  var cnv = createCanvas(windowWidth, windowHeight-300, WEBGL);
  cnv.parent('sketch-holder');
  //cnv.position(0, 0);

  for (var i=0; i<1000; i++) {
    stars.push(new Jitter());
  }

  gui = createGui('Choose A Planet', 0, 0);
  gui.addGlobals('type');

  gplanet = createGui('Move The Planet', width - 220, 20);
  sliderRange(1, 100, 1);
  gplanet.addGlobals('planetColor', 'radius');
  sliderRange(-100, 100, 1);
  gplanet.addGlobals('location_X', 'location_Y');

}

function draw() {
  // put drawing code here
  background('#2c2828');
  //background(50);

  for (var i=0; i<stars.length; i++) {
    stars[i].move();
    stars[i].display();
  }
    //camera(0,0,0,0,0,0,0,1,0);

    directionalLight(255, 255, 255, -1000, 1000, -2000);
    //rotateX(angle);

switch(type){
  case 'jupiter':
  djupiter();
  break;

  case 'mercury':
  dmercury();
  break;

  case 'venus':
  dvenus();
  break;

  case 'mars':
  dmars();
  break;

  case 'moon':
  dmoon();
  break;
}

}

function Jitter() {
  this.x = random(-windowWidth, windowWidth);
  this.y = random(-windowHeight, windowHeight);
  this.diameter = random(1, 5);
  this.speed = 1;

  this.move = function() {
    this.x += random(-this.speed, this.speed);
    this.y += random(-this.speed, this.speed);
  };

  this.display = function() {
    noStroke();
    fill(random(0,256), random(0,256), random(0,256));
    ellipse(this.x, this.y, this.diameter, this.diameter);
  };
}

function dmercury(){
  rotateY(angle);
  angle += 0.015;
  var x1 = 5 * location_X + 200;
  var y1 = 5 * location_Y;
  var d = 3 * radius;
  translate(x1, y1, 0);
  sphere(d);
  texture(mercury);
  ambientLight('blue');
  rmercury = true;
}

function dvenus(){
  rotateY(angle);
  angle += 0.015;
  var x2 = 5 * location_X + 200;
  var y2 = 5 * location_Y;
  var d = 3 * radius;
  translate(x2, y2, 0);
  sphere(d);
  texture(venus);
  ambientLight('yellow');
  rvenus = true;
}

function dmars(){
  rotateY(angle);
  angle += 0.015;
  var x3 = 5 * location_X + 200;
  var y3 = 5 * location_Y;
  var d = 3 * radius;
  translate(x3, y3, 0);
  sphere(d, 50, 50);
  texture(mars);
  ambientLight('red');
  rmars = true;
}

function djupiter(){
  rotateY(angle);
  angle += 0.015;
  var x4 = 5 * location_X + 200;
  var y4 = 5 * location_Y;
  var d = 3 * radius;
  translate(x4, y4, 0);
  sphere(d);
  texture(jupiter);
  ambientLight('green');
  rjupiter = true;
}

function dmoon(){
  rotateY(angle);
  angle += 0.015;
  var x5 = 5 * location_X + 200;
  var y5 = 5 * location_Y;
  var d = 3 * radius;
  translate(x5, y5, 0);
  sphere(d);
  texture(moon);
  ambientLight('pink');
  rmoon = true;
}

// function mousePressed(){
//   if(rmoon == true){
//     gmoon = true;
//   }else{
//     gmoon = false;
//   }
// }
//
// function pmoon(){
//   texture(vmoon);
//   plane(windowWidth, windowHeight);
// }
