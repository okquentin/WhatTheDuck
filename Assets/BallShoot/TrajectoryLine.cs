using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TrajectoryLine : MonoBehaviour
{
    public LineRenderer lr1;
    public LineRenderer lr2;
    private void Awake(){
        lr2 = GetComponent<LineRenderer>();
    }

    public void RenderLine1(Vector2 force) {
        lr1.positionCount = 2;
        Vector3[] points = new Vector3[2];
        points[0] = force;
        points[1].x = 0;
        points[1].y = 0;
        points[1].z = 0;

        lr1.SetPositions(points);
    }
    public void RenderLine2(Vector2 force) {
        lr2.positionCount = 2;
        Vector3[] points = new Vector3[2];
        points[0] = force;
        points[1].x = 0;
        points[1].y = 0;
        points[1].z = 0;

        lr2.SetPositions(points);
    }

    /*public void EndLine() {

    }*/
}
