using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMode : MonoBehaviour
{
    public void SimpleMOde()
    {
        SceneManager.LoadScene("Leverl 01");
    }

    public void HorrorMode()
    {
        SceneManager.LoadScene("HorrorMode");
    }

}
