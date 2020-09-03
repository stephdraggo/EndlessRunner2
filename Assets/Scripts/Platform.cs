using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner
{
    [AddComponentMenu("Runner/Platform Boundaries")]
    public class Platform : MonoBehaviour
    {
        [Header("Boundaries")]
        public GameObject leftBounds;
        public GameObject rightBounds;
        public LevelGeneration level;
        void Start()
        {
            level = GetComponentInParent<LevelGeneration>();
            Invoke("DieNow", level.lifetime);
        }
        void Update()
        {
            transform.Translate(new Vector3(-level.speed, 0, 0) * Time.deltaTime, Space.Self); //move platforms to the left
        }

        void DieNow()
        {
            Destroy(this.gameObject);
        }
    }
}