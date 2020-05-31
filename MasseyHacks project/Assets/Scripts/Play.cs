using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level1Scene");
    }
}
