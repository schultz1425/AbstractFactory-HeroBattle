using HeroBattle;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FightAtlantis fightAtlantis = new FightAtlantis();
            FightColiseum fightColiseum = new FightColiseum();
            FightGalactic fightGalactic = new FightGalactic();

            comboBox1.Items.Clear();
            comboBox1.Items.Add(fightAtlantis);
            comboBox1.Items.Add(fightColiseum);
            comboBox1.Items.Add(fightGalactic);

            MessageBox.Show(fightAtlantis.Do());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((AbstractHeroBattle)comboBox1.SelectedItem).GetWarrior().Equipment();
            textBox2.Text = ((AbstractHeroBattle)comboBox1.SelectedItem).GetArcher().Equipment();
            textBox3.Text = ((AbstractHeroBattle)comboBox1.SelectedItem).GetMagician().Equipment();
        }
    }
}