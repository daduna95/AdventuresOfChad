using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerMoveScript : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            MovePlayer();
        }
    }

    public void MovePlayer()
    {
        RaycastHit hit;
        Ray lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool hasHit = Physics.Raycast(lastRay, out hit);
        if(hasHit == true)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
}
