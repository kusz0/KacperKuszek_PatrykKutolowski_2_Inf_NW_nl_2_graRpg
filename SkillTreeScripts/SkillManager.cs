using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class SkillManager : MonoBehaviour
{

    private void OnEnable()
    {
        SkillSlot.OnAbilityPointSpent += HandleAbilityPointsSpent;
    }
    private void OnDisable()
    {
        SkillSlot.OnAbilityPointSpent -= HandleAbilityPointsSpent;
    }

    private void HandleAbilityPointsSpent(SkillSlot slot)
    {
        string skillName = slot.skillSO.skillName;

        switch(skillName)
        {
            case "Max Health Boost":
                StatsManager.Instance.UpdateMaxHealth(1);
                break; 
            default:
                Debug.Log($"Unkown skill: {skillName}");
                break;
        }
    }
}
