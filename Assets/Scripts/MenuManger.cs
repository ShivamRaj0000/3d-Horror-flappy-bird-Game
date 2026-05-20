using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{

    public GameObject selectMode;

    public void StartScene()
    {
       selectMode.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
        
    }

}
