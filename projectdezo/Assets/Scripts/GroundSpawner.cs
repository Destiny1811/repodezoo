using UnityEngine;
using UnityEngine.UIElements;

public class GroundSpawner : MonoBehaviour{
    public GameObject GroundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile ()
    {
        GameObject temp = Instantiate(GroundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
            }

    public void Start () {
        for (int i = 0; i < 15; i++) {
            SpawnTile(); 
        
        }
        
    }
}
