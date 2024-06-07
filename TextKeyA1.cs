using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextKeyA1 : MonoBehaviour
{
    [SerializeField] private Text nameText1; // 感性語を表示するテキスト
    [SerializeField] private Text nameText2; // 感性語を表示するテキスト
    [SerializeField] private Text nameText11; // 感性語を表示するテキスト
    [SerializeField] private Text nameText12; // 感性語を表示するテキスト

    public int i;     //文字番号の制御
    public int j;
    
    private string[] words =new string[]
    {
        "さわやかな","自由自在な","派手な","雰囲気がある","セクシーな","フォーマルな","エキゾチックな ＝異国風","フェミニンな","近未来的な","芯のある","大人っぽい","ワイルドな","丈夫な",
        "清潔感のある","迫力のある","癒される","たくましい","未来感のある","気品のある","一体感のある","インパクトのある","整理された","豪華な","遊び心のある","ナチュラルな","イカつい","幻想的な","レトロな","上品な" 
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
