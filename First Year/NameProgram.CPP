#include <graphics.h>
#include <stdio.h>
#include <conio.h>
void main()
{
int gd=DETECT,gm;
initgraph(&gd,&gm,"C:\\TC\\BGI");

//LETTER S (FIRST ROW)
line(10,10,40,10);
line(10,10,10,30);
line(10,30,40,30);
line(40,30,40,50);
line(10,50,40,50);

//LETTER A (FIRST ROW)
line(50,50,50,10);
line(80,10,80,50);
line(80,30,50,30);
line(80,10,50,10);

//LETTER B (FIRST ROW)
line(90,10,90,50);
line(90,10,110,10);
line(110,10,110,30);
line(90,30,120,30);
line(120,30,120,50);
line(90,50,120,50);

//LETTER R (FIRST ROW)
line(130,10,130,50);
line(130,10,160,10);
line(160,10,160,30);
line(130,30,160,30);
line(140,30,160,50);

//LETTER I (FIRST ROW)
line(170,10,200,10);
line(185,10,185,50);
line(170,50,200,50);

//LETTER E (FIRST ROW)
line(210,10,210,50);
line(210,10,240,10);
line(210,30,240,30);
line(210,50,240,50);

//LETTER L (FIRST ROW)
line(250,10,250,50);
line(250,50,280,50);


//LETTER A (SECOND ROW)
line(10,60,10,100);
line(40,100,40,60);
line(10,80,40,80);
line(10,60,40,60);

//LETTER D (SECOND ROW)
line(50,60,50,100);
line(50,60,70,60);
line(50,100,70,100);
line(80,90,80,70);
line(70,60,80,70);
line(70,100,80,90);

//LETTER R (SECOND ROW)
line(90,60,90,100);
line(90,60,120,60);
line(120,60,120,80);
line(90,80,120,80);
line(100,80,120,100);

//LETTER I (SECOND ROW)
line(130,60,160,60);
line(145,60,145,100);
line(130,100,160,100);

//LETTER E (SECOND ROW)
line(170,60,170,100);
line(170,60,200,60);
line(170,80,200,80);
line(170,100,200,100);

//LETTER L (SECOND ROW)
line(210,60,210,100);
line(210,100,240,100);


//LETTER S (THIRD ROW)
line(10,110,40,110);
line(10,110,10,130);
line(10,130,40,130);
line(40,130,40,150);
line(10,150,40,150);

//LETTER A (THIRD ROW)
line(50,150,50,110);
line(80,110,80,150);
line(80,130,50,130);
line(80,110,50,110);

//LETTER N (THIRD ROW)
line(90,110,90,150);
line(90,110,120,150);
line(120,110,120,150);


//LETTER A (THIRD ROW)
line(170,150,170,110);
line(200,110,200,150);
line(170,130,200,130);
line(170,110,200,110);

//LETTER G (THIRD ROW)
line(240,110,210,110);
line(210,110,210,150);
line(240,150,210,150);
line(240,130,240,150);
line(225,130,240,130);

//LETTER U (THIRD ROW)
line(250,110,250,150);
line(280,110,280,150);
line(250,150,280,150);

//LETTER S (THIRD ROW)
line(290,110,320,110);
line(290,110,290,130);
line(290,130,320,130);
line(320,130,320,150);
line(290,150,320,150);

//LETTER T (THIRD ROW)
line(330,110,360,110);
line(345,110,345,150);

//LETTER I (THIRD ROW)
line(370,110,400,110);
line(385,110,385,150);
line(370,150,400,150);

//LETTER N (THIRD ROW)
line(410,110,410,150);
line(410,110,440,150);
line(440,110,440,150);


getch();
closegraph();
}