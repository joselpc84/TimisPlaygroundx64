// ping-pong animate background color
using UnityEngine;
using System.Collections;

public class TweenColorCamera : MonoBehaviour {
	public Color color1 = new Color(0.0f,0.0f,0.0f);
	public Color color2 = new Color(76.0f,226.0f,214.0f);
	public float rate = 0.01f;
	public bool isTweenEnabled = false;
	
	Camera camera;
	
	void Start() {
		camera = GetComponent<Camera>();
		camera.clearFlags = CameraClearFlags.SolidColor;
		isTweenEnabled = GameObject.Find("SceneManagerIntro").GetComponent<SceneManagerIntro>().isTweenEnabled;
		//camera.backgroundColor = Color.Lerp(color1, color2, 0.5f);
		
	}
	
	void Update() {
		//float t = Mathf.PingPong(Time.time, duration) / duration;
		if (isTweenEnabled && rate <= 1.0f)
		{
			rate += 0.01f;
			camera.backgroundColor = Color.Lerp(color1, color2, rate);
		}
		else if(rate > 1.0f)
		{
			isTweenEnabled = false;
			GameObject.Find("SceneManagerIntro").GetComponent<SceneManagerIntro>().isTweenEnabled = false;
		}
	}
}
