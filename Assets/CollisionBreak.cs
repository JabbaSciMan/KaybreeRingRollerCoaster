using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public GameObject effect;
    // This method is called when a collision occurs
    void OnCollisionEnter(Collision collision)
    {
        effect.SetActive(true);
         // Destroy the GameObject this script is attached to
        Destroy(gameObject);
        Destroy(effect, 4);
    }
}
