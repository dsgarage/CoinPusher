using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}
