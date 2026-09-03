using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem; // ★ 新しい Input System を使うために必要

public class ToAnyScene : MonoBehaviour
{
    [SerializeField] private string nextSceneName = "l"; 

    // Update is called once per frame
    void Update()
    {
        // キーボードの任意のキーが押されたか判定
        if (Keyboard.current != null && Keyboard.current.anyKey.wasPressedThisFrame)
        {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        if (!string.IsNullOrEmpty(nextSceneName))   // nextSceneNameが空でないか判定
        {
            SceneManager.LoadScene(nextSceneName);  // nextSceneNameに設定されたシーン名を指定してシーン遷移
        }
        else
        {
            Debug.LogWarning("遷移先のシーン名が設定されていません。");
        }
    }
}