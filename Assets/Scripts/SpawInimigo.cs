using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawInimigo : MonoBehaviour
{
    public GameObject Inimigo;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Spaw());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Spaw()
    {
        float x = Random.Range(-5f, 0.5f);
        Vector3 pos = new Vector3(x, 14f, 39);

        Instantiate(Inimigo, transform.position = pos, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        yield return Spaw();
    }
}
