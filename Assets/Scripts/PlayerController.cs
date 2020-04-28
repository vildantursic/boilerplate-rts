using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    private NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if (ClickSelectController.SelectedEntity != null) {
            agent = ClickSelectController.SelectedEntity.agent;
        } else {
            agent = null;
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (agent && Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
