using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordViewerForm
{
    public class PlayerRecord
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public PlayerRecord() : this(string.Empty, 0) { }
        public PlayerRecord(string playerName, int score)
        {
            PlayerName = playerName;
            Score = score;
        }
    }
}
