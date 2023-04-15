using UnityEngine;

public class GlueObjects : MonoBehaviour
{
   
    // Talerz - ustawiamy w inspektorze
    private GameObject plate;
    private GameObject patelnia;

    private void Start()
    {
        patelnia = GameObject.Find("Patelnia");
    }

    private void Update()
    {
        if (GameFlow.plateXpos == 0)
        plate = GameObject.Find("plate01");
        else if (GameFlow.plateXpos == 0.76f)
            plate = GameObject.Find("plate02");
        else if (GameFlow.plateXpos == 1.52f)
            plate = GameObject.Find("plate03");
    }

    // Czy pierwszy sk≥adnik jedzenia zosta≥ juø dodany do talerza
    private bool isFirstIngredientAdded = false;

    private void OnCollisionEnter(Collision collision)
    {
        // Sprawdü, czy sk≥adnik jedzenia koliduje z talerzem
        if (collision.gameObject == plate)
        {
            // Jeúli tak, to dodaj sk≥adnik jedzenia jako dziecko talerza
            transform.SetParent(plate.transform);
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
        else if (collision.gameObject != patelnia)
        {
            // Jeúli sk≥adnik jedzenia koliduje z innym sk≥adnikiem jedzenia lub innym obiektem, to dodaj go jako dziecko tego obiektu
            transform.SetParent(collision.transform);
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
