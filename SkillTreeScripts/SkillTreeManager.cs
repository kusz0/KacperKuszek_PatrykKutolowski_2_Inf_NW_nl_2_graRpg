using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class SkillTreeManager : MonoBehaviour
{
    public SkillSlot[] skillSlots;
    public TMP_Text pointsText;
    public int availablePoints;


    private void OnEnable()
    {
        SkillSlot.OnAbilityPointSpent += HandleAbilityPointsSpent;
        SkillSlot.OnSkillMaxed += HandleSkillMaxed;
        ExpManager.OnLevelUp += UpdateAbilityPoints;
    }
    private void OnDisable()
    {
        SkillSlot.OnAbilityPointSpent -= HandleAbilityPointsSpent;
        SkillSlot.OnSkillMaxed -= HandleSkillMaxed;
        ExpManager.OnLevelUp -= UpdateAbilityPoints;
    }
    private void Start()
    {
        foreach(SkillSlot slot in skillSlots) 
        {
            slot.skillButton.onClick.AddListener(() => CheckAviablePoints(slot));
        }
        UpdateAbilityPoints(0);
    }

    private void CheckAviablePoints(SkillSlot skillSlot)
    {
         if(availablePoints > 0)
        {
            skillSlot.TryUpgardeSkill();
        }
    }

    private void HandleAbilityPointsSpent(SkillSlot skillSlot)
    {
        if(availablePoints > 0)
        {
            UpdateAbilityPoints(-1);
        }
    }


    private void HandleSkillMaxed(SkillSlot skillSlot) 
    {
        foreach (SkillSlot slot in skillSlots)
        {
            if(!slot.isUnlocked && slot.CanUnlockSkill())
            {
                    slot.Unlock();
            }
        }
    }


    public void UpdateAbilityPoints(int amount)
    {
        availablePoints += amount;
        pointsText.text = "Points: " + availablePoints;
    }


}
