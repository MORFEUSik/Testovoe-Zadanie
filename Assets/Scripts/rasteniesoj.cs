using UnityEngine;

public class RastenieSoj : MonoBehaviour
{
    private GameObject currentSeed;
    private bool isGrown = false;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && currentSeed == null)
        {
            currentSeed = SpawnSeed();
            isGrown = false;
            StartCoroutine(GrowSeed(currentSeed));
        }

        
        if (Input.GetKeyDown(KeyCode.R) && currentSeed != null && isGrown)
        {
            Destroy(currentSeed);
            currentSeed = null;
            isGrown = false;
        }
    }

    private GameObject SpawnSeed()
    {
        GameObject seed = GameObject.CreatePrimitive(PrimitiveType.Cube);
        seed.transform.position = transform.position + transform.forward * 2 + new Vector3(0, -0.5f , 0);
        seed.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        seed.GetComponent<Renderer>().material.color = Color.yellow;
        return seed;
    }

    private System.Collections.IEnumerator GrowSeed(GameObject seed)
    {
        yield return new WaitForSeconds(10);

        if (seed != null)
        {
            seed.transform.localScale *= 2;
            seed.GetComponent<Renderer>().material.color = Color.green;
            isGrown = true;
        }
    }
}
