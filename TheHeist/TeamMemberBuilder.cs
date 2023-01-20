namespace TheHeist;

//the job of this class is to handle collecting info and creating new team members

public class TeamMemberBuilder
{
    public void Run()
    {
        //Part 1



        List<TeamMember> team = new List<TeamMember>() { };
Console.WriteLine("Plan Your Heist!");
        Console.WriteLine("Please enter the bank's difficulty level.");
        string bankLevel = Console.ReadLine();
        int bankLevelAsInt;
        while(! int.TryParse(bankLevel, out bankLevelAsInt))
        {
            Console.WriteLine("Please enter an integer.");
            bankLevel = Console.ReadLine();
        }
        Console.Clear();

        int counter = 0;

        while (true)
        {
            Console.WriteLine("Make your team!");
            
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



        if (team.Count < 1)
        {
            Console.WriteLine($"You do not have anyone on your team. Start Recruiting!");
        }
        else if (team.Count == 1)
        {
            Console.WriteLine($"You only have {team.Count} member on your team. You might want to add more team members before starting a job.");
        }
        else if (team.Count > 1)
        {
            Console.WriteLine($"You have {team.Count} members on your team. Good luck!");
        }

        Console.WriteLine("Please enter the number of trial runs you would like to perform.");
        string numOfTrials = Console.ReadLine();
        int numOfTrialsAsInt;
        while (!int.TryParse(numOfTrials, out numOfTrialsAsInt) || numOfTrialsAsInt <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            numOfTrials = Console.ReadLine();
        }
        Console.Clear();
        int groupSkill = 0;

        for (int i = 0; i < team.Count; i++)
        {
            //Console.WriteLine(team[i]);
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
                Console.Write(@"
The heist was a success!");
                successCounter++;
            }
            else
            {
                Console.Write(@"
The heist has failed! Flee the scene!");
                failureCounter++;
            }

        }

        if(successCounter == 1)
        {
            Console.Write(@$"
============================================
The heist succeeded {successCounter} time.");
        }
        else
        {
            Console.Write(@$"
============================================
The heist succeeded {successCounter} times.");
        }

        if (failureCounter == 1)
        {
            Console.Write(@$"
The heist failed {failureCounter} time.
============================================");
        }
        else
        {
            Console.Write(@$"
The heist failed {failureCounter} times.
===========================================");
        }

    }

}





