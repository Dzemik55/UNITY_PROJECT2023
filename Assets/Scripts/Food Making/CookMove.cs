using System.Collections;
using UnityEngine;

public class CookMove : MonoBehaviour
{
    private int foodValue = 0;
    private MeshRenderer meatMaterial;
    private bool stillCooking = true;
    Material newMaterial;
    Texture newTexture;
    Bounds bounds;
    Click click;
    float objHeight;
    void Start()
    {
        meatMaterial = GetComponent<MeshRenderer>();
        newMaterial = Resources.Load<Material>("Patty");
        newTexture = Resources.Load<Texture2D>("Patty");
        bounds = gameObject.GetComponent<Renderer>().bounds;
        objHeight = bounds.size.y;
        StartCoroutine(cookTimer());
    }


    void Update()
    {

    }

    private void OnMouseDown()
    {
        GetComponent<Transform>().position = new Vector3(GameFlow.plateXpos, click.spawnPosition.y, 5.16599989f);
        click.spawnPosition.y = click.spawnPosition.y + objHeight + 0.01853943f;
        GameFlow.plateValue[GameFlow.plateNum] += foodValue;
        stillCooking = false;
    }

    IEnumerator cookTimer()
    {
        yield return new WaitForSeconds(10);
        foodValue = 1000;
        if (stillCooking)
        {
            meatMaterial.material = newMaterial;
            meatMaterial.material.mainTexture = newTexture;
        }
    }
}
