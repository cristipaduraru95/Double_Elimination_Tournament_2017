using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Double_Elimination_Tournament.Classes;
using Double_Elimination_Tournament.Enums;

namespace Double_Elimination_Tournament
{
    public partial class TournamentForm : Form
    {
        public string GameDescription;
        public int LoserPanelCounter;
        public int NumberOfByesWinnerPanel;
        public List<Player> Players;
        public List<Player> PlayersResults;
        public int[] PowersOf2;
        public int Round2MaxMatchesWinnerPanel;
        public string TournamentName;
        public int WinnerPanelCounter;

        public TournamentForm()
        {
            InitializeComponent();
            FinishTournamentButton.Visible = false;
            NameLabel.Text = TournamentName;
            DescriptionLabel.Text = GameDescription;
            PowersOf2 = new int[9];
            FillPowersOf2();
            NumberOfByesWinnerPanel = GetNumberOfByes(Players.Count);
            PlayersResults = new List<Player>();
            WinnerPanelCounter = 1;
            LoserPanelCounter = 1;
            if (NumberOfByesWinnerPanel != 0)
                Round2MaxMatchesWinnerPanel = GetR2MaxNumberMatches(NumberOfByesWinnerPanel, Players.Count);
            FillMatches();
            HighlightFirstMatch();
        }

        public TournamentForm(string tournamentname, string gamedescription, List<Player> players)
        {
            InitializeComponent();
            FinishTournamentButton.Visible = false;
            TournamentName = tournamentname;
            GameDescription = gamedescription;
            Players = players;
            NameLabel.Text = TournamentName;
            DescriptionLabel.Text = GameDescription;
            PowersOf2 = new int[9];
            FillPowersOf2();
            NumberOfByesWinnerPanel = GetNumberOfByes(Players.Count);
            PlayersResults = new List<Player>();
            WinnerPanelCounter = 1;
            LoserPanelCounter = 1;
            if (NumberOfByesWinnerPanel != 0)
                Round2MaxMatchesWinnerPanel = GetR2MaxNumberMatches(NumberOfByesWinnerPanel, Players.Count);
            FillMatches();
            HighlightFirstMatch();
        }

        private void Tournament_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FillPowersOf2()
        {
            PowersOf2[0] = 1;
            for (var i = 1; i < 9; i++)
                PowersOf2[i] = PowersOf2[i - 1] * 2;
        }

        public void FillMatches()
        {
            var xLocation = 3;
            var yLocation = 3;
            var playerCounter = 0;
            int noOfMatches;
            if (NumberOfByesWinnerPanel == 0)
            {
                noOfMatches = Players.Count / 2;
                CreateMatchesNoByes(noOfMatches, xLocation, yLocation, WinnerPanel.Name);
                while (playerCounter != Players.Count)
                    playerCounter = UpdateOneMatch(playerCounter, "Round1WinnerPanel");
                if (Players.Count > 2)
                {
                    if (Players.Count != 4)
                    {
                        var loserPanelNumberOfPlayers = noOfMatches + noOfMatches / 2;
                        var loserPanelNoOfMatches = noOfMatches;
                        var numberOfByesLoserPanel = GetNumberOfByes(loserPanelNumberOfPlayers);
                        var round2MaxNumberOfMatchesLoserPanel =
                            GetR2MaxNumberMatches(numberOfByesLoserPanel, loserPanelNumberOfPlayers);

                        var numberOfR2Matches =
                            GetR2NumberOfMatches(loserPanelNumberOfPlayers, numberOfByesLoserPanel,
                                round2MaxNumberOfMatchesLoserPanel);
                        if (numberOfByesLoserPanel == 0)
                            CreateMatchesNoByes(loserPanelNoOfMatches, xLocation, yLocation, LoserPanel.Name);
                        else
                            CreateMatchesByesRequired(loserPanelNoOfMatches, numberOfR2Matches, xLocation, yLocation,
                                LoserPanel.Name);
                        SetMatchesType(Players.Count, NumberOfByesWinnerPanel, Round2MaxMatchesWinnerPanel, WinnerPanel);
                        SetMatchesType(loserPanelNumberOfPlayers, numberOfByesLoserPanel,
                            round2MaxNumberOfMatchesLoserPanel, LoserPanel);
                    }
                    else
                    {
                        CreateMatchesNoByes(1, xLocation, yLocation, LoserPanel.Name);
                    }
                   
                }
            }
            else
            {
                noOfMatches = GetNumberOfMatches(NumberOfByesWinnerPanel, Players.Count, Round2MaxMatchesWinnerPanel);
                var noOfR2Matches = GetR2NumberOfMatches(Players.Count, NumberOfByesWinnerPanel,
                    Round2MaxMatchesWinnerPanel);
                CreateMatchesByesRequired(noOfMatches, noOfR2Matches, 3, 3, WinnerPanel.Name);
                var loserPanelNumberOfPlayers = noOfMatches;
                var loserPanelNoOfMatches = noOfMatches / 2 + 1;
                var numberOfByesLoserPanel = GetNumberOfByes(loserPanelNumberOfPlayers);
                if (Players.Count == 3)
                {
                    xLocation=CreateAndFillPanel(xLocation, yLocation, 0, LoserPanel.Name);
                    CreateAndFillPanel(xLocation, yLocation, 1, LoserPanel.Name);
                    SetMatchesType(Players.Count, NumberOfByesWinnerPanel, Round2MaxMatchesWinnerPanel, WinnerPanel);
                }
                else
                {
                    var round2MaxNumberOfMatchesLoserPanel =
                        GetR2MaxNumberMatches(numberOfByesLoserPanel, loserPanelNumberOfPlayers);

                    var numberOfR2Matches =
                        GetR2NumberOfMatches(loserPanelNumberOfPlayers, numberOfByesLoserPanel,
                            round2MaxNumberOfMatchesLoserPanel);
                    if (numberOfByesLoserPanel == 0)
                        CreateMatchesNoByes(loserPanelNoOfMatches, xLocation, yLocation, LoserPanel.Name);
                    else
                        CreateMatchesByesRequired(loserPanelNoOfMatches, numberOfR2Matches, xLocation, yLocation,
                            LoserPanel.Name);
                    SetMatchesType(Players.Count, NumberOfByesWinnerPanel, Round2MaxMatchesWinnerPanel, WinnerPanel);
                    SetMatchesType(loserPanelNumberOfPlayers, numberOfByesLoserPanel, round2MaxNumberOfMatchesLoserPanel,
                        LoserPanel);
                }
              
                foreach (Control p in WinnerPanel.Controls)
                    if (p.Name == "Round2WinnerPanel")
                        foreach (Match match in p.Controls)
                        foreach (Control tableLayoutPanel in match.Controls)
                        foreach (Button button in tableLayoutPanel.Controls)
                        {
                            if (match.Type == (int) MatchTypes.ByeMatch &&
                                !match.IsMatchFilled)
                            {
                                button.Text = Players[playerCounter].Name;
                                match.FirstPlayer.Name= Players[playerCounter].Name;
                                playerCounter++;
                                break;
                            }
                            if (match.Type == (int) MatchTypes.FullMatch && !match.IsMatchFilled)
                            {
                                button.Text = Players[playerCounter].Name;
                                if(match.FirstPlayer.Name==string.Empty)
                                match.FirstPlayer.Name = Players[playerCounter].Name;
                                else
                                {
                                    match.SecondPlayer.Name = Players[playerCounter].Name;
                                        }
                                playerCounter++;
                            }
                        }
                foreach (Control p in WinnerPanel.Controls)
                    if (p.Name == "Round1WinnerPanel")
                        foreach (Match match in p.Controls)
                            playerCounter = UpdateOneMatch(playerCounter, "Round1WinnerPanel");
            }


            Refresh();
        }

        private int GetR2MaxNumberMatches(int numberOfByes, int playerCount)
        {
            var i = 0;
            while (PowersOf2[i] < numberOfByes + (playerCount - numberOfByes) / 2)
                i++;
            return PowersOf2[i - 1];
        }

        private int GetNumberOfMatches(int numberOfByes, int playerCount, int round2MaxMatches)
        {
            if (numberOfByes * 3 == playerCount)
                return numberOfByes * 2;
            if (playerCount - numberOfByes * 3 > 2 && (playerCount - numberOfByes * 3) / 2 % 2 == 0
                && numberOfByes + (playerCount - numberOfByes * 3) / 2 != round2MaxMatches)
                return numberOfByes * 2 + (playerCount - numberOfByes * 3) / 2 +
                       (playerCount - numberOfByes * 3) / 4;
            return numberOfByes * 2 + (playerCount - numberOfByes * 3) / 2;
        }

        private int UpdateOneMatch(int playerCounter, string panel)
        {
            foreach (Control p in WinnerPanel.Controls)
                if (p.Name == panel)
                    foreach (Match match in p.Controls)
                    foreach (Control tableLayoutPanel in match.Controls)
                    {
                        var matchButtonCounter = 0;
                        foreach (Control button in tableLayoutPanel.Controls)
                            if (button.GetType() == typeof(Button))
                                if (!match.IsMatchFilled)
                                {
                                    if (match.FirstPlayer.Name.Equals(string.Empty))
                                        match.FirstPlayer.Name = Players[playerCounter].Name;
                                    else
                                        match.SecondPlayer.Name = Players[playerCounter].Name;
                                    button.Text = Players[playerCounter].Name;
                                    playerCounter++;
                                    matchButtonCounter++;
                                    if (matchButtonCounter == 2)
                                    {
                                        match.IsMatchFilled = true;
                                        return playerCounter;
                                    }
                                }
                    }
            return playerCounter;
        }

        private void CreateMatchesNoByes(int noOfMatchesLeft, int xLocation, int yLocation, string panelName)
        {
            while (noOfMatchesLeft > 0)
            {
                if (noOfMatchesLeft == 1)
                {
                    xLocation = CreateAndFillPanel(xLocation, yLocation, noOfMatchesLeft, panelName);
                    CreateAndFillPanel(xLocation, yLocation, noOfMatchesLeft, panelName);
                    break;
                }
                if (noOfMatchesLeft % 2 == 0)
                {
                    xLocation = CreateAndFillPanel(xLocation, yLocation, noOfMatchesLeft, panelName);
                    noOfMatchesLeft /= 2;
                }
                else
                {
                    xLocation = CreateAndFillPanel(xLocation, yLocation, noOfMatchesLeft - 1, panelName);
                    noOfMatchesLeft = (noOfMatchesLeft - 1) / 2;
                }
            }
        }

        private void CreateMatchesByesRequired(int noOfMatchesLeft, int noOfR2Matches, int xLocation, int yLocation,
            string panelName)
        {
     
                xLocation = CreateAndFillPanel(xLocation, yLocation, noOfMatchesLeft - noOfR2Matches, panelName);
                if (noOfR2Matches > 2)
                {
                    xLocation = CreateAndFillPanel(xLocation, yLocation, noOfR2Matches, panelName);
                    CreateMatchesNoByes(noOfR2Matches / 2, xLocation, yLocation, panelName);
                }
                   
                else
                    CreateMatchesNoByes(noOfR2Matches, xLocation, yLocation, panelName);

        }

        private int CreateAndFillPanel(int xLocation, int yLocation, int noOfMatchesLeft, string panelName)
        {
            var panel = CreatePanel(xLocation, yLocation, panelName);
            xLocation += 246;
            FillPanel(noOfMatchesLeft, panel);
            return xLocation;
        }

        public void FillPanel(int noOfMatchesLeft, FlowLayoutPanel panel)
        {
            for (var i = 0; i < noOfMatchesLeft; i = i + 1)
            {
                var match = new Match(string.Empty, string.Empty) {Visible = true};
                match.WinnerSelected += MatchWinnerSelected;
                match.Show();
                panel.Controls.Add(match);
            }
        }

        private FlowLayoutPanel CreatePanel(int xLocation, int yLocation, string panelName)
        {
            var panel = new FlowLayoutPanel
            {
                Name = panelName == "WinnerPanel"
                    ? "Round" + WinnerPanelCounter + panelName
                    : "Round" + LoserPanelCounter + panelName,
                Location = new Point(xLocation, yLocation),
                Size = new Size(240, 307),
                AutoScroll = true,
                WrapContents = false,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle
            };
            if (panelName == "WinnerPanel")
            {
                WinnerPanel.Controls.Add(panel);
                WinnerPanelCounter++;
            }

            else
            {
                LoserPanel.Controls.Add(panel);
                LoserPanelCounter++;
            }

            return panel;
        }

        private void SetMatchesType(int playersCount, int numberOfByes, int round2MaxMatches, FlowLayoutPanel panel)
        {
            foreach (Control p in panel.Controls)
                if (p.Name == "Round1" + panel.Name)
                {
                    foreach (Match match in p.Controls)
                        match.Type = (int) MatchTypes.FullMatch;
                }
                else if (p.Name == "Round2" + panel.Name)
                {
                    var i = 0;
                    foreach (Match match in p.Controls)
                        if (i < numberOfByes)
                        {
                            match.Type = (int) MatchTypes.ByeMatch;
                            i++;
                        }
                        else if (playersCount - numberOfByes * 3 > 2 && (playersCount - numberOfByes * 3) / 2 % 2 == 0
                                 && numberOfByes + (playersCount - numberOfByes * 3) / 2 != round2MaxMatches)
                        {
                            match.Type = (int) MatchTypes.EmptyMatch;
                        }
                        else
                        {
                            match.Type = (int) MatchTypes.FullMatch;
                        }
                }
        }


        private int GetR2NumberOfMatches(int playersCount, int numberOfByes, int round2MaxMatches)
        {
            if (playersCount - numberOfByes * 3 > 2 && (playersCount - numberOfByes * 3) / 2 % 2 == 0
                && numberOfByes + (playersCount - numberOfByes * 3) / 2 != round2MaxMatches)
                return numberOfByes + (playersCount - numberOfByes * 3) / 4;

            return round2MaxMatches;
        }

        public int GetNumberOfByes(int playerCount)
        {
            var noOfByes = 0;
            for (var i = 1; i < 9; i++)
                if (PowersOf2[i] >= playerCount)
                {
                    if (playerCount == PowersOf2[i - 1] || playerCount == PowersOf2[i])
                    {
                        noOfByes = 0;
                        break;
                    }
                    if (playerCount - PowersOf2[i - 1] <= PowersOf2[i] - playerCount)

                    {
                        noOfByes = playerCount - PowersOf2[i - 1];
                        break;
                    }
                    if (PowersOf2[i] - playerCount < playerCount - PowersOf2[i - 1])
                    {
                        noOfByes = PowersOf2[i] - playerCount;
                        break;
                    }
                }
            return noOfByes;
        }

        private void MatchWinnerSelected(object sender, EventArgs e)
        {
            var senderMatch = (Match) sender;
            HighlightNextMatch(senderMatch);
            if (Players.Count == 2 && senderMatch.Parent.Name == "Round1WinnerPanel")
            {
                UpdateWinnerAndLoser(2, senderMatch.Winner.Name, WinnerPanel);
                UpdateWinnerAndLoser(2, senderMatch.Loser.Name, WinnerPanel);
                return;
            }
            if (senderMatch.Winner.Name != string.Empty)
                if (WinnerPanel.Controls.Contains(senderMatch.Parent))
                {
                    var round = (int) char.GetNumericValue(senderMatch.Parent.Name[5]);
                    if (WinnerPanel.Controls.Count < round + 1)
                    {
                        PlayersResults.Add(senderMatch.Loser);
                        PlayersResults.Add(senderMatch.Winner);
                        FinishTournamentButton.Visible = true;
                        return;
                    }
                    UpdateWinnerAndLoser(round + 1, senderMatch.Winner.Name, WinnerPanel);
                    int i = 1;
                    while (!UpdateWinnerAndLoser(i, senderMatch.Loser.Name, LoserPanel))
                        i++;


                }


                else if (LoserPanel.Controls.Contains(senderMatch.Parent))
                {
                    var round = (int) char.GetNumericValue(senderMatch.Parent.Name[5]);
                    if (LoserPanel.Controls.Count >= round + 1)
                        UpdateWinnerAndLoser(round + 1, senderMatch.Winner.Name, LoserPanel);
                    else
                        for (var i = 0; i < WinnerPanel.Controls.Count; i++)
                            if (UpdateWinnerAndLoser(round + i, senderMatch.Winner.Name, WinnerPanel))
                                break;

                    PlayersResults.Add(senderMatch.Loser);
                }
        }


        private bool UpdateWinnerAndLoser(int round, string playerName, FlowLayoutPanel panel)
        {
            foreach (FlowLayoutPanel p in panel.Controls)
                if (p.Name == "Round" + round + panel.Name)
                    foreach (Match match in p.Controls)
                    foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                    foreach (Button button in tableLayoutPanel.Controls)
                        if (button.Text == string.Empty)
                        {
                            if (match.FirstPlayer.Name == string.Empty)
                                match.FirstPlayer.Name = playerName;
                            else
                                match.SecondPlayer.Name = playerName;
                            button.Text = playerName;
                            return true;
                        }
            return false;
        }

        private void HighlightFirstMatch()
        {
            foreach (FlowLayoutPanel p in WinnerPanel.Controls)
                if (p.Name == "Round1WinnerPanel")
                    foreach (Match match in p.Controls)
                    {
                        foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                        foreach (Button button in tableLayoutPanel.Controls)
                            button.Enabled = true;
                        match.BackColor = Color.Coral;
                        return;
                    }
        }

        private void HighlightNextMatch(Match previousMatch)
        {
            DisablePreviousMatch(previousMatch);
            foreach (Control winnerPanelControl in WinnerPanel.Controls)
            {
                if(winnerPanelControl.Name=="Round2WinnerPanel")
                    foreach (Match match in winnerPanelControl.Controls)
                    {
                        if (match.Type == (int) MatchTypes.EmptyMatch)
                        {
                            HighlightMatchContainsEmptyMatch(previousMatch);
                            return;
                        }
                            
                    }
            }
            HighlightMatchDoesNotContainEmptyMatch(previousMatch);

            
        }

        private void HighlightMatchDoesNotContainEmptyMatch(Match previousMatch)
        {
            if (Players.Count == 2 && previousMatch.Parent.Name == "Round1WinnerPanel")
                foreach (FlowLayoutPanel p in WinnerPanel.Controls)
                    if (p.Name == "Round2WinnerPanel")
                        foreach (Match match in p.Controls)
                        {
                            foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                            foreach (Button button in tableLayoutPanel.Controls)
                                button.Enabled = true;
                            match.BackColor = Color.Coral;
                            return;
                        }
            foreach (Match match in previousMatch.Parent.Controls)
                if (!match.IsMatchPlayed)
                {
                    foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                    foreach (Button button in tableLayoutPanel.Controls)
                        button.Enabled = true;
                    match.BackColor = Color.Coral;
                    return;
                }
            if (WinnerPanel.Contains(previousMatch.Parent))
            {
                var round = (int)char.GetNumericValue(previousMatch.Parent.Name[5]);
                if (WinnerPanel.Controls.Count < round + 1)
                {
                    FinishTournamentButton.BackColor = Color.Coral;
                    return;
                }
                if(round!=1)
                {
                    if (round != 2)
                    {
                        foreach (FlowLayoutPanel p in LoserPanel.Controls)
                            if (p.Name == "Round" + round + "LoserPanel")
                                foreach (Match match in p.Controls)
                                {
                                    foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                    foreach (Button button in tableLayoutPanel.Controls)
                                        button.Enabled = true;
                                    match.BackColor = Color.Coral;
                                    return;
                                }
                    }
                    else
                    {
                        if (Players.Count == 3)
                        {
                            foreach (FlowLayoutPanel p in LoserPanel.Controls)
                                if (p.Name == "Round2LoserPanel")
                                    foreach (Match match in p.Controls)
                                    {
                                        foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                        foreach (Button button in tableLayoutPanel.Controls)
                                            button.Enabled = true;
                                        match.BackColor = Color.Coral;
                                        return;
                                    }
                        }
                        else
                        {
                            foreach (FlowLayoutPanel p in LoserPanel.Controls)
                                if (p.Name == "Round" + (round - 1) + "LoserPanel")
                                    foreach (Match match in p.Controls)
                                    {
                                        foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                        foreach (Button button in tableLayoutPanel.Controls)
                                            button.Enabled = true;
                                        match.BackColor = Color.Coral;
                                        return;
                                    }
                        }
                        
                    }
                 
                }
                else
                {
                    foreach (FlowLayoutPanel p in WinnerPanel.Controls)
                        if (p.Name == "Round" + (round+1) + "WinnerPanel")
                            foreach (Match match in p.Controls)
                            {
                                foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                foreach (Button button in tableLayoutPanel.Controls)
                                    button.Enabled = true;
                                match.BackColor = Color.Coral;
                                return;
                            }
                }
               
            }
            else if (LoserPanel.Contains(previousMatch.Parent))
            {
                var round = (int)char.GetNumericValue(previousMatch.Parent.Name[5]);
                if (round != 1)
                {
                    if (previousMatch.Parent.Controls.Count != 1)
                    {
                        foreach (FlowLayoutPanel p in WinnerPanel.Controls)
                            if (p.Name == "Round" + (round + 1) + "WinnerPanel")
                                foreach (Match match in p.Controls)
                                {
                                    foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                    foreach (Button button in tableLayoutPanel.Controls)
                                        button.Enabled = true;
                                    match.BackColor = Color.Coral;
                                    return;
                                }
                    }
                    else if (previousMatch.Parent.Controls.Count == 1)
                    {
                        if (LoserPanel.Controls.Count <= round + 1)
                            foreach (FlowLayoutPanel p in WinnerPanel.Controls)
                                if (p.Name == "Round" + (round+1) + "WinnerPanel")
                                    foreach (Match match in p.Controls)
                                    {
                                        foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                        foreach (Button button in tableLayoutPanel.Controls)
                                            button.Enabled = true;
                                        match.BackColor = Color.Coral;
                                        return;
                                    }


                        foreach (FlowLayoutPanel p in LoserPanel.Controls)
                            if (p.Name == "Round" + (round + 1) + "LoserPanel")
                                foreach (Match match in p.Controls)
                                {
                                    foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                    foreach (Button button in tableLayoutPanel.Controls)
                                        button.Enabled = true;
                                    match.BackColor = Color.Coral;
                                    return;
                                }
                    }

                }
                else
                {
                    foreach (FlowLayoutPanel p in LoserPanel.Controls)
                        if (p.Name == "Round" + (round+1) + "LoserPanel")
                            foreach (Match match in p.Controls)
                            {
                                foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                foreach (Button button in tableLayoutPanel.Controls)
                                    button.Enabled = true;
                                match.BackColor = Color.Coral;
                                return;
                            }
                }
             
            }
        }
        private void HighlightMatchContainsEmptyMatch(Match previousMatch)
        {
            if (Players.Count == 2 && previousMatch.Parent.Name == "Round1WinnerPanel")
                foreach (FlowLayoutPanel p in WinnerPanel.Controls)
                    if (p.Name == "Round2WinnerPanel")
                        foreach (Match match in p.Controls)
                        {
                            foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                            foreach (Button button in tableLayoutPanel.Controls)
                                button.Enabled = true;
                            match.BackColor = Color.Coral;
                            return;
                        }
            foreach (Match match in previousMatch.Parent.Controls)
                if (!match.IsMatchPlayed)
                {
                    foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                    foreach (Button button in tableLayoutPanel.Controls)
                        button.Enabled = true;
                    match.BackColor = Color.Coral;
                    return;
                }
            if (WinnerPanel.Contains(previousMatch.Parent))
            {
                var round = (int) char.GetNumericValue(previousMatch.Parent.Name[5]);
                if (WinnerPanel.Controls.Count < round + 1)
                {
                    FinishTournamentButton.BackColor = Color.Coral;
                    return;
                }
                foreach (FlowLayoutPanel p in LoserPanel.Controls)
                    if (p.Name == "Round" + round + "LoserPanel")
                        foreach (Match match in p.Controls)
                        {
                            foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                            foreach (Button button in tableLayoutPanel.Controls)
                                button.Enabled = true;
                            match.BackColor = Color.Coral;
                            return;
                        }
            }
            else if (LoserPanel.Contains(previousMatch.Parent))
            {
                var round = (int) char.GetNumericValue(previousMatch.Parent.Name[5]);
                if (previousMatch.Parent.Controls.Count != 1)
                {
                    foreach (FlowLayoutPanel p in WinnerPanel.Controls)
                        if (p.Name == "Round" + (round + 1) + "WinnerPanel")
                            foreach (Match match in p.Controls)
                            {
                                foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                foreach (Button button in tableLayoutPanel.Controls)
                                    button.Enabled = true;
                                match.BackColor = Color.Coral;
                                return;
                            }
                }
                else if (previousMatch.Parent.Controls.Count == 1)
                {
                    if (LoserPanel.Controls.Count < round + 1)
                        foreach (FlowLayoutPanel p in WinnerPanel.Controls)
                            if (p.Name == "Round" + round + "WinnerPanel")
                                foreach (Match match in p.Controls)
                                {
                                    foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                    foreach (Button button in tableLayoutPanel.Controls)
                                        button.Enabled = true;
                                    match.BackColor = Color.Coral;
                                    return;
                                }


                    foreach (FlowLayoutPanel p in LoserPanel.Controls)
                        if (p.Name == "Round" + (round + 1) + "LoserPanel")
                            foreach (Match match in p.Controls)
                            {
                                foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
                                foreach (Button button in tableLayoutPanel.Controls)
                                    button.Enabled = true;
                                match.BackColor = Color.Coral;
                                return;
                            }
                }
            }
        }

        private void DisablePreviousMatch(Match match)
        {
            match.BackColor = Color.Gainsboro;
            foreach (TableLayoutPanel tableLayoutPanel in match.Controls)
            foreach (Button button in tableLayoutPanel.Controls)
                button.Enabled = false;
        }

        private void FinishTournamentButton_Click(object sender, EventArgs e)
        {
            var tournamentResults = new TournamentResults(PlayersResults, TournamentName);
            tournamentResults.Show();
            Hide();
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.BackColor = Color.Chocolate;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.BackColor = Color.Gainsboro;
        }
    }
}