using UnityEngine;
using UnityEngine.UI;

public class StateManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    float goldCD = 5;
    public Button goldButton;
    public Slider goldSlider;
    float timerA;

    float skillCD = 5;
    public Button skillButton;
    public Slider skillSlider;
    float timerB;

    float reaperCD = 5;
    public Button reaperButton;
    public Slider reaperSlider;
    float timerC;
    // Update is called once per frame
    void Update () {

        //Gold is on cooldown
        if (PlayerPrefs.GetInt("GoldIsOnCooldown",0) == 1) {
            timerA += Time.deltaTime;

            goldSlider.value += Time.deltaTime / goldCD;

            if (timerA >= goldCD) {
                goldButton.interactable = true;
                goldSlider.value = 0;

                Debug.Log("Cooldown done");
                PlayerPrefs.SetInt("GoldIsOnCooldown", 0);
                timerA = 0;
            }
        }

        if (PlayerPrefs.GetInt("SkillIsOnCooldown", 0) == 1)
        {
            timerB += Time.deltaTime;

            skillSlider.value += Time.deltaTime / skillCD;

            if (timerB >= skillCD)
            {
                skillButton.interactable = true;
                skillSlider.value = 0;

                Debug.Log("Cooldown done");
                PlayerPrefs.SetInt("SkillIsOnCooldown", 0);
                timerB = 0;
            }
        }

        if (PlayerPrefs.GetInt("ReaperIsOnCooldown", 0) == 1)
        {
            timerC += Time.deltaTime;

            reaperSlider.value += Time.deltaTime / reaperCD;

            if (timerC >= reaperCD)
            {
                reaperButton.interactable = true;
                reaperSlider.value = 0;

                Debug.Log("Cooldown done");
                PlayerPrefs.SetInt("ReaperIsOnCooldown", 0);
                timerC = 0;
            }
        }

    }
}
