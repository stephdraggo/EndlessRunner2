using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner
{
    [AddComponentMenu("Runner/Lava Floor")]
    public class LavaFloor : MonoBehaviour
    {
        #region Variables
        [Header("Reference Variables")]
        public GameObject player;
        #endregion
        void Start()
        {

        }

        void Update()
        {

        }


        //neither of these work, why?
        void OnTriggerEnter(Collider collider)
        {
            Debug.Log("triggered a collision");
        }
        void OnCollisionEnter()
        {
            Debug.Log("collided with something");
        }
    }
}