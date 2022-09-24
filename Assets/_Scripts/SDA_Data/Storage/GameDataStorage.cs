using UnityEngine;

namespace SDA.Data
{
    public class GameDataStorage : MonoBehaviour
    {
        [SerializeField] private TestStorage testStorage;

        public TestStorage TestStorage => testStorage;
    } 
}
