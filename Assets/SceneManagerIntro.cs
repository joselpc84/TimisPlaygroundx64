using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerIntro : MonoBehaviour {

	public Camera mainCamera;


	// Use this for initialization
	void Start () {
		StartCoroutine(InitTween());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator InitTween(){

		yield return new WaitForSeconds(1.9f);

	}
}
