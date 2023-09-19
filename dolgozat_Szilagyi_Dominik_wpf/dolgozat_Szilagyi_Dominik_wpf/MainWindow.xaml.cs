using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace dolgozat_Szilagyi_Dominik_wpf
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

        List<Fuvar> fuvarok = new List<Fuvar>();

        private void Button_Click(object sender, RoutedEventArgs e) //beolvasas
        {
     
            using (StreamReader sr = new("fuvar.csv"))
            {
                sr.ReadLine().Skip(1);
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(";");
                        fuvarok.Add(new Fuvar(
                            int.Parse(sor[0]),
                            sor[1],
                            int.Parse(sor[2]),
                            double.Parse(sor[3]),
                            double.Parse(sor[4]),
                            double.Parse(sor[5]),
                            sor[6]

                   ));
                    }
                }
           
            MessageBox.Show("Sikerult");

            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //3. feladat
        {
            
            MessageBox.Show($"{fuvarok.Count()} fuvar");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //4. feladat
        {

            double bevetel = 0;
            int hanyszor = 0;

            foreach (var fuvar in fuvarok)
            {
                while (fuvar.Taxi_id==6185)
                {
                    bevetel += fuvar.Viteldij + fuvar.Borravalo;
                    hanyszor++;
                }
            }

            MessageBox.Show($"{hanyszor} fuvar alatt: {bevetel}$");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // 5.feladat
        {
            int bankkartyaval = 0;
            int keszpenz = 0;
            int vitatott = 0;
            int ingyenes = 0;
            int ismeretlen = 0;

            foreach (var fuvar in fuvarok)
            {
                switch (fuvar.Fizetes_modja)
                {
                    case ("bankkártya"):
                        bankkartyaval++;
                        break;
                    case ("készpénz"):
                        keszpenz++;
                        break;
                    case ("vitatott"):
                        vitatott++;
                        break;
                    case ("ingyenes"):
                        ingyenes++;
                        break;
                    case ("ismeretlen"):
                        ismeretlen++;
                        break;
                }
            }        

            MessageBox.Show($"bankkártya: {bankkartyaval} készpénz: {keszpenz} vitatott: {vitatott} ingyenes: {ingyenes} ismeretlen {ismeretlen}");


        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //8. feladat
        {
            foreach (var fuvar in fuvarok)
            {
                if (fuvar.Idotartam>0 && fuvar.Viteldij>0 && fuvar.Tavolsag==0)
                {
                    string writeText = fuvar.Taxi_id+fuvar.Indulas+fuvar.Idotartam+fuvar.Viteldij+fuvar.Borravalo+fuvar.Fizetes_modja ;
                    File.WriteAllText("hibak.txt", writeText, Encoding.UTF8);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
