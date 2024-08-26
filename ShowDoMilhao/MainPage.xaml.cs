namespace ShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
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

            } else
        {

