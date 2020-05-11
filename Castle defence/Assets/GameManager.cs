using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        // wall selected from UI
        // create wall model if possible
        if (Input.GetMouseButton(0))
        {
            Debug.Log(name);
        }
        if (Input.GetMouseButtonUp(0)) {
            Instantiate(wall, new Vector3(0, 1, 0), Quaternion.Euler(-90, 0, 0));
        }
    }

}
