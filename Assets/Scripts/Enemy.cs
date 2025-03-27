using UnityEngine;

namespace DefaultNamespace
{
    public class Enemy : MonoBehaviour
    {
        private int  hp;

        public void SetHP(int hpValue)
        {
            hp = hpValue;
            
        }

        //回傳血量
        public int GetHP()
        {
            return hp;
        }

        public void TakeDamage(int damege)
        {
            
            if (hp>0)
            {
                //設定目前血量為 目前血量-傷害
            hp -= damege;
            if (hp < 0)
                hp = 0;
            {
                
            }
            }
        }

    }
}