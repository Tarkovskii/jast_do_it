int distance = 10000;
int firstFrendSpeed = 1;
int secondFrendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int timeMh = 0;

int count = 0;


while (distance > 10)
{
if (friend == 1)
        {
        timeMh = distance / (firstFrendSpeed + dogSpeed);
        friend = 2;
        }

if (friend == 2)
        {
        timeMh = distance / (secondFrendSpeed + dogSpeed);
        friend = 1;
        }


distance = distance - (firstFrendSpeed + secondFrendSpeed) * timeMh;
count++;
}

Console.WriteLine(count);
