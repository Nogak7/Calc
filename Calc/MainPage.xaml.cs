namespace Calc;

public partial class MainPage : ContentPage
{
	double clickedNum = 0;
	int count = 0;
	double clickedNum2 = 0;
	string happend = "";
	bool doti = false;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

	private void per_Clicked(object sender, EventArgs e)
	{

	}

	private void ac_Clicked(object sender, EventArgs e)
	{
		resolt.Text = "";
		clickedNum = 0;
		clickedNum2 = 0;
	}
    private void Num_Clicked(object sender, EventArgs e)
    {
		Button num = (Button)sender;
        if (clickedNum != 0)
        {
            if (doti)
            {
                resolt.Text = "";
                clickedNum = clickedNum * 10 + double.Parse(num.Text);
                resolt.Text += clickedNum.ToString();
                clickedNum = clickedNum2 + clickedNum / 10;
                resolt.Text = clickedNum.ToString();
                doti = false;
            }
            else
            {
                resolt.Text = "";
                clickedNum = clickedNum * 10 + double.Parse(num.Text);
                resolt.Text += clickedNum.ToString();
            }
        }
        if (clickedNum == 0)
		{
			if (doti)
			{

				clickedNum =  double.Parse(num.Text);
				resolt.Text += clickedNum.ToString();
				clickedNum = clickedNum2 + clickedNum / 10;
				resolt.Text = clickedNum.ToString();
				doti = false;
			}
			else
			{
				clickedNum =  double.Parse(num.Text);
				resolt.Text += clickedNum.ToString();
			}
		}
        
    }



	private void div_Clicked(object sender, EventArgs e)
	{
		
	}

	private void mul_Clicked(object sender, EventArgs e)
	{

	}

	private void sub_Clicked(object sender, EventArgs e)
	{
		Button num = (Button)sender;
        if (happend == "add")
		{
			double resolti = clickedNum2 + clickedNum;
			resolt.Text = $"{resolti}";
		}
		
		
	}

	private void add_Clicked(object sender, EventArgs e)
	{
		happend = "add";
        Button num = (Button)sender;
		clickedNum2 = clickedNum;
		resolt.Text = "";
		clickedNum = 0;
	}

	private void dot_Clicked(object sender, EventArgs e)
	{
		doti = true;
        clickedNum2 = clickedNum;
        clickedNum = 0;
        
    }
}

