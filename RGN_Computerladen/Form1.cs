using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RGN_Computerladen.ShopItems;

namespace RGN_Computerladen
{
    public partial class frmMainWindow : Form
    {
        // Ein paar Variablen für später...
        private List<ShopItem> shopItems = null;
        private List<PackageItem> packageItems = null;
        private double packageDiscount = 0;

        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            initializeShopItems();
            initializePackageItems();

            // Standardmäßig sind die Komponenten nicht frei wählbar.
            // Erst nach betätigen der Checkbox
            lvwShopItems.Enabled = false;


            // Da ich nur 2 Pakete habe, habe ich Buttons mit schönen Beschreibungen
            // dafür gemacht anstatt eine weitere ListView
            btAioGamingPC.Text = packageItems[0].name;
            btAioExpertPC.Text = packageItems[1].name;
        }

        private void initializeShopItems()
        {
            // JSON File mit Shop Items auslesen und in oben definierte Variable packen
            string json = new StreamReader("ShopItemData\\ShopItemData.json").ReadToEnd();
            shopItems = JsonConvert.DeserializeObject<List<ShopItem>>(json);

            // DataTable mit 2 Spalten erstellen um es später in eine ListView zu stecken
            DataTable dt = new DataTable();
            dt.Columns.Add("Artikel");
            dt.Columns.Add("Preis");
            dt.Columns.Add("Anzahl");

            // DataTable mit Werten aus JSON Files befüllen...
            for (int i = 0; i < shopItems.Count(); i++)
            {
                DataRow dr = dt.NewRow();
                if (shopItems[i].type.Equals("Product"))
                {
                    dr["Artikel"] = shopItems[i].name;
                    dr["Preis"] = "€ " + shopItems[i].price;
                }
                else if (shopItems[i].type.Equals("Service"))
                {
                    dr["Artikel"] = shopItems[i].name + " ("+shopItems[i].estimatedWorkingHours+"h)";
                    dr["Preis"] = "€ " + shopItems[i].price + "/h";
                }
                //dr["Anzahl"] = shopItems[i].estimatedWorkingHours;
                dt.Rows.Add(dr);
            }

            // Sollte zwar leer sein, aber vor dem befüllen erst mal ListView leeren
            lvwShopItems.Items.Clear();

            // ListView auffüllen mit Werten aus DataTable
            for (int i = 0; i<shopItems.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Artikel"].ToString());
                listitem.SubItems.Add(dr["Preis"].ToString());
                listitem.SubItems.Add("0");
                lvwShopItems.Items.Add(listitem);
            }

        }

        private void initializePackageItems()
        {
            // JSON File mit Package Items auslesen und in oben definierte Variable packen
            string json = new StreamReader("ShopItemData\\PackageItemData.json").ReadToEnd();
            packageItems = JsonConvert.DeserializeObject<List<PackageItem>>(json);
        }

        private void addToShoppingList(int selectedItem)
        {
            // SubItem 2 = Anzahl in der ListView
            ListViewItem.ListViewSubItem lvwItem = lvwShopItems.Items[selectedItem].SubItems[2];
            if (lvwItem.Text.Equals("1")) {
                lvwItem.Text = "0";
            } else if (lvwItem.Text.Equals("0")) {
                lvwItem.Text = "1";
            }


            updatePrice();
        }

        private void clearShoppingList()
        {
            for(int i =0;i<lvwShopItems.Items.Count;i++)
            {
                // SubItem 2 (Anzahl) überall auf 0 setzen
                lvwShopItems.Items[i].SubItems[2].Text = "0";
            }
            updateDiscount(false);
            updatePrice();
            
        }

        private void lvwShopItems_DoubleClick(object sender, EventArgs e)
        {
            // Ein Doppelklick auf ein Listenobjekt legt es in den Warenkorb
            addToShoppingList(lvwShopItems.SelectedIndices[0]);
        }

        // Aktuell ist dieser Button immer PackageItem 0
        private void btAioGamingPC_Click(object sender, EventArgs e)
        {
            clearShoppingList();
            selectPackage(0);
        }

        // Aktuell ist dieser Button immer PackageItem 0
        private void btAioExpertPC_Click(object sender, EventArgs e)
        {
            clearShoppingList();
            selectPackage(1);
        }

        private void selectPackage(int packageId)
        {
            // Rabatt setzen, da Pakete immer 10% Rabatt erhalten
            updateDiscount(true);
            for (int i = 0; i < packageItems[packageId].items.Count; i++)
            {
                // Jedes Item aus der packateItems item Liste auf der UI anchecken
                addToShoppingList(Convert.ToInt32(packageItems[packageId].items[i]));
            }
            // SelbstConfig deaktivieren
            cbSelfConfig.CheckState = CheckState.Unchecked;
        }

        private void cbSelfConfig_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelfConfig.Checked == true)
            {
                // Rabatt deaktivieren sobald CheckBox abgecheckt wird
                updateDiscount(false);
                // Preis updaten, da Rabatt nun weg ist
                updatePrice();
                // ListView aktivieren
                lvwShopItems.Enabled = true;
                // Shopping Liste leeren oder nicht? --> Reset Button eingefügt
                //clearShoppingList();
            }
            else if (cbSelfConfig.Checked == false)
            {
                lvwShopItems.Enabled = false;
            }
        }

        private void updatePrice()
        {
            double newPrice = 0;

            for (int i = 0; i < lvwShopItems.Items.Count; i++)
            {
                // Wenn min. 1 Item im Warenkorb ist
                if (Convert.ToInt32(lvwShopItems.Items[i].SubItems[2].Text) > 0)
                {
                    // Wenn es ein Produkt ist, dann Anzahl * Preis
                    if (shopItems[i].type.Equals("Product"))
                    {
                        newPrice += Convert.ToInt32(shopItems[i].price) *
                            Convert.ToInt32(lvwShopItems.Items[i].SubItems[2].Text);
                    }
                    // Wenn es eine Dienstleistung ist, dann Anzahl * Preis * Stunden
                    else if (shopItems[i].type.Equals("Service"))
                    {
                        newPrice += Convert.ToInt32(shopItems[i].price) *
                            Convert.ToInt32(lvwShopItems.Items[i].SubItems[2].Text) *
                            Convert.ToInt32(shopItems[i].estimatedWorkingHours);
                    }
                }
            }

            // Rabatt mitberechnen
            newPrice = newPrice * (1.0 - packageDiscount);

            // Preis in Textbox updaten
            tbFullPrice.Text = newPrice.ToString();
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            if(tbFullPrice.Text.Length>0)
            {
                MessageBox.Show("Sie haben um €" + tbFullPrice.Text + " bei uns eingekauft.\r\nAuf Wiedersehen!");
                Close();
            } else
            {
                MessageBox.Show("Sie haben noch nichts im Warenkorb!");
            }
        }

        private void updateDiscount(bool discountActive)
        {
            // Aktuell gibt es nur Discount 10% oder 0% ...
            // daher reicht ein bool fürs ein/ausschalten
            if (discountActive)
            {
                packageDiscount = 0.1;
                lblDiscount.Text = "Rabatt: 10%";
            }
            else
            {
                packageDiscount = 0;
                lblDiscount.Text = "Rabatt: 0%";
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            clearShoppingList();
        }
    }
}
