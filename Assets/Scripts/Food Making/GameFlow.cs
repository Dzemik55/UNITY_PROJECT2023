using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public static int [] orderValue = {111111, 10001, 12001};
    public static int [] plateValue = {0, 0, 0};
    public static GameObject[] PlatesArray;
    public static float [] orderTimer = {60, 60, 60};

    public static int plateNum = 0;
    public static float plateXpos = 0;

    public Transform plateSelector;
    Click click;

    public static float emptyPlateNow = -1;
    void Start()
    {
        PlatesArray = GameObject.FindGameObjectsWithTag("PlatesInteractive");
        PlatesArray[0] = GameObject.Find("plate01");
        PlatesArray[1] = GameObject.Find("plate02");
        PlatesArray[2] = GameObject.Find("plate03");
         Debug.Log(PlatesArray[0].gameObject.name);
        Debug.Log(PlatesArray[1].gameObject.name);
        Debug.Log(PlatesArray[2].gameObject.name);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            plateNum += 1;
            plateXpos += 0.76f;

            if (plateNum > 2)
            {
                plateNum = 0;
                plateXpos = 0;
            }
        }

        for (int i = 0; i < orderTimer.Length; i++)
        {
            orderTimer[i] -= Time.deltaTime;
        }

        plateSelector.transform.position = new Vector3(plateXpos, -2.19f, 5.24f);

    }
}
