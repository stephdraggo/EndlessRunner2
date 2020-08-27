using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDeath : MonoBehaviour
{
    public float lifetime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DieNow", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-ObstacleMovement.speed,0,0)*Time.deltaTime,Space.Self);
    }
    void DieNow()
    {
        Destroy(this.gameObject);
    }
}
