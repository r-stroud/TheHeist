using System.Security.Cryptography.X509Certificates;

namespace TheHeist;

//the job of this class is to handle collecting info and creating new team members

public class TeamMemberBuilder
{
    public void Run()
    {
        //Part 1



        List<TeamMember> team = new List<TeamMember>() { };
        string title = "\r\n$$$$$$$$\\ $$\\   $$\\ $$$$$$$$\\       $$\\   $$\\ $$$$$$$$\\ $$$$$$\\  $$$$$$\\ $$$$$$$$\\ \r\n\\__$$  __|$$ |  $$ |$$  _____|      $$ |  $$ |$$  _____|\\_$$  _|$$  __$$\\\\__$$  __|\r\n   $$ |   $$ |  $$ |$$ |            $$ |  $$ |$$ |        $$ |  $$ /  \\__|  $$ |   \r\n   $$ |   $$$$$$$$ |$$$$$\\          $$$$$$$$ |$$$$$\\      $$ |  \\$$$$$$\\    $$ |   \r\n   $$ |   $$  __$$ |$$  __|         $$  __$$ |$$  __|     $$ |   \\____$$\\   $$ |   \r\n   $$ |   $$ |  $$ |$$ |            $$ |  $$ |$$ |        $$ |  $$\\   $$ |  $$ |   \r\n   $$ |   $$ |  $$ |$$$$$$$$\\       $$ |  $$ |$$$$$$$$\\ $$$$$$\\ \\$$$$$$  |  $$ |   \r\n   \\__|   \\__|  \\__|\\________|      \\__|  \\__|\\________|\\______| \\______/   \\__|   \r\n                                                                                   \r\n                                                                                   \r\n                                                                                   \r\n";
        
        for (int i = 0; i < 3; i++)
        {
            Console.CursorVisible = false;
Console.Clear();
            Thread.Sleep(400);

            Console.WriteLine(title);
            Thread.Sleep(400);
            
        }
        Console.CursorVisible=true;
        

        Console.ReadKey(true);

        string step1 = "Step 1: Plan your Heist!";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;

        for (int i = 0; i < step1.Length; i++)
        {
            Console.Write(step1[i]);
            Thread.Sleep(30);
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;

        string bankEntry = "Please enter the target bank's difficulty level: ";
        for (int i = 0; i < bankEntry.Length; i++)
        {
            Console.Write(bankEntry[i]);
            Thread.Sleep(30);
        }

        string bankLevel = Console.ReadLine();
        int bankLevelAsInt;
        while(! int.TryParse(bankLevel, out bankLevelAsInt))
        {
            Console.Write("Please enter an integer: ");
            bankLevel = Console.ReadLine();
        }
        Console.Clear();

        Console.WriteLine(title);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;

        string targetStatement = $"Target Bank's Difficulty Level: {bankLevelAsInt}";

        for (int i = 0; i < targetStatement.Length; i++)
        {
            Console.Write(targetStatement[i]);
            Thread.Sleep(30);
        }

        Console.WriteLine() ;
        Console.WriteLine();

        string luckStatement = "Luck: 10";

        for (int i = 0; i< luckStatement.Length; i++)
        {
            Console.Write(luckStatement[i]);
            Thread.Sleep(30);
        }

        Console.WriteLine();
        Console.WriteLine();

        string teamSkillStatement = "Current Team's Skill Level: 0";
        
        for (int i = 0; i< teamSkillStatement.Length; i++)
        {
            Console.Write(teamSkillStatement[i]);
            Thread.Sleep(30);
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        int counter = 0;

Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            string step2 = "Step 2: Create your team!";
            for (int i = 0; i < step2.Length; i++)
            {
                Console.Write(step2[i]);
                Thread.Sleep(30);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

        Console.WriteLine();

        Console.Clear();
        
        int teamSkill = 0;

        while (true)
        {

            Console.WriteLine(title);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Target Bank's Difficulty Level: {bankLevelAsInt} ");
            Console.WriteLine();
            Console.WriteLine("Luck: 10");
            Console.WriteLine();
            Console.WriteLine($"Current Team's Skill Level: {teamSkill}");

            Console.WriteLine();
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(step2);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            counter++;

            TeamMember teamMember = new TeamMember();
            Console.WriteLine(@$"
=========================
Team Member {counter}
=========================");
            Console.Write("Enter name: ");

            teamMember.Name = Console.ReadLine();

            if (teamMember.Name == "")
            {
                Console.Clear();
                break;

            }


            Console.Write("Enter skill level: ");

            string skillInput = Console.ReadLine();

            int skillAsInt;

            while (!int.TryParse(skillInput, out skillAsInt) || skillAsInt <= 0)
            {
                Console.Write("Skill must be a positive integer: ");
                skillInput = Console.ReadLine();
            }

            teamMember.SkillLevel = skillAsInt;

            teamSkill += skillAsInt;

            Console.Write("Enter courage factor: ");

            string courageInput = Console.ReadLine();

            decimal courageAsDec;

            while (!decimal.TryParse(courageInput, out courageAsDec) || courageAsDec < 0m || courageAsDec > 2m)
            {
                Console.Write("Courage must be between 0.0 and 2.0: ");
                courageInput = Console.ReadLine();
            }

            teamMember.CourageFactor = courageAsDec;


            team.Add(teamMember);
            Console.Clear();
        }

        Console.WriteLine(title);

        string teamOf0 = "You do not have anyone on your team. Start Recruiting!";
        string teamOf1 = $"You only have {team.Count} member on your team. You might want to add more team members before starting a job.";
        string teamOfMany = $"You have {team.Count} members on your team. Good luck!";

        if (team.Count < 1)
        {
            for (int i = 0; i < teamOf0.Length; i++)
            {
                Console.Write(teamOf0[i]);
                Thread.Sleep(30);
            }
        }
        else if (team.Count == 1)
        {
            for (int i = 0; i < teamOf1.Length; i++)
            {
                Console.Write(teamOf1[i]);
                Thread.Sleep(30);
            }
        }
        else if (team.Count > 1)
        {
            for (int i = 0; i < teamOfMany.Length; i++)
            {
                Console.Write(teamOfMany[i]);
                Thread.Sleep(30);
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the number of trial runs you would like to perform: ");
        string numOfTrials = Console.ReadLine();
        int numOfTrialsAsInt;
        while (!int.TryParse(numOfTrials, out numOfTrialsAsInt) || numOfTrialsAsInt <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            numOfTrials = Console.ReadLine();
        }
        Console.Clear();

        string loading ="";

        for (int i = 0; i < 101; i++)

        {
            Console.Clear();
            loading = $"{i}%";
            Console.WriteLine($"LOADING RESULTS: {loading}");
            Thread.Sleep(10);
        } 
        
        int groupSkill = 0;

        for (int i = 0; i < team.Count; i++)
        {

            groupSkill += team[i].SkillLevel;
        }

        int successCounter = 0;
        int failureCounter = 0;

        for (int i = 0; i < numOfTrialsAsInt; i++)
        {
            int bankSkill = bankLevelAsInt;
            Random randomNum = new Random();
            int luckValue = randomNum.Next(-10, 10);
            bankSkill += luckValue;

            Console.Write(@$"
====================================
TRIAL NO. {i+1}
Team Skill Level: {groupSkill}
Bank Skill Level: {bankSkill}
");
            if (groupSkill >= bankSkill)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(@"
The heist was a success!");
                successCounter++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(@"
The heist has failed! Flee the scene!");
                failureCounter++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(200);
        }

        Console.WriteLine();
        Console.WriteLine("====================================");
        Console.WriteLine("RESULTS");
        Console.WriteLine();
        if(successCounter == 1)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@$"
The heist succeeded {successCounter} time.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@$"
The heist succeeded {successCounter} times.");
        }

        Console.WriteLine();

        if (failureCounter == 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@$"
The heist failed {failureCounter} time.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@$"
The heist failed {failureCounter} times.");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("====================================");
    }

}





