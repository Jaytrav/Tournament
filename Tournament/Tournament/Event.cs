using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class Event
    {
        string eventname;
        List<string> types = new List<string>();
        string type;


        public Event()
        {
            types.Add("academic");
            types.Add("sporting");
        }

        public void setType(String s)
        {
            if (types.Contains(s))
            {
                type = s;
            }
            else
            {
                Console.WriteLine(s +" is is not valid!");
            }
        }

        public void chooseType(string t)
        {
            this.type = t;
        }

        public string getType()
        {
            return type;
        }

        public void printType()
        {
            Console.WriteLine(" A participant called" + type);
        }
        public void setName(string e)
        {
            this.eventname = e;
        }

        public string getName()
        {
            return eventname;
        }

        public void printEvent()
        {
            Console.WriteLine(" An event called " + eventname + ". It is of type " + type + ".");
        }

    }
}
