int object1 = 1;
int object2 = 8;
int object3 = 6;
int object4 = 2;
int object5 = 3;

int max = object1;

if (max < object1) max = object1;
if (max < object2) max = object2;
if (max < object3) max = object3;
if (max < object4) max = object4;
if (max < object5) max = object5;

Console.Write("max = ");
Console.WriteLine(max);
