using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace hw07
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		int score = 0;
		List<String> questions = new List<string>
		{
			"Are You Patriotic?", "Do You Enjoy Thunder Storms?", "Are you Good With The Ladies?", "Are You Under 4 Feet Tall?"
		};
		int questionNumber = 0;
		public MainPage()
		{
			InitializeComponent();
			questionLabel.Text = questions[questionNumber];
		}

		void OnSwiped(Object sender, SwipedEventArgs e)
		{
            if(e.Direction.ToString() == "Right")
            {
                qTrue();
            }
            else
            {
                qFalse();
            }

		}

   



		void true_Clicked(Object Sender, EventArgs args)
		{
            qTrue();
		}

		void false_Clicked(Object Sender, EventArgs args)
		{
            qFalse();
		}

		private void qTrue()
		{
			score++;
            next();
		}

		private void qFalse()
		{
			score--;
            next();
		}

		private void next()
		{
			if (questionNumber < questions.Count() - 1)
			{
				questionNumber++;
				questionLabel.Text = questions[questionNumber];
			}
			else
			{
				if (score >= 2)
				{
					questionLabel.Text = "You Got Captain America";
				}
				else if (score >= 1)
				{
					questionLabel.Text = "You Got Thor";
				}
				else if (score >= 0)
				{
					questionLabel.Text = "You Got Iron Man";
				}
				else if (score >= -2)
				{
					questionLabel.Text = "You Got Ant Man";
				}
                else
                {
                    questionLabel.Text = "You Got Thanos";
                }



			}




		}
	}
}
