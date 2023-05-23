namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //input data
            try
            {
                FootballPlayer goalkeeperTeam1 = new Goalkeeper("Georgi", 5, 20, 185);
                FootballPlayer defender1 = new Defender("Stanislav", 20, 20, 170);
                FootballPlayer defender2 = new Defender("Yanislav", 30, 21, 180);
                FootballPlayer defender3 = new Defender("Borislav", 1, 21, 165);
                FootballPlayer defender4 = new Defender("Konstantin", 2, 30, 180);
                FootballPlayer striker1 = new Striker("Dragan", 8, 33, 178);
                FootballPlayer striker2 = new Striker("Donislav", 7, 21, 167);
                FootballPlayer striker3 = new Striker("Suzan", 9, 26, 170);
                FootballPlayer midfield1 = new Midfield("Ivo", 10, 24, 170);
                FootballPlayer midfield2 = new Midfield("Matei", 22, 21, 190);
                FootballPlayer midfield3 = new Midfield("Yanislav", 15, 21, 180);

                //adding players for the first team
                FootballPlayer[] footballPlayers = new FootballPlayer[11];
                footballPlayers[0] = goalkeeperTeam1;
                footballPlayers[1] = defender1;
                footballPlayers[2] = defender2;
                footballPlayers[3] = defender3;
                footballPlayers[4] = defender4;
                footballPlayers[5] = striker1;
                footballPlayers[6] = striker2;
                footballPlayers[7] = striker3;
                footballPlayers[8] = midfield1;
                footballPlayers[9] = midfield2;
                footballPlayers[10] = midfield3;

                //coach team 1
                Coach coachTeam1 = new Coach("Ivan", 45);
                //creating the team
                Team team = new Team(coachTeam1, footballPlayers);


                //adding players for the second team
                List<FootballPlayer> footballPlayers2 = new List<FootballPlayer>();

                FootballPlayer goalkeeperTeam2 = new Goalkeeper("George", 1, 32, 165);
                FootballPlayer defenderT1 = new Defender("Ronaldo", 7, 34, 170);
                FootballPlayer defenderT2 = new Defender("Neymar", 11, 28, 180);
                FootballPlayer defenderT3 = new Defender("Messi", 10, 32, 165);
                FootballPlayer defenderT4 = new Defender("Luiz Suarez", 2, 30, 180);
                FootballPlayer strikerT1 = new Striker("Holland", 5, 20, 190);
                FootballPlayer strikerT2 = new Striker("Mbappe", 30, 25, 185);
                FootballPlayer strikerT3 = new Striker("Ibrahimovich", 9, 40, 195);
                FootballPlayer midfieldT1 = new Midfield("Stoichkov", 12, 30, 170);
                FootballPlayer midfieldT2 = new Midfield("Berbatov", 22, 235, 178);
                FootballPlayer midfieldT3 = new Midfield("Lewandowski", 15, 21, 180);

                footballPlayers2.Add(goalkeeperTeam2);
                footballPlayers2.Add(defenderT1);
                footballPlayers2.Add(defenderT2);
                footballPlayers2.Add(defenderT3);
                footballPlayers2.Add(defenderT4);
                footballPlayers2.Add(strikerT3);
                footballPlayers2.Add(strikerT1);
                footballPlayers2.Add(strikerT2);
                footballPlayers2.Add(midfieldT1);
                footballPlayers2.Add(midfieldT2);
                footballPlayers2.Add(midfieldT3);

                //coach Team 2
                Coach coachTeam2 = new Coach("Martin", 45);

                //creating Team 2
                Team team2 = new Team(coachTeam2, footballPlayers2);


                //adding referees
                Referee referee = new Referee("Simeon", 50);
                Referee referee1 = new Referee("Samuel", 35);
                Referee referee2 = new Referee("Jonh", 20);

                //match goals
                Goal goal = new Goal(12, striker2);
                Goal goal2 = new Goal(32, defenderT4);
                Goal[] goals = new Goal[2];
                goals[0] = goal;
                goals[1] = goal2;

                //Console.WriteLine(team);
                //Console.WriteLine(team2);

                //printing the game result
                Game game = new Game(team, team2, referee, referee1, referee2, goals, "1:1", "none");
                Console.WriteLine(game);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}