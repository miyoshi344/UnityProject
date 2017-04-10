using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * シーン遷移管理用コントローラー
 */ 
public class SceneController : MonoBehaviour {

    public static SceneController instance;

    private void Awake()
    {
        // SceneCntrollerインスタンスが存在したら
        if(instance != null)
        {
            // 今回インスタンス化したSceneControllerを破棄
            Destroy(this.gameObject);
        }
        else if(instance == null)
        {
            // このSceneControllerをインスタンスとする
            instance = this;
        }

        // シーンを跨いでもSceneControllerインスタンスを破棄しない
        DontDestroyOnLoad(this.gameObject);
    }

    static public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    // Use this for initialization
    void Start () {
        // タイトルシーン呼び出し
        SceneManager.LoadScene("TitleScene");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
