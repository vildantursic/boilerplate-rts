using System;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    // public Stats Stats { get; private set; }
    public int Health { get; private set; }
    // public event Action<int> OnHealthChanged;
    public Behaviour halo;

    public void TakeDamange(int amount)
    {
        Health -= amount;
        // OnHealthChanged?.invoke(Health);
    }

    public void SlectEntity(bool state)
    {
        halo.enabled = state;
    }

    private void Awake() {
        // Stats = GetComponent<Stats>();
        Health = 100;
    }
}
