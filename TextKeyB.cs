using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextKeyB : MonoBehaviour
{
    [SerializeField] private Text nameText1; // 感性語を表示するテキスト
    [SerializeField] private Text nameText2; // 感性語を表示するテキスト
    [SerializeField] private Text nameText11; // 感性語を表示するテキスト
    [SerializeField] private Text nameText12; // 感性語を表示するテキスト

    public int i;     //文字番号の制御
    public int j;
    
    private string[] words =new string[88]
    {
        "多彩な","映える","包み込むような","都会的な","クールな","オシャレな","ボリューム感のある","まとまり感のある","珍しい","目に優しい","きらきらな","さらりとした","クイックな","ファッショナブルな","理想の","たっぷり",
        "丸みを帯びた","正しい","スペシャルな","柔らかな","もちもちしてそうな","素敵な","あざとい","収納性のある","ノスタルジックな","お洒落","わかりやすい","スムーズな","高見え","判り易い （性能）","独創的な","ユニークな",
        "厳選された","モードな","流行りの","静けさ","濃厚な","カラフルな","伝統的な","マットな","いい匂いがしそうな","没入感","包まれる","スリムな","フラットな","洗練された","キュートな","静粛な","カワイイ","ハイテクな",
        "座っていたくなる","上級の","守られている","甘い","キレイな","負担のない","夢あふれる","わんぱくな","不思議な","至上の","かわいい","高価な","汚れにくい","壮大な","華やかな","スタイリッシュな","和モダンな","クリアな (視界)",
        "明るい","アーティスティックな","しっとり感","しっとりとした","軽やか","斬新の","過ごしやすい","素晴らしい","フレッシュな","かしこい","大人かわいい","普通な","ワイドな","リッチな","ふわふわしてそうな","コンパクトな",
        "おいしそうな","さっぱりした","トレンド感のある","ずっしりとした"
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
