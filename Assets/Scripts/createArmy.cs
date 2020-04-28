using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createArmy : MonoBehaviour
{
    public GameObject armyPrefab;
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit) {
                if (hitInfo.transform.gameObject.name == "house")
                {
                    // TODO take coordinates from building and add building selection for spawning units
                    Instantiate(armyPrefab, new Vector3(20, 2, 20), Quaternion.identity);
                }
            }
        }
    }
}
