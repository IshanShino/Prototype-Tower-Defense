using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int goldReward = 50;
    [SerializeField] int goldPenalty = 25;
    Bank bank;
    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void RewardGold()
    {
        bank.Deposit(goldReward);
    }
    
    public void PenalizeGold()
    {   
        if (bank == null) { return; }
        bank.Withdrawl(goldPenalty);
    }
}
