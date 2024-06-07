using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;

public class AnswerManager : MonoBehaviour
{
    private int k=1;    //縦の列の番号
    public int n=1;       //ワード数
    private int m = 1;  //試行回数
    public bool[,] Ans;

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
        TextKey textkey;
        GameObject obj = GameObject.Find("TextManager");
        textkey = obj.GetComponent<TextKey>();

        //配列に結果を出力
        Ans[textkey.j,textkey.i] = true;
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
        if(textkey.i == n)
        {
            Debug.Log("end");

            // ヘッダーを定義
            string[] headers = {"1","2","3","4","5"} ;
            
            // 配列をCSV形式の文字列に変換
            string csvContent = CsvUtility.BoolArrayToCsv(Ans, headers);
        
            // ファイルの保存パスを決定
            string filePath = Path.Combine(Application.dataPath, "ISM.csv");

            // CSV形式の文字列をファイルに保存
            FileUtility.SaveCsvToFile(csvContent, filePath);

            // 保存されたファイルのパスをログに表示
            Debug.Log($"CSV file saved to: {filePath}");

            SceneManager.LoadScene("title");
        }
    }

    public void AnswerButtonNo()
    {
        Debug.Log("No");

        //別オブジェクトの別スクリプトから変数を取得
        TextKey textkey;
        GameObject obj = GameObject.Find("TextManager");
        textkey = obj.GetComponent<TextKey>();

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
        if(textkey.i == n)
        {
            Debug.Log("end");

            // ヘッダーを定義
            string[] headers = {"1","2","3","4","5"} ;

            // 配列をCSV形式の文字列に変換
            string csvContent = CsvUtility.BoolArrayToCsv(Ans, headers);
        
            // ファイルの保存パスを決定
            string filePath = Path.Combine(Application.dataPath, "ISM.csv");

            // CSV形式の文字列をファイルに保存
            FileUtility.SaveCsvToFile(csvContent, filePath);

            // 保存されたファイルのパスをログに表示
            Debug.Log($"CSV file saved to: {filePath}");

            SceneManager.LoadScene("title");
        }
    }
}
public static class CsvUtility
{
    public static string BoolArrayToCsv(bool[,] array, string[] headers)
    {
        StringBuilder csvContent = new StringBuilder();
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // ヘッダーを追加
        if (headers.Length == cols)
        {
            csvContent.AppendLine(string.Join(",", headers));
        }
        else
        {
            Debug.LogError("Header length does not match the number of columns.");
            return null;
        }

        // データ行を追加
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                csvContent.Append(array[i, j] ? "1" : "0");
                if (j < cols - 1)
                    csvContent.Append(",");
            }
            csvContent.AppendLine();
        }

        return csvContent.ToString();
    }
}

public static class FileUtility
{
    public static void SaveCsvToFile(string csvContent, string filePath)
    {
        File.WriteAllText(filePath, csvContent);
    }
}