using UnityEngine;
using UnityEngine.SceneManagement;


public class lavelcomplete : MonoBehaviour
{

    public void LoadNextLavel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
