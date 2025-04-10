using Assignment1VT25.Properties;
using Assignment2VT25.Assignment2V25;
using Assignment2VT25.Properties;
using Assignment3VT25;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Assignment1VT25
{
    public partial class MainForm : Form
    {
        AnimalManager animalManager = new AnimalManager();
        public MainForm()
        {
            InitializeComponent();
            // Fills the gender combo box with the values from the GenderType enum
            cmbGender.Items.AddRange(Enum.GetNames(typeof(GenderType)));

            // Set the category list box's data to the values from the Category enum
            lbCategory.DataSource = Enum.GetValues(typeof(Category));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                bool isvalidated = false;

                switch (lbCategory.SelectedItem.ToString())
                {
                    case "Bird":
                        if (ValidateBird())
                        {
                            isvalidated = true;
                        }
                        break;
                    case "Insect":
                        if (ValidateInsect())
                        {
                            isvalidated = true;
                        }
                        break;
                    case "Fish":
                        if (ValidateFish())
                        {
                            isvalidated = true;
                        }
                        break;

                }
                if (isvalidated)
                {
                    Animal animal = null;
                    switch (lbCategory.SelectedItem.ToString())
                    {
                        case "Bird":
                            animal = CreateBird();
                            break;
                        case "Insect":
                            animal = CreateInsect();

                            break;
                        case "Fish":
                            animal = CreateFish();

                            break;
                    }
                    AssignAnimalProperties(animal);
                    CheckInputIsValidAndAssignToLabels(animal);
                    animalManager.Add(animal);
                }
            }
        }

        /// <summary>
        /// Add foodSchedule to UI
        /// </summary>
        /// <returns>bool if all textboxes are valid</returns>
        private void lstAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstAnimals.SelectedIndex;
            if (index == -1)
                return;

            Animal animal = animalManager.GetAnimalAt(index);

            FoodSchedule foodSchedule = animal.GetFoodSchedule();

            lstFoodSchedule.Items.Clear();
            lstFoodSchedule.Items.Add(foodSchedule.Title());

            lblEaterType.Text = foodSchedule.EaterType.ToString();
            string[] foodList = foodSchedule.GetFoodListInfoStrings();

            lstFoodSchedule.Items.Clear();
            lstFoodSchedule.Items.AddRange(foodList);

            lblCategory.Text = animal.GetExtraInfo();
        }


        /// <summary>
        /// Validate insects textboxes
        /// </summary>
        /// <returns>bool if all textboxes are valid</returns>
        private bool ValidateInsect()
        {
            System.Diagnostics.Debug.WriteLine("Insect validera");

            lblOutput1.Text = "AntennaType";
            lblOutput2.Text = "NumberOfLegs";

            string valueNumberOfLegs = textBox2.Text;
            System.Diagnostics.Debug.WriteLine("Insect legs" + valueNumberOfLegs);
            if (int.TryParse(valueNumberOfLegs, out int result))
            {
                if (result <= 0)
                {
                    MessageBox.Show("numberOfLegs must be a positive integer.", "Validation Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for numberOfLegs.", "Validation Error");
                return false;
            }


            switch (lblSpecies.SelectedItem.ToString())
            {
                case "Butterflies":
                    lblOutput3.Text = "hasWings";
                    lblOutput4.Text = "WingPattern";

                    string valueHasWings = textBox3.Text;
                    if (!bool.TryParse(valueHasWings, out bool resultHasWings))
                    {
                        MessageBox.Show("HasWings must be either 'true' or 'false'.", "Validation Error");
                        return false;
                    }
                    break;
                case "Ants":
                    lblOutput3.Text = "LifespanIndays ";
                    lblOutput4.Text = "Neck Strength";

                    string valuelifespanIndays = textBox3.Text;
                    if (int.TryParse(valuelifespanIndays, out int resultLifespanIndays))
                    {
                        if (resultLifespanIndays <= 0)
                        {
                            MessageBox.Show("lifespanIndays must be a positive integer.", "Validation Error");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer for lifespanIndays.", "Validation Error");
                        return false;
                    }

                    string valueNeckStrength = textBox4.Text;
                    if (int.TryParse(valueNeckStrength, out int resultNeckStrength))
                    {
                        if (resultNeckStrength <= 0)
                        {
                            MessageBox.Show("NeckStrength must be a positive integer.", "Validation Error");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer for neckStrength.", "Validation Error");
                        return false;
                    }

                    break;
            }


            return true;
        }
        /// <summary>
        /// Validate bird textboxes
        /// </summary>
        /// <returns>bool if all textboxes are valid</returns>
        private bool ValidateBird()
        {
            System.Diagnostics.Debug.WriteLine("Insect validera");

            lblOutput1.Text = "feathers_color";
            lblOutput2.Text = "wingspan";

            string valueWingspan = textBox2.Text;
            if (float.TryParse(valueWingspan, out float resultWingspan))
            {
                if (resultWingspan <= 0)
                {
                    MessageBox.Show("Wingspan must be a positive float number.", "Validation Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid float number for wingspan.", "Validation Error");
                return false;
            }
            switch (lblSpecies.SelectedItem.ToString())
            {
                case "Eagles":
                    lblOutput3.Text = "huntingSkill";
                    lblOutput4.Text = "flyingSpeed";
                    string valueFlyingSpeed = textBox4.Text;
                    if (int.TryParse(valueFlyingSpeed, out int resultFlyingSpeed))
                    {
                        if (resultFlyingSpeed <= 0)
                        {
                            MessageBox.Show("FlyingSpeed must be a positive integer.", "Validation Error");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer for flyingSpeed.", "Validation Error");
                        return false;
                    }
                    break;
                case "Parrot":
                    lblOutput3.Text = "beakType";
                    lblOutput4.Text = "numberOfToes";
                    string valuenumberOfToes = textBox4.Text;
                    if (int.TryParse(valuenumberOfToes, out int resultNumberOfToes))
                    {
                        if (resultNumberOfToes <= 0)
                        {
                            MessageBox.Show("Number of toes must be a positive integer.", "Validation Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer for the number of toes.", "Validation Error");
                    }
                    break;
            }

            return true;
        }
        /// <summary>
        /// Validate fish textboxes
        /// </summary>
        /// <returns>bool if all textboxes are valid</returns>
        private bool ValidateFish()
        {
            System.Diagnostics.Debug.WriteLine("Insect validera");

            lblOutput1.Text = "scaleColor";
            lblOutput2.Text = "isSaltwater";

            string valueIsSaltwater = textBox3.Text;
            if (!bool.TryParse(valueIsSaltwater, out bool resultIsSaltwater))
            {
                MessageBox.Show("isSaltwater must be either 'true' or 'false'.", "Validation Error");
                return false;
            }

            switch (lblSpecies.SelectedItem.ToString())
            {
                case "Eel":
                    lblOutput3.Text = "isElectric";
                    lblOutput4.Text = "maxLength";

                    string valueIsElectric = textBox3.Text;
                    if (!bool.TryParse(valueIsElectric, out bool resultIsElectric))
                    {
                        MessageBox.Show("isSaltwater must be either 'true' or 'false'.", "Validation Error");
                        return false;
                    }

                    string valuemaxLength = textBox4.Text;
                    if (int.TryParse(valuemaxLength, out int resultMaxLength))
                    {
                        if (resultMaxLength <= 0)
                        {
                            MessageBox.Show("MaxLength must be a positive integer.", "Validation Error");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer for maxLength.", "Validation Error");
                        return false;
                    }

                    break;
                case "Monkfish":
                    lblOutput3.Text = "hasAnglerLight";
                    lblOutput4.Text = "habitatDepth";

                    string valuehasAnglerLight = textBox3.Text;
                    if (!bool.TryParse(valuehasAnglerLight, out bool resultHasAnglerLight))
                    {
                        MessageBox.Show("hasAnglerLight must be either 'true' or 'false'.", "Validation Error");
                        return false;
                    }
                    string valuHabitatDepth = textBox4.Text;
                    if (int.TryParse(valuHabitatDepth, out int resultHabitatDepth))
                    {
                        if (resultHabitatDepth <= 0)
                        {
                            MessageBox.Show("habitatDepth must be a positive integer.", "Validation Error");
                            return false;
                        }
                    }
                    break;
            }
            return true;
        }

        /// <summary>
        /// Create Insect
        /// </summary>
        /// <returns>Insect</returns>
        private Insect CreateInsect()
        {
            Insect insect;
            switch (lblSpecies.SelectedItem.ToString())
            {
                case "Butterflies":
                    Butterflies butterfly = new Butterflies();
                    butterfly.HasWings = bool.Parse(textBox3.Text);
                    butterfly.WingPattern = textBox4.Text;
                    butterfly.SetFoodSchedule();
                    butterfly.species = Species.Butterflies;
                    insect = butterfly;
                    break;
                case "Ants":
                    Ants ants = new Ants();
                    ants.LifespanIndays = int.Parse(textBox3.Text);
                    ants.NeckStrength = textBox4.Text;
                    ants.SetFoodSchedule();
                    ants.species = Species.Ants;
                    insect = ants;
                    break;

                default:
                    throw new InvalidOperationException("Unknown insect species selected.");
            }
            insect.AntennaType = textBox1.Text;
            insect.NumberOfLegs = int.Parse(textBox2.Text);
            insect.Category = Category.Insect;

            return insect;
        }
        /// <summary>
        /// Create Bird
        /// </summary>
        /// <returns>Bird</returns>
        private Bird CreateBird()
        {
            Bird bird;

            switch (lblSpecies.SelectedItem.ToString())
            {
                case "Eagles":
                    Eagles eagle = new Eagles();
                    eagle.huntingSkill = textBox3.Text;
                    eagle.flyingSpeed = float.Parse(textBox4.Text);
                    eagle.SetFoodSchedule();
                    eagle.species = Species.Eagles;
                    bird = eagle;
                    break;

                case "Parrot":
                    Parrot parrot = new Parrot();
                    parrot.BeakType = textBox3.Text;
                    parrot.NumberOfToes = int.Parse(textBox4.Text);
                    parrot.SetFoodSchedule();
                    parrot.species = Species.Parrot;
                    bird = parrot;
                    break;

                default:
                    throw new InvalidOperationException("Unknown bird species selected.");
            }

            bird.Feathers_color = textBox1.Text;
            bird.Wingspan = float.Parse(textBox2.Text);
            bird.Category = Category.Bird;


            return bird;
        }

        /// <summary>
        /// Create Fish
        /// </summary>
        /// <returns>Fish</returns>
        private Fish CreateFish()
        {
            Fish fish;
            switch (lblSpecies.SelectedItem.ToString())
            {
                case "Eel":
                    Eel eel = new Eel();
                    eel.IsElectric = bool.Parse(textBox3.Text);
                    eel.MaxLength = int.Parse(textBox4.Text);
                    eel.SetFoodSchedule();
                    eel.species = Species.Eel;
                    fish = eel;
                    break;
                case "Monkfish":
                    MonkFish monkFish = new MonkFish();
                    monkFish.HasAnglerLight = bool.Parse(textBox3.Text);
                    monkFish.HabitatDepth = textBox4.Text;
                    monkFish.SetFoodSchedule();
                    monkFish.species = Species.Monkfish;
                    fish = monkFish;
                    break;
                default:
                    throw new InvalidOperationException("Unknown fish species selected.");
            }
            fish.ScaleColor = textBox1.Text;
            fish.IsSaltwater = bool.Parse(textBox2.Text);
            fish.Category = Category.Fish;

            return fish;
        }

        /// <summary>
        /// Display values for animal based on the selected species
        /// </summary>
        /// <param name="animal"></param>
        private void CheckInputIsValidAndAssignToLabels(Animal animal)
        {
            Bird bird = animal as Bird;
            Eagles eagle = animal as Eagles;
            Parrot parrot = animal as Parrot;

            Insect insect = animal as Insect;
            Ants ant = animal as Ants;
            Butterflies butterflies = animal as Butterflies;

            Fish fish = animal as Fish;
            MonkFish monkFish = animal as MonkFish;
            Eel eel = animal as Eel;

            // Display values for birds based on the selected species
            if (animal.Category.ToString() == "Bird")
            {
                lblSpeciesbox1.Text = bird.Feathers_color;
                lblSpeciesbox2.Text = bird.Wingspan.ToString();

                if (animal.species.ToString() == "Eagles")
                {
                    lblSpeciesbox3.Text = eagle.huntingSkill;
                    lblSpeciesbox4.Text = eagle.flyingSpeed.ToString();
                }

                if (animal.species.ToString() == "Parrot")
                {
                    lblSpeciesbox3.Text = parrot.BeakType;
                    lblSpeciesbox4.Text = parrot.NumberOfToes.ToString();
                }
            }
            // Display values for Insects based on the selected species
            if (animal.Category.ToString() == "Insect")
            {
                lblSpeciesbox1.Text = insect.AntennaType;
                lblSpeciesbox2.Text = insect.NumberOfLegs.ToString();

                if (animal.species.ToString() == "Ants")
                {
                    lblSpeciesbox3.Text = ant.LifespanIndays.ToString();
                    lblSpeciesbox4.Text = ant.NeckStrength;
                }

                if (animal.species.ToString() == "Butterflies")
                {
                    lblSpeciesbox3.Text = butterflies.HasWings.ToString();
                    lblSpeciesbox4.Text = butterflies.WingPattern;
                }
            }

            // Display values for Fish based on the selected species
            if (animal.Category.ToString() == "Fish")
            {
                lblSpeciesbox1.Text = fish.ScaleColor;
                lblSpeciesbox2.Text = fish.IsSaltwater.ToString();

                if (animal.species.ToString() == "Eel")
                {
                    lblSpeciesbox3.Text = eel.IsElectric.ToString();
                    lblSpeciesbox4.Text = eel.MaxLength.ToString();
                }

                if (animal.species.ToString() == "Monkfish")
                {
                    lblSpeciesbox3.Text = monkFish.HasAnglerLight.ToString();
                    lblSpeciesbox4.Text = monkFish.HabitatDepth.ToString();
                }
            }
        }

        /// <summary>
        /// Method to validate the text box inputs for emptiness
        /// </summary>
        /// <returns> true or false</returns>
        private bool ValidateTextBoxes()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Field 1 cannot be empty. Please enter a value.", "Validation Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Field 2 cannot be empty. Please enter a value.", "Validation Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Field 3 cannot be empty. Please enter a value.", "Validation Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Field 4 cannot be empty. Please enter a value.", "Validation Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty. Please enter a valid name.", "Validation Error");
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age must be a valid number.", "Validation Error");
                return false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Validation Error");
                return false;
            }
            else if (!Enum.TryParse(cmbGender.SelectedItem.ToString(), out GenderType gender))
            {
                MessageBox.Show("Selected gender is invalid. Please select a valid gender.", "Validation Error");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Method to assign common properties to an animal object
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        private void AssignAnimalProperties(Animal animal)
        {
            animal.name = txtName.Text;

            animal.age = int.Parse(txtAge.Text);

            animal.gender = (GenderType)Enum.Parse(typeof(GenderType), cmbGender.SelectedItem.ToString());

            animal.Id = animalManager.GetNewID(animal.Category);

            if (checkBoxDomesticated.Checked)
            {
                lblDomesticeted.Text = "True";
            }
            else
            {
                lblDomesticeted.Text = "False";
            }

            string animalInfo = string.Format("{0,-5} {1,-15} Age: {2,-3} Gender: {3}",
                                       "ID: " + animal.Id, "Name: " + animal.name, animal.age, animal.gender);

            lstAnimals.Items.Add(animalInfo);
        }
        /// <summary>
        /// Method to generate a random 5-character ID
        /// </summary>
        /// <returns></returns>
        private string GenerateRandomID()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";  // Letters and numbers
            string randomId = new string(Enumerable.Range(0, 5)
                                                  .Select(_ => chars[random.Next(chars.Length)])
                                                  .ToArray());
            return randomId;
        }

        private void UpdateLabels(Animal animal)
        {
            if (animal.species.ToString() == "Eagles")
            {
                lblOutput1.Text = "feathers_color";
                lblOutput2.Text = "wingspan";
                lblOutput3.Text = "huntingSkill";
                lblOutput4.Text = "flyingSpeed";

            }
            else if (animal.species.ToString() == "Parrot")
            {
                lblOutput1.Text = "feathers_color";
                lblOutput2.Text = "wingspan";
                lblOutput3.Text = "beakType";
                lblOutput4.Text = "number of toas";
            }
            else if (animal.species.ToString() == "Ants")
            {
                lblOutput1.Text = "Anntena type";
                lblOutput2.Text = "NumberOfLegs";
                lblOutput3.Text = "LifespanIndays";
                lblOutput4.Text = "Neck Strength";
            }
            else if (animal.species.ToString() == "Butterflies")
            {
                lblOutput1.Text = "Anntena type";
                lblOutput2.Text = "NumberOfLegs";
                lblOutput3.Text = "hasWings";
                lblOutput4.Text = "WingPattern";
            }
            else if (animal.species.ToString() == "Eel")
            {
                lblOutput1.Text = "scalecolor";
                lblOutput2.Text = "IsSaltwater";
                lblOutput3.Text = "IsElectric";
                lblOutput4.Text = "MaxLength";

            }
            else if (animal.species.ToString() == "Monkfish")
            {
                lblOutput1.Text = "Scalecolor";
                lblOutput2.Text = "IsSaltwater";
                lblOutput3.Text = "HasAnglerLight";
                lblOutput4.Text = "HabitatDepth";
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategory.SelectedItem == null) return;

            lblSpecies.Items.Clear();
            string selectedCategory = lbCategory.SelectedItem.ToString();

            switch (selectedCategory)
            {
                case "Bird":
                    lblSpecies.Items.Add(Species.Eagles.ToString());
                    lblSpecies.Items.Add(Species.Parrot.ToString());
                    break;
                case "Insect":
                    lblSpecies.Items.Add(Species.Ants.ToString());
                    lblSpecies.Items.Add(Species.Butterflies.ToString());
                    break;
                case "Fish":
                    lblSpecies.Items.Add(Species.Eel.ToString());
                    lblSpecies.Items.Add(Species.Monkfish.ToString());
                    break;
            }

            if (lblSpecies.Items.Count > 0)
                lblSpecies.SelectedIndex = 0;
        }
        //Event handler for Species selection change - updates secound species list in upper right corner
        private void lblSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblSpecies.SelectedItem.ToString() == "Eagles")
            {
                lblInpusInfo1.Text = "feathers_color";
                lblInpusInfo2.Text = "wingspan";
                lblInpusInfo3.Text = "huntingSkill";
                lblInpusInfo4.Text = "flyingSpeed";

            }
            else if (lblSpecies.SelectedItem.ToString() == "Parrot")
            {
                lblInpusInfo1.Text = "feathers_color";
                lblInpusInfo2.Text = "wingspan";
                lblInpusInfo3.Text = "beakType";
                lblInpusInfo4.Text = "number of toas";
            }
            else if (lblSpecies.SelectedItem.ToString() == "Ants")
            {
                lblInpusInfo1.Text = "Anntena type";
                lblInpusInfo2.Text = "NumberOfLegs";
                lblInpusInfo3.Text = "LifespanIndays";
                lblInpusInfo4.Text = "Neck Strength";
            }
            else if (lblSpecies.SelectedItem.ToString() == "Butterflies")
            {
                lblInpusInfo1.Text = "Anntena type";
                lblInpusInfo2.Text = "NumberOfLegs";
                lblInpusInfo3.Text = "hasWings";
                lblInpusInfo4.Text = "WingPattern";
            }
            else if (lblSpecies.SelectedItem.ToString() == "Eel")
            {
                lblInpusInfo1.Text = "scalecolor";
                lblInpusInfo2.Text = "IsSaltwater";
                lblInpusInfo3.Text = "IsElectric";
                lblInpusInfo4.Text = "MaxLength";

            }
            else if (lblSpecies.SelectedItem.ToString() == "Monkfish")
            {
                lblInpusInfo1.Text = "Scalecolor";
                lblInpusInfo2.Text = "IsSaltwater";
                lblInpusInfo3.Text = "HasAnglerLight";
                lblInpusInfo4.Text = "HabitatDepth";
            }
        }

        private void lblInpusInfo1_Click(object sender, EventArgs e)
        {

        }

        private void lstAnimals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lstAnimals_SelectedIndexChanged(lstAnimals, e);

            int index = lstAnimals.SelectedIndex;
            if (index == -1)
                return;

            Animal animal = animalManager.GetAnimalAt(index);
            lblCategory.Text = animal.GetExtraInfo();

            CheckInputIsValidAndAssignToLabels(animal);

            UpdateLabels(animal);

        }

        private void lstFoodSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FoodForm newForm = new FoodForm(this);
            newForm.Show();
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            animalManager.SaveToFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            animalManager.LoadFromFile();


            //lstAnimals = animalManager.GetAnimalInfoStrings();
            string formattedEntry = $"Animals: {string.Join(", ", animalManager.GetAnimalInfoStrings())}";

            //string animalInfo = string.Format("{0,-5} {1,-15} Age: {2,-3} Gender: {3}",
            //                           "ID: " + animalManager.animal.Id, "Name: " + animal.name, animal.age, animal.gender);
            //MessageBox.Show(animalManager.GetAnimalInfoStrings()[0]);

            string[] pelle = animalManager.GetAnimalInfoStrings()[0].Split(", ");

            if (pelle.Length >= 4)
            {
                string animalInfo = string.Format("{0,-5} {1,-15} Age: {2,-3} Gender: {3}",
                                          "ID: " + pelle[0], "Name: " + pelle[1], pelle[2], pelle[3]);

                this.lstAnimals.Items.Add(animalManager.GetAnimalInfoStrings()[0]);
                //MessageBox.Show(pelle[1]);
            }


            //string animalInfo = string.Format("{0,-5} {1,-15} Age: {2,-3} Gender: {3}",
            //"ID: " +pelle[0], "Name: " + pelle[0], pelle[0], pelle[3]);
            // this.lstAnimals.Items.Add(animalManager.GetAnimalInfoStrings()[0]);
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
