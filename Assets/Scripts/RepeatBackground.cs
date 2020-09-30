using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Runner
{
    [AddComponentMenu("Runner/Repeating Background")]
    public class RepeatBackground : MonoBehaviour
    {
        #region Variables
        [SerializeField]
        private float imageLength;

        [SerializeField]
        private float speed;

        [SerializeField]
        private Rigidbody2D rigidBody;
        #endregion
        void Start()
        {
            imageLength = GetComponent<SpriteRenderer>().bounds.size.x;

            rigidBody = GetComponent<Rigidbody2D>();

            rigidBody.velocity = new Vector2(speed, 0);
        }

        void Update()
        {
            //if the difference along the x axis between the main Camera and the position of the object this is attached to is greater than groundHorizontalLength.
            if (transform.position.x < -imageLength)
            {
                //If true, this means this object is no longer visible and we can safely move it forward to be re-used.
                Repeat();
            }
        }

        private void Repeat()
        {
            //This is how far to the right we will move our background object, in this case, twice its length. This will position it directly to the right of the currently visible background object.
            Vector2 groundOffSet = new Vector2(imageLength * 2f, 0);

            //Move this object from it's position offscreen, behind the player, to the new position off-camera in front of the player.
            transform.position = (Vector2)transform.position + groundOffSet;
        }
    }
}