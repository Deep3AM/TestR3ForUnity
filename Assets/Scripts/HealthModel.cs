using R3;
using UnityEngine;

public class HealthModel : MonoBehaviour
{
    private readonly ReactiveProperty<int> maxHealth = new(100);
    private readonly ReactiveProperty<int> health = new(100);
    public ReadOnlyReactiveProperty<int> MaxHealth => maxHealth;
    public ReadOnlyReactiveProperty<int> Health => health;

    public void Increment(int amount)=>health.Value = Mathf.Min(health.Value+amount,maxHealth.Value);
    public void Decrement(int amount) => health.Value -= amount;
}
