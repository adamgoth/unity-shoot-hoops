using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DetectScoring : MonoBehaviour {

	public int scoreForHit = 1;

	// Use this for initialization
	void Start () {
		// Load Scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		// Load currentIndex + 1
		SceneManager.LoadScene(currentIndex + 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		scoreKeeper.IncrementScore (scoreForHit);
	}
}
