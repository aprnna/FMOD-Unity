using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class FMODEvents : MonoBehaviour
{
    [field:Header("PlayerSFX")]
    [field:SerializeField] public EventReference playerFootsteps { get; private set; }
    [field:Header("Coin SFX")]
    [field:SerializeField] public EventReference coinCollected { get; private set; }
    [field:SerializeField] public EventReference coinIdle { get; private set; }
    public static FMODEvents instance { get; private set; }
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Audio Manager in the scene");
        }

        instance = this;
    }
}
