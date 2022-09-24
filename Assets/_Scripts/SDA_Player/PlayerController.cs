using UnityEngine;

namespace SDA.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        [SerializeField] private Rigidbody player;

        public void MovePlayer()
        {
            player.velocity = Vector3.forward * movementSpeed;
        }
    } 
}
