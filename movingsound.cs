using UnityEngine;

public class MovingSound : MonoBehaviour
{
    public float speed = 2f; // Hareket hızı
    public Vector3 moveDirection = new Vector3(1, 0, 0); // X ekseninde hareket

    private AudioSource audioSource;

    void Start()
    {
        // AudioSource bileşenini al
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource bileşeni eklenmemiş!");
        }

        // 3D Ses özelliklerini ayarla
        audioSource.spatialBlend = 1f; // Tamamen 3D ses
        audioSource.dopplerLevel = 1f; // Doppler efekti
        audioSource.rolloffMode = AudioRolloffMode.Logarithmic;
        audioSource.minDistance = 1f;
        audioSource.maxDistance = 50f;

        // Ses çalmaya başlasın
        audioSource.Play();
    }

    void Update()
    {
        // Nesneyi sürekli hareket ettir
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}

