#include <graphics.h>
#include <conio.h>
void main()
{
int gd=DETECT,gm;
initgraph(& gd,& gm,"C:\\TC\\BGI");
setbkcolor(BLACK);

setfillstyle(SOLID_FILL, LIGHTBLUE);
bar(70,90,80,100);

setfillstyle(SOLID_FILL, 11);
bar(30,40,50,60);
bar(40,50,90,80);
bar(70,40,100,50);
bar(70,60,100,70);
bar(50,80,100,90);
bar(110,80,120,90);
bar(100,90,110,120);
bar(60,100,110,110);
bar(80,110,110,120);
bar(60,100,90,170);
bar(50,140,100,160);

setfillstyle(SOLID_FILL, LIGHTBLUE);
bar(70,130,80,140);
bar(60,140,70,160);
bar(70,150,80,160);

setfillstyle(SOLID_FILL, WHITE);
bar(120,80,130,90);
bar(110,90,120,110);
bar(120,100,130,110);
bar(100,110,110,130);
bar(110,120,120,130);
bar(60,80,70,130);
bar(50,90,60,120);
bar(70,110,80,130);

setfillstyle(SOLID_FILL, WHITE);
bar(200,60,220,80);
bar(210,50,230,110);
bar(190,90,210,110);
bar(200,110,210,120);
bar(230,70,240,110);
bar(240,80,280,120);
bar(270,60,280,80);
bar(280,90,290,130);
bar(290,110,300,130);
bar(290,120,310,140);
bar(230,120,260,130);
bar(220,130,250,150);

setfillstyle(SOLID_FILL,5);
bar(260,90,270,100);

setfillstyle(SOLID_FILL,YELLOW);
bar(240,100,260,110);
bar(250,110,260,120);
bar(240,80,280,90);
bar(280,90,290,100);

setfillstyle(SOLID_FILL, 13);
bar(220,70,230,110);
bar(210,90,240,100);
bar(230,100,240,110);



getch();
closegraph();
}