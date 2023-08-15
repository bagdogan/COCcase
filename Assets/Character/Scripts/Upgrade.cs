using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{

    public GameObject helmet;

    public List<GameObject> objectList;

    public ParticleSystem upgradePartical;

    public void Start()
    {
        upgradePartical.Pause();
    }

    // Start is called before the first frame update
    public void upgrade()
    {
        helmet.SetActive(true);

        foreach (GameObject obj in objectList)
        {
            Renderer objRender = obj.GetComponent<Renderer>();
            objRender.material.color = Color.black;
        }

        upgradePartical.Play();
    }
}
