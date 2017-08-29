using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IkLibrary.Unity;
using System.IO;
namespace Experiment
{

    public class DataWriter : SingletonMonoBehaviour<DataWriter>
    {
        void Awake ()
        {
            DontDestroyOnLoad (gameObject);
        }
        string name = "hoge";
        string filename;
        string extension = ".csv";

        StreamWriter sw;
        // Use this for initialization
        void Start ()
        {


        }

        // Update is called once per frame
        void Update ()
        {

        }

        public void InitializeFile ()
        {
            filename = name + extension;

            FileStream fs = File.Create (Application.dataPath + "/ExperimentData/" + filename);

            Debug.Log (fs.Name);
            // ファイルストリームを閉じて、変更を確定させる
            // 呼ばなくても using を抜けた時点で Dispose メソッドが呼び出される
            fs.Close ();


            FileInfo fi = new FileInfo (Application.dataPath + "/ExperimentData/" + filename);
            sw = fi.AppendText ();
            sw.WriteLine ("test output");
        }



        public void WriteWord ( string word )
        {
            sw.Write (word + ",");
        }

        public void CloseFile ()
        {
            sw.Flush ();
            sw.Close ();
        }

    }
}