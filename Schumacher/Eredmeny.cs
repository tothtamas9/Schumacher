using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schumacher
{
    public class Eredmeny
    {
        DateTime date;
        string grandprix;
        int position;
        int laps;
        int points;
        string team;
        string status;

        public Eredmeny(DateTime date, string grandprix, int position, int laps, int points, string team, string status)
        {
            this.date = date;
            this.grandprix = grandprix;
            this.position = position;
            this.laps = laps;
            this.points = points;
            this.team = team;
            this.status = status;
        }

        public DateTime Date { get => date; }
        public string Grandprix { get => grandprix; }
        public int Position { get => position; }
        public int Laps { get => laps; }
        public int Points { get => points; }
        public string Team { get => team; }
        public string Status { get => status; }
    }
}
