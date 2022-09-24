using UnityEngine;

namespace SDA.Data
{
    [CreateAssetMenu(menuName = "Storage/TestStorage")]
    public class TestStorage : ScriptableObject
    {
        [SerializeField] private int speed;

        public int Speed => speed;
    } 
}
