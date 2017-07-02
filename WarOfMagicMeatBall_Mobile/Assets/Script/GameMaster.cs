using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {
	

	MySceneManager mySceneManager = new MySceneManager ();

   
    void Awake(){
        DontDestroyOnLoad(this.gameObject);
      
        mySceneManager = new MySceneManager();
		mySceneManager.OnAwake ();
	}

	void Start(){
		mySceneManager.OnStart ();
	}

	void Update(){
		mySceneManager.OnUpdate ();
        WOMMGame.Instance.Update();
    }
}
