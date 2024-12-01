using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] Text hpText;
    public static int Hp;
    [SerializeField] private int maxHp = 100;
    void Start()
    {
        Hp = maxHp;
        hpText.text = Hp.ToString();
    }

    void Update()
    {
        //if (Hp <= 0)
        //{
        //    Debug.Log("Проигрыш");
        //}
    }
    public void TakeDamage(int count)
    {
        if (Hp > 0)
        {
            Hp -= count;
            hpText.text = Hp.ToString();
            if(Hp <= 0)
            {
                GameOver.Instanse.GameOverEvent.Invoke();
            }
        }
    }
}
