using UnityEngine;
using System.Collections;

/**
 * Created by Muriz on 14.02.14 
 */

public class ScorePoint : MonoBehaviour {

	public AudioClip pointsound;

	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.tag == "Player") {
			Score.AddPoint();
			GetComponent<AudioSource>().PlayOneShot(pointsound);
		}
	}
}
