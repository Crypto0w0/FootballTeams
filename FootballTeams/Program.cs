using FootballTeams;
using Microsoft.EntityFrameworkCore;

namespace Games;

class Program
{
    public static void Main()
    {
        int ans;
        Console.WriteLine("1 - Add a new team");
        Console.WriteLine("2 - Show all teams");

        ans = Convert.ToInt32(Console.ReadLine());
        if (ans == 1)
        {
            AddTeam();
        }
        else if (ans == 2)
        {
            ShowAll();
        }
        else Console.WriteLine("Unknown command");
    }
    
    public static void AddTeam()
    {
        Console.WriteLine("Name: ");
        string n = Console.ReadLine();
        Console.WriteLine("City: ");
        string c = Console.ReadLine();
        Console.WriteLine("Wins: ");
        int w = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Loses: ");
        int l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Draws: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Scored goals: ");
        int s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Recieved goals: ");
        int r = Convert.ToInt32(Console.ReadLine());
        using var context = new TeamDbContext();
        var team = context.Teams.FirstOrDefault();
        team.name = n;
        team.city = c;
        team.wins = w;
        team.loses = l;
        team.draws = d;
        team.scored = s;
        team.recieved = r;
        context.Teams.Add(team);
    }
    public static void ShowAll()
    {
        using var context = new TeamDbContext();
        var teams = context.Teams;
        foreach (var team in teams)
        {
            Console.WriteLine($"Name: {team.name}, City: {team.city}, Wins: {team.wins}, Loses: {team.loses}, Draws: {team.draws}");
        }
    }
}