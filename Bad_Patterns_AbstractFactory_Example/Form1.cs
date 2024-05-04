using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Bad_Patterns_AbstractFactory_Example
{
    public partial class Form1 : Form
    {
        private readonly string _resourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
        
        private Alcoholic _alcoholic;
        private DrinkAbstractFactory _drinkAbstractFactory;
        public Form1()
        {
            _drinkAbstractFactory = new DrinkAbstractFactory();
            _alcoholic = new Alcoholic(100);
            BindAlcoholicEvents();
            InitializeComponent();

            pictureBox1.Image = Image.FromFile(Path.Combine(_resourcePath,"stop_video_image.png"));
            PrintAlcoholicHealth();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
            DisplayVideo("init_video.mp4");
        }

        private void vodkaDrinkButton_Click(object sender, EventArgs e)
        {
            DoDrink(DrinkType.Vodka);
        }

        private void coffeeDrinkButton_Click(object sender, EventArgs e)
        {
            DoDrink(DrinkType.Coffee);
        }

        private void waterDrinkButton_Click(object sender, EventArgs e)
        {
            DoDrink(DrinkType.Water);
        }

        private void DoDrink(DrinkType drinkType)
        {
            var drink = _drinkAbstractFactory.Create(drinkType);
            _alcoholic.Drink(drink);
        }

        private void DisplayVideo(string videoName, bool isForegroundImageVisible = false)
        {
            pictureBox1.Visible = isForegroundImageVisible;
            axWindowsMediaPlayer1.URL = Path.Combine(_resourcePath, videoName);
        }

        private void Alcoholic_OnDamaged(object sender, EventArgs e)
        {
            DisplayVideo("ondamaged_video.mp4");
            PrintAlcoholicHealth();
        }

        private void Alcoholic_OnHealed(object sender, EventArgs e)
        {
            DisplayVideo("onhealed_video.mp4");
            PrintAlcoholicHealth();
        }

        private void Alcoholic_OnDead(object sender, EventArgs e)
        {
            coffeeDrinkButton.Enabled = false;
            vodkaDrinkButton.Enabled = false;
            waterDrinkButton.Enabled = false;
            DisplayVideo("ded_max_song.mp4",true);
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                pictureBox1.Visible = true;
            }
        }

        private void PrintAlcoholicHealth()
        {
            alcoholicHealthLabel.Text = _alcoholic.Health.ToString();
        }


        private void BindAlcoholicEvents()
        {
            _alcoholic.OnDamaged += Alcoholic_OnDamaged;
            _alcoholic.OnHealed += Alcoholic_OnHealed;
            _alcoholic.OnDead += Alcoholic_OnDead;
        }
    }

}
