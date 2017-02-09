using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print (SceneManager.GetActiveScene ().buildIndex + " start");
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.Space)) 
		{
			LoadNextScene ();
		}
		*/
	}

	public void LoadNextScene()
	{
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
		print ("next scene called");
	}

	public void LoadPreviousScene()
	{
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);
	}
}
