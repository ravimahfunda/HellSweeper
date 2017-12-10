using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour {

    public Animator playerAnimator;
    public Animator enemyAnimator;
    public Animator upgradeMenuAnimator;

    public void Test(string msg) {
        Debug.Log(msg);
    }

    public void Tap() {
        //Set Animation
        playerAnimator.SetTrigger("attack");
        enemyAnimator.SetTrigger("attacked");

        //And then what happend
    }

    public static string KEY_GOLD_CD = "GoldIsOnCooldown";

    public void Gold(Button bt)
    {
        //Set Properties
        bt.interactable = false;

        //And then what happend
        Test("Gold Clicked");
        PlayerPrefs.SetInt(KEY_GOLD_CD,1);
    }

    public static string KEY_SKILL_CD = "SkillIsOnCooldown";
    public void Skill(Button bt)
    {
        //Set Properties
        bt.interactable = false;

        //And then what happend
        Test("Skill Clicked");
        PlayerPrefs.SetInt(KEY_SKILL_CD, 1);
    }

    public static string KEY_REAPER_CD = "ReaperIsOnCooldown";
    public void Reaper(Button bt)
    {
        //Set Properties
        bt.interactable = false;

        //And then what happend
        Test("Reaper Clicked");
        PlayerPrefs.SetInt(KEY_REAPER_CD, 1);
    }

    public void UpgradeMenu()
    {
        //Set Properties
        upgradeMenuAnimator.SetBool("Show",!upgradeMenuAnimator.GetBool("Show"));

        //And then what happend
        Test("Upgrade Menu Clicked");
    }
}
