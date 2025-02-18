using UnityEngine;

public class RoomAudioController : MonoBehaviour
{
    public AudioSource fireAudio;
    public Collider roomBoundary;
    public AudioLowPassFilter filter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            fireAudio.volume = 1.0f;
            filter.cutoffFrequency = 22000;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            fireAudio.volume = 0.3f;
            filter.cutoffFrequency = 500;
        }
    }
}
