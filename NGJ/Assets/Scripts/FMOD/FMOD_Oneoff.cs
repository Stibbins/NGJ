 using UnityEngine;
using System.Collections;
using FMOD.Studio;

public class FMOD_Oneoff : MonoBehaviour {

	[SerializeField] public bool _bPlaySound = true;
	[SerializeField] private FMOD.Studio.EventInstance _soundEvent;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
		if (_bPlaySound == true){
			FMOD_StudioSystem.instance.PlayOneShot(_soundEvent, transform.position)
		}
	
	}
}
