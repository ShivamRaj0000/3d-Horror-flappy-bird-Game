using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("Leverl 01");
    }

    public void Exit()
    {
        Application.Quit();
        
    }

}
