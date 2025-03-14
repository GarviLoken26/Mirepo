using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class algebra : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Jona");
        Vector3 norm = Normalizar(target1.transform.position);
        Debug.Log(norm);

    }
    void Update()
    {
       float dist = Distance(target1.transform.position, target2.transform.position);
        if (dist < 2)
        {
           Debug.Log("esta madre esta pegando");
        }
    }

    public float Distance (Vector3 pos1, Vector3 pos2)
    {
      float x = pos1.x - pos2.x;
      float y = pos1.y - pos2.y;
      float z = pos1.z - pos2.z;

      float x2 = x * x;
      float y2 = y * y;
      float z2 = z * z;
        float sum = x2 + y2 + z2;

      float sqrt = Mathf.Sqrt(sum);
        return sqrt;
    }
    public Vector3 Normalizar(Vector3 pos)
    {
        float x = pos.x * pos.x;
        float y = pos.y * pos.y;
        float z = pos.z * pos.z;

        float sum = x + y + z;

        float sqrt = Mathf.Sqrt(sum);

        float xN = pos.x / sqrt;
        float yN = pos.y / sqrt;
        float zN = pos.z / sqrt;

        Vector3 norm = new Vector3(xN, yN, zN);
        return norm;

    }
    public float pPunto(Vector3 pos1, Vector3 pos2)
    {
        float x = pos1.x * pos2.x;
        float y = pos1.y * pos2.y;
        float z = pos1.z * pos2.z;

        
        float sum = x + y + z;

        
        return sum;
    }
}

