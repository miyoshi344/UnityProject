using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Debug : MonoBehaviour
{

    public Text SceneTitleText;
    public Text FpsText;

    private int frameCount;
    private float prevTime;

    // Use this for initialization
    void Start()
    {

        // EDBUGモードなら
#if DEBUG

        SceneTitleText.gameObject.SetActive(true);
        FpsText.gameObject.SetActive(true);

        // 初期化
        frameCount = 0;
        prevTime = 0.0f;

        // シーンを跨いでもDebugインスタンスを破棄しない
        DontDestroyOnLoad(this.gameObject);

#else

        SceneTitleText.gameObject.SetActive(false);
        FpsText.gameObject.SetActive(false);
#endif

    }

    // Update is called once per frame
    void Update()
    {
#if DEBUG

        ++frameCount;

        float time = Time.realtimeSinceStartup - prevTime;

        // フレームレートの更新
        if (time >= 0.5f)
        {
            FpsText.text = Mathf.Floor(frameCount - time) + "fps";

            frameCount = 0;
            prevTime = Time.realtimeSinceStartup;
        }

        // タイトルの更新
        SceneTitleText.text = SceneManager.GetActiveScene().name;
#endif
    }
}
