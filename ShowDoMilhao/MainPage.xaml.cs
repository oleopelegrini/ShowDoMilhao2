namespace ShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = App.getRandomPerguntaFacil();

            lbl_nivel.Text = "Fácil";
            lbl_premio.Text = premio.ToString("C");
            lbl_pergunta_numero.Text = pergunta_count.ToString();
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_Proxima(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked) 
            {
            if ( (bool) alt0.Value)
               {
                acertou = true;
                resp = alt0.Content.ToString();
        }
    }
            if (alt1.IsChecked)
            {
                if ( (bool) alt1.Value)
                {  
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }

            if (alt2.IsChecked)
            {
                if ((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }
            if (alt3.IsChecked)
            {
                if ((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt3.Content.ToString();
                }
            }

            if (acertou)
            {
                DisplayAlert("Acertou!", resp, "OK");
                this.BindingContext = App.getRandomPerguntaFacil();
            }

            private void toca_som()
            {
                string track = "";
                switch (pergunta_count)
                {
                    case 1:
                        track = "1000.nav";
                        break;
                    case 2:
                        track = "2000.nav";
                        break;
                    case 3:
                        track = "3000.nav";
                        break;
                    case 4:
                        track = "4000.nav";
                        break;
                    case 5:
                        track = "5000.nav";
                        break;
                    case 6:
                        track = "10000.nav";
                        break;
                    case 7:
                        track = "20000.nav";
                        break;
                    case 8:
                        track = "30000.nav";
                        break;
                    case 9:
                        track = "40000.nav";
                        break;
                    case 10:
                        track = "50000.nav";
                        break;
                    case 11:
                        track = "100000.nav";
                        break;
                    case 12:
                        track = "200000.nav";
                        break;
                    case 13:
                        track = "300000.nav";
                        break;
                    case 14:
                        track = "400000.nav";
                        break;
                    case 15:
                        track = "500000.nav";
                        break;
                }
            }

            } if ()

