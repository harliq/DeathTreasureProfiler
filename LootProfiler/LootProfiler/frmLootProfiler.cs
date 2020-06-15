using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootProfiler
{
    public partial class frmLootProfiler : Form
    {
        public frmLootProfiler()
        {
            InitializeComponent();
        }

        private void frmLootProfiler_Load(object sender, EventArgs e)
        {
            // cbStatus.DataSource = Enum.GetValues(typeof(Status));
            cBoxItemChances.DataSource = Enum.GetValues(typeof(ItemChances));
            cBoxMagicItemChances.DataSource = Enum.GetValues(typeof(ItemChances));
            cBoxMundaneItemChances.DataSource = Enum.GetValues(typeof(ItemChances));
            label2.Visible = false;
            label3.Visible = false;
            txtBoxID.Visible = false;
            txtBoxCreatureDescription.Visible = false;


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Text File";
            ofd.Filter = "SQL files|*.sql";
            ofd.InitialDirectory = @"C:\Users\Harli\Source\Repos\ACE-World-16PY\Database\3-Core\3 TreasureTable\SQL\Death";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                var formData = new LootProfile();

                formData = FileOps.OpenFile(ofd.FileName);
                FillForm(formData);
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Open Text File";
            sfd.Filter = "SQL files|*.sql";
            sfd.FileName = $"00{txtBoxDiD}.sql";
            sfd.InitialDirectory = @"C:\Ace";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var profileData = new LootProfile();


               //rofileData.DTdid = 



            }
        }

        private void FillForm(LootProfile lootProfile)
        {
            txtBoxDiD.Text = lootProfile.DTdid.ToString();
            txtBoxTier.Text = lootProfile.Tier.ToString();
            txtBoxLootQualityMod.Text = lootProfile.LootQualityMod.ToString();
            txtBoxUnknownChance.Text = lootProfile.UnknownChances.ToString();

            txtBoxItemChance.Text = lootProfile.ItemChance.ToString();
            txtBoxItemMin.Text = lootProfile.ItemMinAmount.ToString();
            txtBoxItemMax.Text = lootProfile.ItemMaxAmount.ToString();
            cBoxItemChances.SelectedIndex = lootProfile.ItemTreasureTypeSelectionChances - 1;
            lblItemTreasureChances.Text = lootProfile.ItemTreasureTypeSelectionChances.ToString();

            txtBoxMagicItemChance.Text = lootProfile.MagicItemChance.ToString();
            txtBoxMagicItemMin.Text = lootProfile.MagicItemMinAmount.ToString();
            txtBoxMagicItemMax.Text = lootProfile.MagicItemMaxAmount.ToString();
            cBoxMagicItemChances.SelectedIndex = lootProfile.MagicItemTreasureTypeSelectionChances -1 ;
            lblMagicItemTreasureChance.Text = lootProfile.MagicItemTreasureTypeSelectionChances.ToString();

            txtBoxMundaneItemChance.Text = lootProfile.MundaneItemChance.ToString();
            txtBoxMundaneItemMin.Text = lootProfile.MundaneItemMinAmount.ToString();
            txtBoxMundaneItemMax.Text = lootProfile.MundaneItemMaxAmount.ToString();
            cBoxMundaneItemChances.SelectedIndex = lootProfile.MundaneItemTreasureTypeSelectionChances - 1;
            lblMundaneItemTreasureChance.Text = lootProfile.MundaneItemTreasureTypeSelectionChances.ToString();

            lblLastModified.Text = lootProfile.LastModified;

        }

        private void cBoxItemChances_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = cBoxItemChances.SelectedIndex + 1;
            lblItemTreasureChances.Text = value.ToString();
        }

        private void cBoxMagicItemChances_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = cBoxMagicItemChances.SelectedIndex + 1;
            lblMagicItemTreasureChance.Text = value.ToString();
        }

        private void cBoxMundaneItemChances_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = cBoxMundaneItemChances.SelectedIndex + 1;
            lblMundaneItemTreasureChance.Text = value.ToString();
        }
        private void txtBoxDiD_Leave(object sender, EventArgs e)
        {
            
        }
        private static int ConvertToInt(string Convert)
        {
            int val = 0;

            try
            {
                val = int.Parse(Convert);
            }
            catch (Exception)
            {
                MessageBox.Show("Stopping!  One of the values in your profile is not an integer.");
                return 999999;
                throw;
            }


            return val; 

        }
    }
}
