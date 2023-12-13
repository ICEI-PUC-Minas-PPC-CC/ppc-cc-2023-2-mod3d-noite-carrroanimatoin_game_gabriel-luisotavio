using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int WayPointIndex = 0;
    [SerializeField] float speed=1f;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[WayPointIndex].transform.position)<.1f)
        {
            WayPointIndex++;
            if (WayPointIndex >= waypoints.Length)
            {
                WayPointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[WayPointIndex].transform.position, speed * Time.deltaTime);
    }
}
