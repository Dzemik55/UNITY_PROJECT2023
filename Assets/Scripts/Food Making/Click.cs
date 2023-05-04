using UnityEngine;

public class Click : MonoBehaviour
{
    public Transform cloneObj;
    public int foodValue;
    public  Vector3 spawnPosition = new Vector3(GameFlow.plateXpos, -2.17700005f, 5.16599989f);
    Bounds bounds;
    float objHeight;
    void Start()
    {
        bounds = gameObject.GetComponent<Renderer>().bounds;
        objHeight = bounds.size.y;
        spawnPosition.y = GameFlow.PlatesArray[GameFlow.plateNum].transform.position.y;
        Debug.Log("Start: Wysokoœæ spawnu: " + spawnPosition.y);

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            spawnPosition.y = GameFlow.PlatesArray[GameFlow.plateNum].gameObject.transform.position.y;
        }

    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Bulka_dol")
        {
            Instantiate(cloneObj, new Vector3(GameFlow.plateXpos, spawnPosition.y+0.1f, spawnPosition.z), cloneObj.rotation);
            spawnPosition.y = spawnPosition.y + objHeight + 0.01f;
            Debug.Log("Wysokoœæ tego obiektu: " +gameObject.name + " " + objHeight);
            Debug.Log("Wysokoœæ spawnu: " + spawnPosition.y);
        }
        if (gameObject.name == "Bulka_gora")
        {
            Instantiate(cloneObj, new Vector3(GameFlow.plateXpos, spawnPosition.y, spawnPosition.z), cloneObj.rotation);
            spawnPosition.y = spawnPosition.y + objHeight + 0.01f;
            Debug.Log("Wysokoœæ tego obiektu: " + gameObject.name + " " + objHeight);
            Debug.Log("Wysokoœæ spawnu: " + spawnPosition.y);
        }
        if (gameObject.name == "Ser")
        {
            Instantiate(cloneObj, new Vector3(GameFlow.plateXpos, spawnPosition.y, spawnPosition.z), cloneObj.rotation);
            spawnPosition.y = spawnPosition.y + objHeight + 0.01f;
            Debug.Log("Wysokoœæ tego obiektu: " + gameObject.name + " " + objHeight);
            Debug.Log("Wysokoœæ spawnu: " + spawnPosition.y);
        }
        if (gameObject.name == "Bekon")
        {
            Instantiate(cloneObj, new Vector3(GameFlow.plateXpos, spawnPosition.y, spawnPosition.z), cloneObj.rotation);
            spawnPosition.y = spawnPosition.y + objHeight + 0.01f;
            Debug.Log("Wysokoœæ tego obiektu: " + gameObject.name + " " + objHeight);
            Debug.Log("Wysokoœæ spawnu: " + spawnPosition.y);
        }

        if (gameObject.name == "Kotlet")
        {
            Instantiate(cloneObj, new Vector3(0.5f, -2.197392f + 0.1f, 4.71999979f), cloneObj.rotation);
        }

        GameFlow.plateValue[GameFlow.plateNum] += foodValue;
        //Debug.Log(GameFlow.plateValue[GameFlow.plateNum] + " " + GameFlow.orderValue[GameFlow.plateNum]);
    }
}
