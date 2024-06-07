using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextKeyA2 : MonoBehaviour
{
    [SerializeField] private Text nameText1; // 感性語を表示するテキスト
    [SerializeField] private Text nameText2; // 感性語を表示するテキスト
    [SerializeField] private Text nameText11; // 感性語を表示するテキスト
    [SerializeField] private Text nameText12; // 感性語を表示するテキスト

    public int i;     //文字番号の制御
    public int j;
    
    private string[] words =new string[]
    {
        "もちもちの","ふっくらとした","アナログな","涼しげな","漆黒の","光沢感","立体的な","暖かい","滑りくそうな","季節感のある","やわらかい","つるつるした","ウッドな","ふわふわした","ネオンな","優雅な",
        "ボタニカルな","淡い","メリハリのある","プルプルな"
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // nameText.text = excelData.A_2[0].kanseigo;
        nameText1.text = words[j];
        nameText2.text = words[i];
        nameText11.text = words[j];
        nameText12.text = words[i];
    }
}
