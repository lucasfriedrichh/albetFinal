using UnityEngine;

public class Goalkeeper : MonoBehaviour
{
    public float speed = 5f;     // Velocidade do movimento
    public float distance = 5f;  // Distância total que o goleiro percorrerá
    private Vector3 startPosition;
    private Quaternion startRotation;

    void Start()
    {
        // Define a posição inicial
        startPosition = new Vector3(32.9982f, 0.0802784f, 2.084329f);
        transform.position = startPosition;

        // Define a rotação inicial
        startRotation = Quaternion.Euler(-0.031f, -92, 0.086f);
        transform.rotation = startRotation;
    }

    void Update()
    {
        // Calcula o deslocamento lateral usando PingPong
        float offset = Mathf.PingPong(Time.time * speed, distance) - (distance / 2f);

        // Move o goleiro ao longo de sua direção lateral (eixo X local)
        transform.position = startPosition + transform.right * offset;
    }
}
