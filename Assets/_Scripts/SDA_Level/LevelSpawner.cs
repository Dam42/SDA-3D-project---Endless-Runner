using UnityEngine;
using System.Collections.Generic;

namespace SDA.Level
{
    public class LevelSpawner : MonoBehaviour
    {
        [SerializeField] private Transform nextChunkPosition;
        [SerializeField] private Transform levelParent;

        [SerializeField] private List<Chunk> chunkPrefabs;

        private Queue<Chunk> spawnedChunks = new Queue<Chunk>();

        public void SpawnChunks(int count)
        {
            for (int i = 0; i < count; i++) SpawnChunk();
        }
        public void SpawnChunk()
        {
            var randomNumer = Random.Range(0, chunkPrefabs.Count);
            var chunkPrefab = chunkPrefabs[randomNumer];
            var spawned = Instantiate(chunkPrefab, nextChunkPosition.position, chunkPrefab.transform.rotation, levelParent);

            nextChunkPosition.position += Vector3.forward * 29.8f;
            spawnedChunks.Enqueue(spawned);
        }
        public void DestroyChunk()
        {
            var chunkToDestroy = spawnedChunks.Dequeue();
            Destroy(chunkToDestroy.gameObject);
        }

    } 
}
