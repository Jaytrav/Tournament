
using System;

using System.Collections.Generic;

using System.Text;



namespace Tournament
{
    class Participant
    {
        string personname;
        public void setName(string p)
        {
            this.personname = p;
        }

        public string getName()
        {
            return personname;
        }

        public void printParticipant()
        {
            Console.WriteLine(" A participant called" + personname);
        }
    }
}