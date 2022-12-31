using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    public enum CardType
    {
        Attack,
        Shield,
        AI
    }

    public enum StatusType
    {
        Ion, // deals massive damage, but damage is decreased every time card is played
        Railgun, // deal low damage multiple times
        Nanite, // deal damage each round
        Laser, // deals more damage against shields
        Scattershot, // deals moderate damage across all enemies
        Shatterbeam, // deal massive damage but can't deal damage for x rounds afterwards
        Pulse, // deals high damage plus moderate damage to a random enemy
        Plasma, // deal damage, if enemy death, deals damage to random enemy
        Exhaust, // remove card from play
        Vulnerable, // attacks are 25% more effective
        Glitched, // shields are 25% less effective
        Faulty, // attacks are 25% less effective
        Covered, // shields are 25% more effective
    }

    public enum EffectType
    {
        Base_Attack,
        Base_Shield,
        Subtract_Total,
    }
}
