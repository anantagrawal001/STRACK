using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartDelay = 1f;
    public GameObject completelavelUI;


    public void completelavel()
    {
        completelavelUI.SetActive(true);
    }

   public void EndGame ()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
      
}
