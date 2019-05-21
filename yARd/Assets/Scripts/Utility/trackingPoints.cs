using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackingPoints : MonoBehaviour
{

    public SpriteRenderer[] imageTransforms;
    public Vector3[] orginOffset;

    // Start is called before the first frame update
    void Start()
    {
        imageTransforms = GetComponentsInChildren<SpriteRenderer>();

        orginOffset = new Vector3[imageTransforms.Length];

        for(int i=0; i < imageTransforms.Length; i++)
        {
            //orginOffset[i] = new Vector3(-imageTransforms[i].transform.position.x, imageTransforms[i].transform.position.y, imageTransforms[i].transform.position.z);
            orginOffset[i] = transform.position - imageTransforms[i].transform.position;
        }

    }

    private void OnValidate()
    {
        Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
