using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
//todo a) Nevezze át az ablakot és eszközölje a minta szerint a következő változásokat!
- 5 DIU margó a listadoboz köré
- 10 DIU margó a "Töröl" gomb alá és felé

//todo b) A vezérlőket állítsa be a következők szerint:
- A csúszka a[150, 210] tartományból vehessen fel értéket! Alapértelmezett értéke 170
- Minden vezérlő aminek az értékét olvassa vagy amihez eseménykezelőt társít, kapjon az elnevezési konvenciónak megfelelő nevet!

//todo c) Bővítse a felületet a minta szerint!
- Vegyen fel egy újabb elválasztó vonalat!
- Vegyen fel egy új nyomógombot!
*/

namespace WpfFelmero_2Feladat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {
            if (txtVersenyzo.Text == "")
            {
                MessageBox.Show("Nem adott meg nevet!");
            }
            else if (lbNevezesek.Items.Contains(txtVersenyzo.Text))
            {
                MessageBox.Show("Ilyen névvel már szerepel adat.");
            }
            else
            {
            string ujsor = txtVersenyzo.Text + "(" + sliMagassag.Value + "cm)";
            lbNevezesek.Items.Add(ujsor);
                lblVersenyzokSzama.Content = lbNevezesek.Items.Count;

            }

        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lbNevezesek.SelectedIndex == -1)
            {
                MessageBox.Show("Előbb válasszon versenyzőt.");
            }
            else
            {
            lbNevezesek.Items.RemoveAt(lbNevezesek.SelectedIndex);
                lblVersenyzokSzama.Content = lbNevezesek.Items.Count;
            }

        }

        private void btnListaUrit_Click(object sender, RoutedEventArgs e)
        {
            lbNevezesek.Items.Clear();
            lblVersenyzokSzama.Content = lbNevezesek.Items.Count;

        }

        private void sliMagassag_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliMagassag.Value = Math.Round(sliMagassag.Value);
        }

        private void btnKekreValt_Click(object sender, RoutedEventArgs e)
        {
            //lbNevezesek.Background = Color.lightblue
        }

        //todo d) A "Felvesz" gomb a minta szerint rögzíti a listadobozba az adatokat. A magasság értékét kerekítse egészre!
        //todo h) Ha olyan nevet akar felvenni, ami már szerepel a listán, akkor figyelmeztetés után akadályozza ezt meg!
        //todo i) Ha változik a lista elemeinek száma, akkor a piros cimke értéke is változzon!

        //tod e) A "Töröl" gomb törölje a kiválasztott nevet! Ha nincs kiválasztva, akkor a minta szerint figyelmeztessen!

        //todo f) Törölje ki az egész listadoboz tartalmát!

        //todo g) A "Kékre vált" gomb hatására változtassa világoskékre a listadoboz hátterét!
    }
}
