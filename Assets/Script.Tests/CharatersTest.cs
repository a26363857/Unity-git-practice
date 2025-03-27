using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using DefaultNamespace;
using NUnit.Framework;
using UnityEngine;

public class CharatersTest : MonoBehaviour
{
    [Test(Description = "玩家角色攻擊敵人")]
    [TestCase(30 , 20 , 0 , Description = "死亡但鎖血")]
    [TestCase(10 , 10 , 0, Description = "死亡")]
    public void Charater_Attack_Enmy(int atkValue , int hp , int expected)
    {
        //arrange
        //建立角色的元件
        var charaterGo = new GameObject();
        charaterGo.AddComponent<Charater>();
        var charater = charaterGo.GetComponent<Charater>();
        charater.SetAtk(atkValue :10);
        
        //建立敵人的元件
        
        var enemyGo = new GameObject()
        enemyGo.AddComponent<Enemy>();
        var enemy = enemyGo.GetComponent<Enemy>();
        enemy.SetHP(hpValue :100);
        //assert
        Assert.AreEqual(90 ,enemy.GetHP());
    }
}
