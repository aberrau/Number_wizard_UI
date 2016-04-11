using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public void LoadLevel(string name)
	{
		Debug.Log ("Level selected: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest()
	{
		Debug.Log ("Quited requested");
		Application.Quit();
	}
}
