using UnityEngine;

public class PrefabTest : MonoBehaviour
{

    public GameObject tilePrfab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Vector3 position = new Vector3(5f, 0f, 8f);
        //Instantiate(tilePrfab, position,Quaternion.identity);
        //GenerateMap(5, 5);

        for (int j = 0; j < 10; j++)
        {
           //
        }

    }

    //void GenerateMap(int row, int colum)
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        for (int j = 0; j < 10; j++)
    //        {
    //            Vector3 position = new Vector3(i * 5f, 0f, j * -5f);
    //            Instantiate(tilePrfab, position, Quaternion.identity);
    //        }


    //    }

    //}



    void GenerateMapTile(int row, int colum)
    {
        float xPos = Random.Range(0f, 500f);
        float zPos = Random.Range(-500f, 0);
        Vector3 position = new Vector3(xPos, 0f, zPos);
        Instantiate(tilePrfab, position, Quaternion.identity);

    }
}
