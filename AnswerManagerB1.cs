using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;
using System.Data;

public class AnswerManagerB1 : MonoBehaviour
{
    private int k=1;    //縦の列の番号
    public int n=1;       //ワード数
    private int m = 0;  //試行回数
    public bool[,] Ans;

    //ファイル名の生成
    string baseName = "ISMB";      //変わらないところ
    string extension = "csv";      //ファイル名の末尾
    int gn = 1;                    //グループ番号
    string fileName;               //ファイル名の格納庫

    // Start is called before the first frame update
    void Start()
    {
        Ans = new bool[n,n];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnswerButtonYes()
    {
        // Debug.Log("Yes");

        //別オブジェクトの別スクリプトから変数を取得
        TextKeyB textkey;
        GameObject obj = GameObject.Find("TextManager");
        textkey = obj.GetComponent<TextKeyB>();

        //配列に結果を出力
        Ans[textkey.j,textkey.i] = true;
        Debug.Log(Ans[textkey.j,textkey.i]);
        Debug.Log(textkey.i);
        Debug.Log(textkey.j);

        k = k + 1;    //縦の列カウント
        m = m + 1;    //試行回数のカウント

        if(k == n)    //次の列へ
        {
            k = 1;
            textkey.i++;
            textkey.j=0;
        }
        else         //組み合わせ変える
        {
            textkey.j++;
            if(textkey.i == textkey.j)      //（n,n）の組み合わせを飛ばす
            {
                textkey.j++;
            }
        }
        if(m == 696)      //終わりの判定
        {
            Debug.Log("end");
            
            //グループ番号の推定
            gn = textkey.i / 8 + 1;
            
            //i,jの初期化
            textkey.i = 0;
            textkey.j = 1;

            // ヘッダーを定義
            string[] headers = {"1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37",
            "38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76",
            "77","78","79","80","81","82","83","84","85","86","87","88"  } ;
            // string[] headers = {"1","2","3","4","5" } ;
            
            // 配列をCSV形式の文字列に変換
            string csvContent = CsvUtility.BoolArrayToCsv(Ans, headers);

            //ファイル名の作成
            fileName = $"{baseName}{gn}.{extension}";
        
            // ファイルの保存パスを決定
            string filePath = Path.Combine(Application.dataPath, fileName);

            // CSV形式の文字列をファイルに保存
            FileUtility.SaveCsvToFile(csvContent, filePath);

            // 保存されたファイルのパスをログに表示
            Debug.Log($"CSV file saved to: {filePath}");

            SceneManager.LoadScene("B-title");
        }
    }

    public void AnswerButtonNo()
    {
        Debug.Log("No");

        //別オブジェクトの別スクリプトから変数を取得
        TextKeyB textkey;
        GameObject obj = GameObject.Find("TextManager");
        textkey = obj.GetComponent<TextKeyB>();

        //配列に結果を出力
        Ans[textkey.j,textkey.i] = false;
        Debug.Log(Ans[textkey.j,textkey.i]);
        Debug.Log(textkey.i);
        Debug.Log(textkey.j);

        k = k + 1;    //縦の列カウント
        m = m + 1;    //試行回数のカウント

        if(k == n)
        {
            k = 1;
            textkey.i++;
            textkey.j=0;
        }
        else
        {
            textkey.j++;
            if(textkey.i == textkey.j)
            {
                textkey.j++;
            }
        }
        if(m == 696)
        {
            Debug.Log("end");
            
            //グループ番号の推定
            gn = textkey.i / 8 + 1;
            
            //i,jの初期化
            textkey.i = 0;
            textkey.j = 1;

            // ヘッダーを定義
            string[] headers = {"1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37",
            "38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76",
            "77","78","79","80","81","82","83","84","85","86","87","88"  } ;
            // string[] headers = {"1","2","3","4","5" } ;

            // 配列をCSV形式の文字列に変換
            string csvContent = CsvUtility.BoolArrayToCsv(Ans, headers);

            //ファイル名の作成
            fileName = $"{baseName}{gn}.{extension}";
        
            // ファイルの保存パスを決定
            string filePath = Path.Combine(Application.dataPath, fileName);

            // CSV形式の文字列をファイルに保存
            FileUtility.SaveCsvToFile(csvContent, filePath);

            // 保存されたファイルのパスをログに表示
            Debug.Log($"CSV file saved to: {filePath}");

            SceneManager.LoadScene("B-title");
        }
    }
}
