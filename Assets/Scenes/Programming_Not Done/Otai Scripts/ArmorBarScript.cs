using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorBarScript : MonoBehaviour
{
    public Slider armorSlider;
    public Slider easeArmorSlider;
    public float maxArmor = 100f;
    public float armor;
    private float lerpSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        armor = maxArmor;
    }

    // Update is called once per frame
    void Update()
    {
        if (armorSlider.value != armor)
        {
            armorSlider.value = armor;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(10);
        }

        if (armorSlider.value != easeArmorSlider.value)
        {
            easeArmorSlider.value = Mathf.Lerp(easeArmorSlider.value, armor, lerpSpeed);
        }
    }

    void takeDamage(float damage)
    {
        armor -= damage;
    }
}