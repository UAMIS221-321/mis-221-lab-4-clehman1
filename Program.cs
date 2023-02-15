// start
int userChoice = GetUserChoice(); //Priming read
//RouteEm(userChoice);
// Pre Test Loop 
while(userChoice != 3) { //condition check
RouteEm(userChoice);
userChoice = GetUserChoice(); //Update read
}
// post test loop
// do {
// RouteEm(userChoice);
// userChoice = GetUserChoice(); //Update read
// } while (userChoice != 3);
// end main

static int GetUserChoice()
{
 DisplayMenu();
 int userChoice = int.Parse(Console.ReadLine());
 if(IsValidChoice(userChoice)) {
     return userChoice;
}
     else return 0;
}

static void DisplayMenu() {
     System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangler\nEnter 3 to exit");
}

static bool IsValidChoice(int userInput) {
     if(userInput == 1 || userInput == 2 || userInput == 3) {
         return true;
     }
  else return false;
}

static void GetFull() {
    Random rand = new Random();
    int number = rand.Next(3,10);
    for(int i = 0; i < number; i++) {
        for(int j = 0; j < i; j++){
             System.Console.Write("0");
        }
        System.Console.WriteLine("");
     }
//  System.Console.WriteLine();
}

static void GetPartial() {
    Random rand = new Random();
    int number = rand.Next(3,10);
    int num2 = rand.Next(1,3);
    for(int i = 0; i < number; i++) {
        for(int j = 0; j < i; j++){
            num2 = rand.Next(1,3);
            if(num2 == 1){
                System.Console.Write("0");}
            else if(num2 == 2){
                System.Console.Write(" ");
            }    
        }
        System.Console.WriteLine("");
    }
}

static void SayInvalid(){
   System.Console.WriteLine("Try Again");
}


static void RouteEm(int menuChoice) 
{
     if(menuChoice == 1) {
        GetFull();
     }
     else if(menuChoice == 2) {
        GetPartial();
     }
     else if(menuChoice != 3){
        SayInvalid();
     }
}
// static void PauseAction()
// {
// System.Console.WriteLine("Press any key to continue...");
// Console.ReadKey();
// }

static void Random() {
    Random rand = new Random(0);
    int number = rand.Next(2);
    number = 3 + number;

for(int i = 0; i <= 1; i++) {
     Random Ran = new Random();
     int numb = rand.Next();
     numb = 1 + numb;
     if (numb ==1) {
         System.Console.WriteLine();
         }
     else if (numb == 2) {
         System.Console.WriteLine();
     }
 }
 System.Console.WriteLine();
}