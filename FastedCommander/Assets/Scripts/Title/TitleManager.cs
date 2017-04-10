using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 画面遷移
    public void TouchStart()
    {
        SceneController.ChangeScene("MainScene");
    }
}
