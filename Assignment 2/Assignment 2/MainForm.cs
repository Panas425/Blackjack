using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCardLib;
using UtilitiesLib;
using Microsoft.VisualBasic;

namespace Assingment2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Declaring variables
        /// </summary>
        private GameManager manager = new GameManager();

        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// When the application starts events are added to the GameManager class and the GUI is initialize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            manager.PaintCards += new GameManager.PaintCardHandler(PaintCards);
            manager.StartTimer += new GameManager.CountDownTimer(StartTimer);
            manager.CardDisplayTime += new GameManager.DisplayTimer(CardDisplayTime);
            manager.UpdateText += new GameManager.UpdateTextUI(UpdateText);
            manager.UpdateScore += new GameManager.UpdateScoreList(UpdateScore);
            manager.UpdateFinalScore += new GameManager.FinalScores(UpdateFinalScore);
            InitGUI();
        }

        /// <summary>
        /// application starts with asking the user to input amount of players and decks
        /// </summary>
        private void InitGUI()
        {
            String players = Interaction.InputBox("Enter amount of players", "Input Players", "1", -1, -1);
            String decks = Interaction.InputBox("Enter amount of decks", "Input Decks", "1", -1, -1);

            int amountPlayers = int.Parse(players);
            int amountDeck = int.Parse(decks);

            manager.InitPlayersAndDeck(amountPlayers, amountDeck);
            manager.PlayerHit();
        }


        /// <summary>
        /// Shuffles the remaning cards in the deck
        /// shows a messagebox to inform the user the deck is shuffled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            manager.ShuffleDeck();
            MessageBox.Show("Deck Shuffled");
        }

        /// <summary>
        /// The current player will get another card to its hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHit_Click(object sender, EventArgs e)
        {
            manager.PlayerHit();
        }

        /// <summary>
        /// The current player wish to keep its hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStand_Click(object sender, EventArgs e)
        {
            manager.PlayerStand();
        }

        /// <summary>
        /// resets the current game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            displayTimer.Stop();
            cardsLeftLabel.Text = "Cards left in Deck:";
            dealerHandLabel.Text = "Hand Value: ";
            playerHandLabel.Text = dealerHandLabel.Text;
            playerLabel.Text = "Player";
            dealerImages.Clear();
            playerImages.Clear();
            scoreTable.Rows.Clear();
            dealerBox.Invalidate();
            playerBox.Invalidate();
            InitGUI();
        }

        /// <summary>
        /// images from the dealer's hand and from the current player's hand is received, the paint events are then raised
        /// </summary>
        /// <param name="dealerImages"></param>
        /// <param name="playerImages"></param>
        private void PaintCards(List<Image> dealerImages, List<Image> playerImages)
        {
            this.dealerImages = dealerImages;
            this.playerImages = playerImages;
            dealerBox.Refresh();
            playerBox.Refresh();
        }

        /// <summary>
        /// Declaring variables which is used to print the cards certain position
        /// </summary>
        private int column = 0;
        private int xSpace = 50;
        private int ySpace = 200;
        private int extraSpace = 0;
        private bool switchRow = false;
        private List<Image> dealerImages = new List<Image>();
        private List<Image> playerImages = new List<Image>();


        /// <summary>
        /// prints out the cards in the dealer's hand in a user friendly spectrum 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dealerBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int index = 0; index < dealerImages.Count; index++)
            {
                if (index > 5 && !switchRow)
                {
                    switchRow = true;
                    column = 0;
                    ySpace = 50;
                    extraSpace = 25;
                }
                column++;
                g.DrawImage(dealerImages[index], column * xSpace + extraSpace, ySpace, PlayingCards.Width, PlayingCards.Height);
            }
            ResetPaintVariables();
        }

        /// <summary>
        /// Paints out the cards in the current player's hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int index = 0; index < playerImages.Count; index++)
            {
                if (index > 5 && !switchRow)
                {
                    switchRow = true;
                    column = 0;
                    ySpace = 50;
                    extraSpace = 25;
                }
                column++;
                g.DrawImage(playerImages[index], column * xSpace + extraSpace, ySpace, PlayingCards.Width, PlayingCards.Height);
            }
            ResetPaintVariables();
        }

        /// <summary>
        /// reset some values used when painting out the cards
        /// </summary>
        private void ResetPaintVariables()
        {
            column = 0;
            xSpace = 50;
            ySpace = 200;
            extraSpace = 0;
            switchRow = false;
        }

        /// <summary>
        /// the playerName, hand value of the dealer and the player are displayed to the user
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="playerHandValue"></param>
        /// <param name="dealerHandValue"></param>
        private void UpdateText(int cardsLeft, string playerName, int playerHandValue, int dealerHandValue)
        {
            cardsLeftLabel.Text = "Cards left in Deck: " + cardsLeft;
            playerLabel.Text = playerName;
            playerHandLabel.Text = "Hand Value: " + playerHandValue;
            dealerHandLabel.Text = "Hand Value: " + dealerHandValue;
        }

        /// <summary>
        /// hand value of the player and the player's current state are displayed to the user via adding them as a row in the scoreTable
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="playerHandValue"></param>
        /// <param name="playerState"></param>
        private void UpdateScore(string playerName, int playerHandValue, string playerState)
        {
            bool found = false;

            for (int i = 0; i < scoreTable.Rows.Count; i++)
            {
                if (scoreTable.Rows[i].Cells[0].Value.Equals(playerName))
                {
                    scoreTable.Rows.RemoveAt(i);
                    scoreTable.Rows.Insert(i, playerName, playerHandValue, playerState);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                scoreTable.Rows.Add(playerName, playerHandValue, playerState);
            }
        }

        /// <summary>
        /// Adds the dealers score into the scoreTable
        /// </summary>
        /// <param name="dealerName"></param>
        /// <param name="dealerHandValue"></param>
        /// <param name="dealerResult"></param>
        private void UpdateFinalScore(string dealerName, int dealerHandValue, string dealerResult)
        {
            scoreTable.Rows.Insert(0, dealerName, dealerHandValue, dealerResult);
        }

        /// <summary>
        /// starting a timer and disables some buttons
        /// </summary>
        private void StartTimer()
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnShuffle.Enabled = false;
            countdownTimer.Start();
        }

        /// <summary>
        /// Some buttons is enabled to the user again if the user is playing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            countdownTimer.Stop();

            if (manager.PlayerIsPlaying && manager.GetPlayerState() == PlayingStates.Playing)
            {
                btnHit.Enabled = true;
                btnStand.Enabled = true;
                btnShuffle.Enabled = true;
            }
            manager.FlipLastCardUp();
        }

        /// <summary>
        /// timer is started
        /// </summary>
        private void CardDisplayTime()
        {
            displayTimer.Start();
        }

        /// <summary>
        /// timer is stopped
        /// either CheckIfDealersTurn or CheckIfGameIsOver is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayTimer_Tick(object sender, EventArgs e)
        {
            displayTimer.Stop();

            if (manager.PlayerIsPlaying)
            {
                if (manager.GetPlayerState() == PlayingStates.BlackJack || manager.GetPlayerState() == PlayingStates.Thick)
                {
                    manager.CheckIfDealersTurn();
                }
            }
            else
            {
                manager.CheckIfGameIsOver();
            }
        }
    }
}