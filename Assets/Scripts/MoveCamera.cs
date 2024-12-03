using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform Player;
    void Update()
    {        
        transform.LookAt(Player);

        transform.LookAt(Player);
    }
}
