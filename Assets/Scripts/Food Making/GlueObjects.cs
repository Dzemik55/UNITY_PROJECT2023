using UnityEngine;

public class GlueObjects : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("PlatesInteractive") || collision.gameObject.CompareTag("FoodConstructor")) && !collision.gameObject.CompareTag("FoodPrepItemsNonInteractive"))
        {
            // Jeœli tak, to dodaj sk³adnik jedzenia jako dziecko talerza
            transform.SetParent(collision.gameObject.transform);
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
