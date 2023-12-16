using UnityEngine;
public class DeleteParticleLight : MonoBehaviour
{
    public ParticleSystem particleSystem;
    void OnTriggerEnter(Collider col)
    {
        particleSystem.enabled = false;
    }
}
