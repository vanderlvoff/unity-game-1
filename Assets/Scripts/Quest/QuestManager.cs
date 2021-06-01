using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class QuestManager : MonoBehaviour
{
    public StageUImanager stageUI;
    public GameObject enemyPrefab;
    public BattleManager battleManager;
    public SceneTransitionManager sceneTransitionManager;

    //
    int[] encountTable = { -1, -1, 0, -1, 0, -1 };

    int currentStage = 0;
    private void Start()
    {
        stageUI.UpdateUI(currentStage);
    }


    //
    public void OnNextButton()
    {
        currentStage++;
        //
        stageUI.UpdateUI(currentStage);

        if (encountTable.Length <= currentStage)
        {
            Debug.Log("クエストクリア");
            QuestClear(); 
        }
        else if (encountTable[currentStage] == 0)
        {
            EncountEnemy();
        }
    }

    void EncountEnemy()
    {
        stageUI.HideButtons();
        GameObject enemyObj = Instantiate(enemyPrefab);
        EnemyManager enemy = enemyObj.GetComponent<EnemyManager>();
        battleManager.Setup(enemy);
    }

    public void EndBattle()
    {
        stageUI.ShowButtons();
    }

    void QuestClear()
    {
        //
        //
        stageUI.ShowClearText();
        //sceneTransitionManager.LoadTo("Town");
    }
}
  