using Helpers;
using Services;

var animalService = new AnimalsService();
bool isProgramRunning = true;

while (isProgramRunning)
{
    BetterConsole.WriteLine("I know about every animal on planet Earth. If an item does not appear in our records, it does not exist.");
    BetterConsole.WriteLine("Tell me which animal you would like to know more about:...");

    string userResponse_animal = BetterConsole.ReadLine();

    string animalInfo = animalService.GetInfo(userResponse_animal);

    BetterConsole.WriteLine(animalInfo);

    isProgramRunning = !BetterConsole.ReadBool("Exit program?");
}