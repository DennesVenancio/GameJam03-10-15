using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HomeActions : MonoBehaviour {

	public Button play;
	public Button sound;
	public Button info;
	public Button exit;


	// Use this for initialization
	void Start () {
		play.onClick.AddListener(() => { playAction();});
		sound.onClick.AddListener(() => { soundAction();});
		info.onClick.AddListener(() => { infoAction();});
		exit.onClick.AddListener(() => { exitAction();});
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void playAction(){
		Application.LoadLevel ("Level1");
	}

	private void soundAction(){

	}

	private void infoAction(){

	}

	private void exitAction(){

	}
}
