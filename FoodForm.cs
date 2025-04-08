using Assignment1VT25;
using Assignment3VT25.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3VT25
{
    public partial class FoodForm : Form
    {
        FoodItem animalFood = new FoodItem(1, " ");
        private MainForm _mainForm;
        public FoodForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            tbName = new TextBox();
            groupBox1 = new GroupBox();
            tbIngredient = new TextBox();
            lblIngredient = new Label();
            btCancel = new Button();
            btOK = new Button();
            btDelete = new Button();
            btChange = new Button();
            btAdd = new Button();
            lsbIngredient = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(89, 25);
            tbName.Name = "tbName";
            tbName.Size = new Size(169, 23);
            tbName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbIngredient);
            groupBox1.Controls.Add(lblIngredient);
            groupBox1.Controls.Add(btCancel);
            groupBox1.Controls.Add(btOK);
            groupBox1.Controls.Add(btDelete);
            groupBox1.Controls.Add(btChange);
            groupBox1.Controls.Add(btAdd);
            groupBox1.Controls.Add(lsbIngredient);
            groupBox1.Location = new Point(26, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 256);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Ingredient";
            // 
            // tbIngredient
            // 
            tbIngredient.Location = new Point(81, 32);
            tbIngredient.Name = "tbIngredient";
            tbIngredient.Size = new Size(169, 23);
            tbIngredient.TabIndex = 4;
            // 
            // lblIngredient
            // 
            lblIngredient.AutoSize = true;
            lblIngredient.Location = new Point(18, 32);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(61, 15);
            lblIngredient.TabIndex = 3;
            lblIngredient.Text = "Ingredient";
            // 
            // btCancel
            // 
            btCancel.Location = new Point(144, 216);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 5;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            btOK.Location = new Point(30, 216);
            btOK.Name = "btOK";
            btOK.Size = new Size(75, 23);
            btOK.TabIndex = 4;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(7, 152);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 3;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btChange
            // 
            btChange.Location = new Point(8, 123);
            btChange.Name = "btChange";
            btChange.Size = new Size(75, 23);
            btChange.TabIndex = 2;
            btChange.Text = "Change";
            btChange.UseVisualStyleBackColor = true;
            btChange.Click += btChange_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(8, 94);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 1;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // lsbIngredient
            // 
            lsbIngredient.FormattingEnabled = true;
            lsbIngredient.ItemHeight = 15;
            lsbIngredient.Location = new Point(88, 75);
            lsbIngredient.Name = "lsbIngredient";
            lsbIngredient.Size = new Size(162, 124);
            lsbIngredient.TabIndex = 0;
            lsbIngredient.SelectedIndexChanged += lsbIngredient_SelectedIndexChanged;
            // 
            // FoodForm
            // 
            ClientSize = new Size(295, 348);
            Controls.Add(groupBox1);
            Controls.Add(tbName);
            Controls.Add(lblName);
            Name = "FoodForm";
            Text = "Add Food";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblName;
        private TextBox tbName;
        private GroupBox groupBox1;
        private Button btDelete;
        private Button btChange;
        private Button btAdd;
        private ListBox lsbIngredient;
        private Button btCancel;
        private Button btOK;
        private TextBox tbIngredient;
        private Label lblIngredient;

        private void btOK_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
           

            if (!string.IsNullOrWhiteSpace(name))
            {
                // Add only the ingredient to the list
                //animalFood.Ingredients.Add(ingredient);

                // Refresh the ListBox
                //_mainForm.lbIngredients.Items.Clear();

                // Format the line: "Name: Ingredient1, Ingredient2, Ingredient3"
                string formattedEntry = $"{name}: {string.Join(", ", animalFood.Ingredients.ToStringList())}";

                // Add formatted entry to the ListBox
                _mainForm.lbIngredients.Items.Add(formattedEntry);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string newIngredient = tbIngredient.Text;

            if (!string.IsNullOrWhiteSpace(newIngredient))
            {
                animalFood.Ingredients.Add(newIngredient);
                lsbIngredient.Items.Add(newIngredient);
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected and the text field is not empty
            if (lsbIngredient.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(tbIngredient.Text))
            {
                int selectedIndex = lsbIngredient.SelectedIndex; // Get the selected index
                string newIngredient = tbIngredient.Text;       // Get new ingredient from TextBox

                // Update ListBox
                lsbIngredient.Items[selectedIndex] = newIngredient;

                // Update the corresponding ingredient in FoodItem
                animalFood.Ingredients.ChangeAt(newIngredient, selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an ingredient and enter a new value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lsbIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lsbIngredient.SelectedIndex != -1)
            {
                int selectedIndex = lsbIngredient.SelectedIndex; // Hämta indexet på den valda ingrediensen

                // Ta bort ingrediensen från ListManager
                animalFood.Ingredients.DeleteAt(selectedIndex); // Använder din ListManager-metod

                // Ta bort från ListBox
                lsbIngredient.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Select an ingredient to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
