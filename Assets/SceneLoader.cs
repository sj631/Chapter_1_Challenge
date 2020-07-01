using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneNum;
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(LoadNewScene);
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
