using UnityEngine;

namespace Scenes
{
    public static class TerrainGenerator
    {
        public static int[,,] GenerateTerrain()
        {
            var result = new int[ChunkRenderer.ChunkWidth, ChunkRenderer.ChunkHeight, ChunkRenderer.ChunkWidth];
            
            for (int x = 0; x < ChunkRenderer.ChunkWidth; x++)
            {
                for (int z = 0; z < ChunkRenderer.ChunkWidth; z++)
                {
                    float height = Mathf.PerlinNoise(x * .2f, z * .2f) * 5 + 10;

                    for (int y = 0; y < height; y++) result[x, y, z] = 1;
                }
            }

            return result;
        }
    }
}