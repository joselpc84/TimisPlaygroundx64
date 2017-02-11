using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerIntro : MonoBehaviour {

	public Camera mainCamera;
	public Animator IntroAnim;
	public float waitToTween = 1.0f;
	public bool isTweenEnabled = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(InitTween());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator InitTween(){

		yield return new WaitForSeconds(waitToTween);
		isTweenEnabled = true;
	}
}
