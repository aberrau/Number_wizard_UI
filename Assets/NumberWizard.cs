using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NumberWizard : MonoBehaviour
{
	int max;
	int min;
	int guess;
	public int counter;
	public Text textbox;
	
	void Start ()
	{
	Startgame();
	}
	
	
	void Startgame ()
	{
		this.max = 1000;
		this.min = 1;
		this.guess = 500;
		this.max = max + 1;
		this.textbox.text = guess.ToString();
	}
	
	
	void Nextguess()
	{
		guess = (min + max)/2;
		counter +=1;
		if (counter <= 5)
		{
			textbox.text = guess.ToString();
		}
		else
		{
			Application.LoadLevel("Win");
		}
	}
	
	
	public void higher()
	{
		min = guess;
		Nextguess ();
	}


	public void lower()
	{
		max = guess;
		Nextguess ();
	}
	
	
}
