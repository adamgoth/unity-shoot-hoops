using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

	public int scoreForHit = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		scoreKeeper.IncrementScore (scoreForHit);
	}
}
