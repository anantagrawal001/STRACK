using UnityEngine;

public class ENDTRIGGER : MonoBehaviour
{
    public gamemanager gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        {
            gamemanager.completelavel();
        }
    }
}
