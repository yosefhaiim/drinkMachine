using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace drinkMachine
{
    public partial class Form1 : Form
    {
        // יצירת מסמך XML
        XmlDocument xmlDocoment;
        // הכרזה על נתיב בו ימצא הקובץ ושמו של הקובץ
        string pathName = Directory.GetCurrentDirectory() + "\\drinkData.xml";
        // הכרזת משתנה שיהיה נגיש בכל מקום
        XmlNode root;

        public Form1()
        {
            InitializeComponent();
            // קריאה לפונקציה שטוענת מסמך
            loadDocoment();
        }

        // בניית פונקציה ליצירת מסמך
        public void loadDocoment()
        {
            // הכרזה על מסמך אקסאמאל חדש  
            xmlDocoment = new XmlDocument();
           // בדיקה אם המסמך קיים בנתיב שהוגדר מראש
            if (File.Exists(pathName))
            {
                try
                {
                    // נסיון לטעון את המסמך
                    xmlDocoment.Load(pathName);
                }
                // במידה וזה נכשל מחזירים מה השגיאה
                catch (Exception ex)
                {
                    MessageBox.Show("Eror loading xml file " + ex.Message);
                }
            }
            else
            {
                // אם הוא לא קיים יוצרים אותו עכשיו, כאלמנט.
                // ומכניסים את ה"תוכן" שלו לתוך המשתנה רות
                root = xmlDocoment.CreateElement("drinks");
                // כעת אני מוסיף למסמך את האלמנט שיצרנו מה שנקרא שורש
                xmlDocoment.AppendChild(root);
                // עכשיו אני שומר את המסמך בחזרה במיקום שממנו טענתי אותו קודם
                xmlDocoment.Save(pathName);
            }
        }

        private bool CreateDrink(XmlNode root)
        {
            try
            {
                // יצירת מסמך אקסמאל
                XmlNode drink = xmlDocoment.CreateElement("drink");

                // יצירת תגית שתיקרא מה שכתוב בסוגריים,
                // עכשיו "ניים" ופעם הבאה מה שאני אשים) את שם התגית נשים בגרשיים)
               // XmlNode name = xmlDocoment.CreateElement("name");

                // הכנסת ערך לאותה התווית שיצרנו קודם את הערך אני מקבל מהטקסט נקודה משהו
                //name.InnerText = txtNewDrink.Text;

                //, הכנסת התויית לתוך מקום בזיכרון
                // שכרגע אוחז את התוכן של המסמך "דרינק",בסוף נכניס אותו למסמך האמיתי : כביכול הסבא
                //drink.AppendChild(name);


                // אפשר לעשות את זה בשורה אחת
                drink.AppendChild(xmlDocoment.CreateElement("name")).InnerText = txtNewDrink.Text;
                drink.AppendChild(xmlDocoment.CreateElement("sugar")).InnerText = cmbSugar.Text;
                drink.AppendChild(xmlDocoment.CreateElement("cofee")).InnerText = cmbCofee.Text;
                drink.AppendChild(xmlDocoment.CreateElement("cocoa")).InnerText = cmbCocoa.Text;
                drink.AppendChild(xmlDocoment.CreateElement("milk")).InnerText = cmbMilk.Text;
                drink.AppendChild(xmlDocoment.CreateElement("price")).InnerText = txtPrice.Text;

                // יצירה של המשקה ללא שמירה, השמירה מתבצעת בהמשך             
                xmlDocoment.FirstChild.AppendChild(drink);
                ShowoAllDrinks();
                MessageBox.Show("המשקה נוצר בהצלחה");

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {       
            CreateDrink(root);
        }

        private void cleanAll()
        {
            txtNewDrink.Text = "";
            foreach (Control ctr in Controls) 
            {
                if (ctr is ComboBox)  { ctr.Text = 1.ToString(); }

                if(ctr is TextBox) { ctr.Text = ""; }                                               
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            xmlDocoment.Save(pathName);
            MessageBox.Show("המשקה נשמר בהצלחה");
            ShowoAllDrinks();
            cleanAll();
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {                              
                 txtPrice.Text = (double.Parse(txtPrice.Text) + 0.5).ToString();               
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }           
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if(double.Parse(txtPrice.Text) < 0.5)
                {
                    MessageBox.Show("שדה מחיר לא חוקי");
                    return;
                }
                txtPrice.Text = (double.Parse(txtPrice.Text) - 0.5).ToString();
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
        }


        private void ShowoAllDrinks()
        {
            dgvDrinksTable.Rows.Clear();
            foreach (XmlNode drink in xmlDocoment.FirstChild.ChildNodes)
            {
                string name = "", sugar = "", cofee = "", cocoa = "", milk = "", price = "";

                foreach (XmlNode node in drink.ChildNodes)
                {
                    switch(node.Name)
                    {
                        case "name":
                            name = node.InnerText;
                            break;

                        case "sugar":
                            sugar = node.InnerText;
                        break;

                        case "cofee":
                            cofee = node.InnerText;
                            break;

                        case "cocoa":
                            cocoa = node.InnerText;
                            break;

                        case "milk":
                            milk = node.InnerText;
                            break;

                        case "price":
                            price = node.InnerText;
                            break;

                    }
                }
                dgvDrinksTable.Rows.Add(name, sugar, cofee, cocoa, milk, price);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach(XmlNode drink in xmlDocoment.FirstChild.ChildNodes)
            {
                if(drink.SelectSingleNode("name").InnerText == txtNewDrink.Text)
                {

                    drink.SelectSingleNode("sugar").InnerText = cmbSugar.Text;
                    drink.SelectSingleNode("cofee").InnerText = cmbCofee.Text;
                    drink.SelectSingleNode("cocoa").InnerText = cmbCocoa.Text;
                    drink.SelectSingleNode("milk").InnerText = cmbMilk.Text;
                    drink.SelectSingleNode("price").InnerText = txtPrice.Text;

                    MessageBox.Show("המשקה עודכן בהצלחה, לסיום לחץ על שמירה");

                    ShowoAllDrinks();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (XmlNode drink in xmlDocoment.FirstChild.ChildNodes)
            {
                if (drink.SelectSingleNode("name").InnerText == txtNewDrink.Text)
                {

                    xmlDocoment.FirstChild.RemoveChild(drink);

                    MessageBox.Show("המשקה נמחק בהצלחה, לסיום לחץ על שמירה");

                    ShowoAllDrinks();
                }
                else
                {
                    MessageBox.Show("המשקה שנבחר אינו קיים");
                }
            }
        }
    }
}
