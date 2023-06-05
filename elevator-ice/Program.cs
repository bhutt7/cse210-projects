Elevator normalOne = new Elevator();
Elevator normalTwo = new Elevator();
VipElevator vip = new VipElevator();
Runner run = new Runner(normalOne, normalTwo, vip);

Console.WriteLine("Select an elevator");
Console.WriteLine("1. Elevator One");
Console.WriteLine("2. Elevator Two");
Console.WriteLine("3. VIP Elevator");
Console.Write("")