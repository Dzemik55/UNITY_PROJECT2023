using UnityEngine;
using UnityEngine.UIElements;

public class ServePlate : MonoBehaviour
{
    public bool FarEnoguh = false;
    public Vector3 position;
    public Vector3 currentPosition;
    public ObjectGrabbable objectGrabbable;
    public PlayerPickUpDrop playerPickUpDrop;


    void Start()
    {
        position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    [System.Obsolete]
    void Update()
    {
        currentPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        float distance = Vector3.Distance(transform.position, position);
        if (transform.GetChildCount() > 0)
        {
            Transform firstChild = transform.GetChild(0);
            if (distance > 10f && firstChild != null)
            {
                if (firstChild != null)
                {
                    Destroy(firstChild.gameObject);
                    SendMessage("Drop");
                    objectGrabbable = null;
                    transform.position = position;
                }
            }
        }
    }

    private void OnMouseDown()
    {
        if (GameFlow.orderValue == GameFlow.plateValue)
        {
            Debug.Log("correct");
           
        }

        GameFlow.emptyPlateNow = transform.position.x;
    }
}
