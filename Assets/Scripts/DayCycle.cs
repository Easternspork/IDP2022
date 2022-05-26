using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCycle : MonoBehaviour
{
    [SerializeField]
    private Image dayCycleImage;

    [SerializeField]
    private Sprite morningSprite;
    [SerializeField]
    private Sprite noonSprite;
    [SerializeField]
    private Sprite nightSprite;

    private void Start()
    {
        Morning();
    }

    public void Morning()
    {
        dayCycleImage.overrideSprite = morningSprite;
    }

    public void Noon()
    {
        dayCycleImage.overrideSprite = noonSprite;

    }

    public void Night()
    {
        dayCycleImage.overrideSprite = nightSprite;

    }
}
