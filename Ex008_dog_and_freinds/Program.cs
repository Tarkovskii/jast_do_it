Console.Clear();
int distance = 10015;
int firstFrendSpeed = 9;
int secondFrendSpeed = 8;
int dogSpeed = 11;
int friend;
int timeMh = 0;
string toFriend;

int count = 0;

Console.WriteLine("К какому другу побежит собака, к Первому или Второму?");
toFriend = Console.ReadLine();

        if (toFriend.ToLower() == "первому")
                {
                        friend = 1;      
                }
        else 
                {
                        friend = 2;
                }



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


Console.WriteLine("Собака пробежит в количестве " + count + " раз!");
