 using UnityEngine;
using System.Collections;
using FMOD.Studio;

public class FMOD_Oneoff : MonoBehaviour {

	[SerializeField] public bool _bPlaySound = true;
	[SerializeField] private FMODAsset _soundAsset;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
		if (_bPlaySound == true){
			_bPlaySound = false;
			FMOD_StudioSystem.instance.PlayOneShot(_soundAsset, transform.position);
		}
	
	}
}
