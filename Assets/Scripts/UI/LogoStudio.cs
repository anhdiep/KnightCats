using UnityEngine;
using System.Collections;

public class LogoStudio : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		//AudioSource.PlayClipAtPoint (clip, new Vector3(5, 1, 2));;
		Invoke("LoadScene",2f);
	}
	void LoadScene()
	{
		Application.LoadLevel ("MenuGame");
	}
}
