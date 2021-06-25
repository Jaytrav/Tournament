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
        Dictionary<Team, int> placing = new Dictionary<Team, int>();

        public void allocatePlace(Team t, int i)
        {
            placing.Add(t, i);
        }

        public int getPoints(Team t)

        {
            int position = placing[t];
            switch (position)
            {
                case 1:
                    return 5;
                    break;
                case 2:
                    return 4;
                    break;
                case 3:
                    return 3;
                    break;
                case 4:
                    return 2;
                case 5:
                    return 1;
                    break;
            }
            return 0;
        }
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
                    Console.WriteLine(s + " is is not valid!");
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

