using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static Enums;
using static StatusEffect;

public class Card : MonoBehaviour
{
    [Header("Card Details")]
    public string _cardName;
    public CardType _cardType;
    public int _cost;
    public Sprite _img;
    public StatusType _statusType;
    public List<StatusEffect> _statuses;

    [Header("Card Settings")]
    public Text _descText;
    public Text _costText;
    public Text _typeText;
    public Text _titleText;
    public Image _imgSprite;

    public Card(string cardName, CardType cardType, int cost, Sprite img, StatusType statusType, List<StatusEffect> statuses)
    {
        _cardName = cardName;
        _cardType = cardType;
        _cost = cost;
        _img = img;
        _statusType = statusType;
        _statuses = statuses;
    }

    public void Awake()
    {
        setVars();
    }

    public void Update()
    {
        setVars();
    }

    public void setVars()
    {
        _descText.text = BuildDescription();
        _costText.text = _cost.ToString();
        _typeText.text = _statusType.ToString();
        _titleText.text = _cardName;
        _imgSprite.sprite = _img;
    }

    public string BuildDescription()
    {
        string descTemp = "";
        foreach(StatusEffect status in _statuses)
        {
            switch (status._effectType)
            {
                case EffectType.Base_Attack:
                    descTemp += String.Format("deal {0} damage", status._value);
                    break;
                case EffectType.Subtract_Total:
                    descTemp += String.Format("subtract {0} from damage total", status._value);
                    break;
                default:
                    descTemp += String.Format("could not find damage type: {0}", status._effectType);
                    break;
            }

            descTemp += "\n";
        }
        return descTemp;
    }
}
