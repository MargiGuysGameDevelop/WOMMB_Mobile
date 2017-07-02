﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MySceneManager {

	MyScene myScene = null;

	public virtual void OnAwake(){}

	public virtual void OnStart(){
		myScene = new LoginScene(this);
		myScene.OnSenceStart ();
        //SceneManager.sceneLoaded += OnSceneStart; ;
    }

    private void OnSceneStart(Scene arg0, LoadSceneMode arg1)
    {
        myScene.OnSenceStart();
    }

    public virtual void OnUpdate(){
		myScene.OnSenceUpdate ();
	}

    public virtual void SetScene(MyScene _scene) {
		Debug.Log ("Load scene! ");
		Debug.Log ("Exit scene : "  + myScene.SceneName);

        myScene.OnSenceExit();
		SceneManager.sceneLoaded -= OnSceneStart;
        myScene = _scene;

		Debug.Log ("Enter scene : "  + myScene.SceneName);

		SceneManager.sceneLoaded += OnSceneStart;
		myScene.LoadScene ();

    }
}