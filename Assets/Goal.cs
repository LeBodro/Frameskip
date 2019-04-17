using UnityEngine;

public class Goal : MonoBehaviour
{
    public AudioSource winSound;
    public event System.Action OnReached;

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            winSound.Play();
            OnReached();
        }
    }
}
