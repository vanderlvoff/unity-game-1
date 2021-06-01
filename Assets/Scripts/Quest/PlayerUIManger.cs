using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIManger : MonoBehaviour
{
    public Text hpText;
    public Text atText;

    public void SetupUI(PlayerManager player)
    {
        hpText.text = string.Format("HP : {0}", player.hp);
        atText.text = string.Format("{0}", player.at);
    }

    public void UpdateUI(PlayerManager player)
    {
        hpText.text = string.Format("HP : {0}", player.hp);
    }
}
 