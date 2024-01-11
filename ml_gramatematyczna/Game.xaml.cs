namespace ml_gramatematyczna;

public partial class Game : ContentPage
{
	string znaki;
	int max, wynik, good, bad, cIndex;
    public Game(int reps, int level, bool dod, bool ode, bool dzi, bool mno)
	{
		InitializeComponent();

		cIndex = reps;

		if (dod)
			znaki += "+";
        if (ode)
            znaki += "-";
        if (dzi)
            znaki += "/";
        if (mno)
            znaki += "*";

		if (level == 1)
			max = 5;
        if (level == 2)
            max = 10;
        if (level == 3)
            max = 100; 
		repeat();

	}

	void repeat()
	{
		cIndex--;
		if(cIndex < 0)
		{
			confirmB.Text = "Koniec";
			confirmB.IsEnabled = false;
		}
		else
		{
			Random rnd = new Random();
			string wZnak = znaki[rnd.Next(0, znaki.Length)].ToString();
			sign.Text = wZnak;
			int l1 = rnd.Next(1, max+1);
            int l2 = rnd.Next(1, max+1);

            l1L.Text = l1.ToString();
	
            l2L.Text = l2.ToString();
			
			switch(wZnak)
			{
				case "+":
					wynik = l1 + l2;
					break;
                case "-":
					wynik = l1 - l2;
                    break;
                case "*":
					wynik = l1 * l2;
                    break;
                case "/":
					wynik = l1 / l2;
                    break;
            }
        }
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (string.IsNullOrEmpty(answr.Text))
			return;
		if (double.Parse(answr.Text) == wynik)
			good++;
		else
			bad++;
		goodL.Text = good.ToString();
		badL.Text = bad.ToString();
		repeat();
    }
}