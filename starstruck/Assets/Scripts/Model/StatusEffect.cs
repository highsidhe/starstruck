using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

public class StatusEffect : MonoBehaviour
{
    public EffectType _effectType;
    public int _value;

    public StatusEffect(EffectType effectType, int value)
    {
        _effectType = effectType;
        _value = value;
    }
}
