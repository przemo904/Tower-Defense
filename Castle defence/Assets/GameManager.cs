using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] public GameObject wall;
    [SerializeField] public LayerMask groundMask;
    
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

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Vector3.one;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,100f,groundMask)) {
                clickPosition = hit.point;

            }
            Instantiate(wall, clickPosition, Quaternion.Euler(-90, 0, 0));
        }
    }

}
