using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public string LevelToLoad;
    public string LevelToLoad1;
    public string LevelToLoad2;
    public string LevelToLoad3;
    public string LevelToLoad4;
    public void Select1()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    public void Select2()
    {
        SceneManager.LoadScene(LevelToLoad1);
    }

    public void Select3()
    {
        SceneManager.LoadScene(LevelToLoad2);
    }

    public void Select4()
    {
        SceneManager.LoadScene(LevelToLoad3);
    }

    public void Select5()
    {
        SceneManager.LoadScene(LevelToLoad4);
    }
}
