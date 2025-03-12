using UnityEngine;
using UnityEngine.UI;
using R3;

public class HealthPresenter : MonoBehaviour
{
    [SerializeField] private HealthModel healthModel;
    [SerializeField] private Slider healthSlider;
    private void Start()
    {
        healthModel.Health.Subscribe(x=>healthSlider.value=x).AddTo(this);
        healthModel.MaxHealth.Subscribe(x => healthSlider.maxValue = x).AddTo(this);
    }
}
