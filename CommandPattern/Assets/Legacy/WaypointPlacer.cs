using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPlacer : MonoBehaviour
{
    [SerializeField]
    GameObject _waypoint;
    
    public GameObject CurrentWaypoint { get; set; }

    [SerializeField]
    List<AgentController> agentList;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos=new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
         Vector3 _wordPos;
         Ray ray=Camera.main.ScreenPointToRay(mousePos);
         RaycastHit _hit;
         if (Input.GetMouseButtonDown(0)) {
            if(Physics.Raycast(ray,out _hit,1000f)) {
                _wordPos = _hit.point;
            } else {
                _wordPos=Camera.main.ScreenToWorldPoint(mousePos);
            }
            Destroy(CurrentWaypoint);
            CurrentWaypoint = Instantiate(_waypoint, _wordPos, Quaternion.identity);
            if (agentList[0]) {
                agentList[0].Waypoint = CurrentWaypoint.transform;
            }
         }
    }

    // PlaceWaypointCommand : ICommand { }
}

