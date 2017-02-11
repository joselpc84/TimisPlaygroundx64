using UnityEngine;
using System.Collections;

public class SetAudioVolumen : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        bool isNotFirstTime = false;
        bool.TryParse(PlayerPrefs.GetString ("isNotFirstTime"),out isNotFirstTime);

        if (isNotFirstTime)
        {
            this.GetComponent<AudioSource>().volume  = PlayerPrefs.GetFloat ("bgVolume");

        }
        else
        {
            this.GetComponent<AudioSource>().volume   = 0.5f;
        }
       
	}
	
    public void AudioPlay(){
    
        if (!this.GetComponent<AudioSource>().isPlaying)
            this.GetComponent<AudioSource>().Play();
    }

    public bool isPlayOnEnable = false;
    void OnEnable(){
        if (isPlayOnEnable)
            this.GetComponent<AudioSource>().Play();
    }

}
