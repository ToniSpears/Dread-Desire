using UnityEngine;
using UnityEngine.UI;

public class FearBarScript : MonoBehaviour
{
    public float maxFear = 100f;
    public float fearIncreaseRate = 10f;
    public float fearDecreaseRate = 5f;
    public float fearRadius = 20f;
    private float lerpSpeed = 0.05f;
    public Slider fearSlider;
    public Slider easeFearSlider;

    [SerializeField] private float currentFear = 0f;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(player.transform.position, fearRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                IncreaseFear(fearIncreaseRate * Time.deltaTime);
                break;
            }
        }

        DecreaseFear(fearDecreaseRate * Time.deltaTime);

        if (fearSlider.value != currentFear)
        {
            fearSlider.value = currentFear;
        }

        if (fearSlider.value != easeFearSlider.value)
        {
            easeFearSlider.value = Mathf.Lerp(easeFearSlider.value, currentFear, lerpSpeed);
        }
    }

    private void IncreaseFear(float amount)
    {
        currentFear = Mathf.Clamp(currentFear + amount, 0f, maxFear);
    }

    // Furcht abnehmen
    private void DecreaseFear(float amount)
    {
        currentFear = Mathf.Clamp(currentFear - amount, 0f, maxFear);
    }
}
