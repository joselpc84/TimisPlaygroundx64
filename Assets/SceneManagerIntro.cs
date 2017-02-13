using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerIntro : MonoBehaviour {

	public Camera mainCamera;
	public Transform intro;
	public Transform memoria;
	public Transform flechaDer;
	public Transform flechaIzq;


	// Use this for initialization
	void Start () {
		memoria.gameObject.SetActive(false);
		flechaDer.gameObject.SetActive(false);
		flechaIzq.gameObject.SetActive(false);
		StartCoroutine(InitTween());

	}
	
	// Update is called once per frame
	void Update () {

		if(intro.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 0.75f)
		{
			memoria.gameObject.SetActive(true);
			flechaDer.gameObject.SetActive(true);

		}

		//Debug.Log(intro.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Intro"));
		//Debug.Log(intro.GetComponent<Animator>().);
		/*
		if(intro.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Intro") && GlobalVar.introAnimFinished == false)
		{
			intro.GetComponent<Animator>().SetBool("IntroAnimFinished", true);
			GlobalVar.introAnimFinished = true;
		}
		if(GlobalVar.introAnimFinished == true)
		{
			memoria.gameObject.SetActive(true);
		}
		*/
	}

	IEnumerator InitTween(){

		yield return new WaitForSeconds(1.9f);

	}
}
