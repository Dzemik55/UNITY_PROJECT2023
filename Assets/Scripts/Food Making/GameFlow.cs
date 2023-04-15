using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public static int [] orderValue = {111111, 10001, 12001};
    public static int [] plateValue = {0, 0, 0};
    public static float [] orderTimer = {60, 60, 60};

    public static int plateNum = 0;
    public static float plateXpos = 0;

    public Transform plateSelector;
    void Start()
    {

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
