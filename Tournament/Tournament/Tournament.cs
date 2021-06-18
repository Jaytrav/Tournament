using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class Tournament
    {
        string Tournamentname;
        List<Event> Events = new List<Event>();
        List<Team> Team = new List<Team>();
        List<Participant> members = new List<Participant>();

        public void setName(string t)
        {
            this.Tournamentname = t;
        }

        public string getname()
        {
            return Tournamentname;

        }
        public void addEvent(Event e)
        {
            if (Events.Count >= 5)
            {
                Console.WriteLine("Too many events!");
            }
            else
            {
                Events.Add(e);
            }
        }

        public void addTeam(Team q)
        {
            if (Team.Count >= 4)
            {
                Console.WriteLine("Too many Teams!");
            }
        }
        public void addParticipant(Participant P)
        {
            if (members.Count >= 20)
            {
                Console.WriteLine("Too many Participants!");
            }
            else
            {
                members.Add(P);
            }
        }
        public void printTournament()
        {
            Console.WriteLine("A tournament called " + Tournamentname);
            Console.WriteLine("It has the following members");
            for (int i = 0; i < members.Count; i++)
            {
                members[i].printParticipant();
            }
            Console.WriteLine("It has the following members:");
            for (int i = 0; i < Team.Count; i++)
            {
                Team[i].printTeam();
            }
            Console.WriteLine("It has the following Events:");
            for (int i = 0; i < Events.Count; i++)
            {
                Team[i].printTeam();
            }
        }
    }
}