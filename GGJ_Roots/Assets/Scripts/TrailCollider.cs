using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCollider : MonoBehaviour
{
    TrailRenderer Dirtpath;
    EdgeCollider2D Dirthurt;
    // Start is called before the first frame update
    void Awake()
    {
        Dirtpath = this.GetComponent <TrailRenderer>();
        GameObject dirtpath = new GameObject("DirtRoad", typeof(EdgeCollider2D));
        Dirthurt = dirtpath.GetComponent<EdgeCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        SetColliderPointsFromTrail(Dirtpath, Dirthurt);
    }
    void SetColliderPointsFromTrail(TrailRenderer trail, EdgeCollider2D hurt)
    {
        List<Vector2> points = new List<Vector2>();
        for (int position = 0; position <trail.positionCount; position++)
        {
            points.Add(trail.GetPosition(position));
        }
        hurt.SetPoints(points);
    }
    private void OnDestroy()
    {
        Destroy(Dirthurt.gameObject);
    }
}
