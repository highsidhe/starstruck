using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ProgressBarCircle;
using static ProgressBar;

public class Player : MonoBehaviour
{
    public ProgressBar _healthBar;
    public ProgressBarCircle _shieldBar;

    public Player(ProgressBar healthBar, ProgressBarCircle shieldBar)
    {
        _healthBar = healthBar;
        _shieldBar = shieldBar;
    }

    public void Awake()
    {
        // set stats
        _healthBar.BarMaxValue = 100;
        _healthBar.BarValue = 100;
        _shieldBar.BarMaxValue = 100;
        _shieldBar.BarValue = 100;
    }
}
