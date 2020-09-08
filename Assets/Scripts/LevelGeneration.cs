using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner
{
    [AddComponentMenu("Runner/Level Generation")]
    public class LevelGeneration : MonoBehaviour
    {
        #region Variables
        [Header("Reference Variables")]
        public List<GameObject> platformPrefabs;
        public Transform spawnLocation;
        public GameObject worldParent;
        public float speed, lifetime;

        private GameObject lastPlatformObject;
        private Platform lastPlatformScript;


        #endregion
        void Start()
        {
            lastPlatformObject = Instantiate(platformPrefabs[0],
                worldParent.transform.position,
                Quaternion.identity,
                worldParent.transform);

            lastPlatformScript = lastPlatformObject.GetComponent<Platform>();
        }

        void Update()
        {
            if (lastPlatformScript.rightBounds.transform.position.x < spawnLocation.position.x) //if right boundary is left of spawn location
            {
                NewPlatform();
            }
        }

        void NewPlatform()
        {
            GameObject newSpawn = Instantiate( //make new platform set
                    platformPrefabs[Random.Range(0, platformPrefabs.Count)], //random prefab
                    worldParent.transform.position, //child of worldParent in world space
                    Quaternion.identity, //no rotation
                    worldParent.transform); //child of worldParent in hierarchy

            Platform newPlatform = newSpawn.GetComponent<Platform>(); //get the script off the new platform

            Vector3 positionDifference = newPlatform.leftBounds.transform.position - newSpawn.transform.position; //distance between middle and left of platform prefab

            Vector3 spawnLocation = lastPlatformScript.rightBounds.transform.position - positionDifference; //

            newSpawn.transform.position = spawnLocation; //

            lastPlatformObject = newSpawn; //set as last platform
            lastPlatformScript = newPlatform; //same thing but script
        }
    }
}