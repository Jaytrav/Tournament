using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class UI
    {
        List<Participant> allParticipants = new List<Participant>();
        List<Team> allTeams = new List<Team>();

        public int selectTeam()
        {
            for (int i = 0; i < allTeams.Count; i++)
            {
                Console.WriteLine(i + "; " + allTeams[i].getName());
            }
            Console.WriteLine("select Team");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;

        }
        public int selectParticipant()
            {
                for (int i = 1; i < allParticipants.Count; i++)
                {
                    Console.WriteLine(i + "; " + allParticipants[i].getName());
                }
                Console.WriteLine("select Participant");
                string input = Console.ReadLine();
                int result = Int32.Parse(input);
                return result;
            }

        public void MainMenu()
            {
                string choice = "start";
                while (!choice.Equals("quit"))
                {
                    Console.WriteLine("1 - Enter a new participant");
                    Console.WriteLine("2 - Enter a new team");
                    Console.WriteLine("3 - Enter new event (Sporting or Academic)");
                    Console.WriteLine("4 - Enter a new tournament");
                    Console.WriteLine("5 - Add participant to team");
                    Console.WriteLine("or type quit");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Enter name: ");
                            string name = Console.ReadLine();
                            Participant p = new Participant();
                            p.setName(name);
                            p.printParticipant();
                            allParticipants.Add(p);
                            break;
                        case "2":
                            Console.WriteLine("Enter team name: ");
                            string teamname = Console.ReadLine();
                            Team t = new Team();
                            t.setName(teamname);
                            t.printTeam();
                            break;
                        case "3":
                            Console.WriteLine("Enter new event: ");
                            string ev = Console.ReadLine();
                            Event e = new Event();
                            e.setType(ev);
                            e.printEvent();
                            break;
                        case "4":
                            Console.WriteLine("Enter tournament name:");
                            string tournament = Console.ReadLine();
                            Tournament q = new Tournament();
                            q.setName(tournament);
                            q.printTournament();
                            break;
                        case "5":
                            Team teamselected = allTeams[selectTeam()];
                            Participant partselected = allParticipants[selectParticipant()];
                            teamselected.addParticipant(partselected);
                            teamselected.printTeam();
                            break;
                        case "6":
                            break;
                            






                }
            }
                }   
            }
        }

