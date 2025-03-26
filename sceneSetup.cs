using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    void Start()
    {
        // Zemin oluştur
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground.transform.position = new Vector3(0, -0.5f, 0);
        ground.transform.localScale = new Vector3(10, 1, 10);
        ground.name = "Ground";
        
        // Top oluştur
        GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.transform.position = new Vector3(0, 1, 0);
        ball.name = "Ball";
        
        // Topa Rigidbody ekleyerek fizik kurallarına uymasını sağla
        Rigidbody rb = ball.AddComponent<Rigidbody>();
        rb.mass = 1;
        
        // Kamerayı ayarla
        Camera.main.transform.position = new Vector3(0, 5, -10);
        Camera.main.transform.LookAt(ball.transform);
    }
}