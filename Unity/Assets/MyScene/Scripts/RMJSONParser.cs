using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Redmine
{



    public class RMJSONParser : MonoBehaviour
    {
        public static RMJSONParser instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

        //Awake is always called before any Start functions
        void Awake()
        {
            //Check if instance already exists
            if (instance == null)
            {
                //if not, set instance to this
                instance = this;
            }
            //If instance already exists and it's not this:
            else if (instance != this)
            {
                //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
                Destroy(gameObject);
            }

            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(gameObject);
        }

        // Start is called before the first frame update
        void Start()
        {
            string url = "http://192.168.14.15:8080/redmine/issues.json?key=1265c48123078667f3e94a8224796f30fe4df4ef";

            StartCoroutine(WebRequest(url));
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        IEnumerator WebRequest(string url)
        {
            UnityWebRequest request = new UnityWebRequest();
            using (request = UnityWebRequest.Get(url))
            {
                yield return request.SendWebRequest();

                if (request.isNetworkError)
                {
                    Debug.Log(request.error);
                }
                else
                {
                    Debug.Log(request.downloadHandler.text);
                    Issues myIssues =  LoadJsonFile<Issues>(request.downloadHandler.text);
                    Debug.Log(myIssues);
                }
            }
        }

        T LoadJsonFile<T>(string data)
        {
            return JsonUtility.FromJson<T>(data);
        }
    }



    [System.Serializable]
    public class Issues
    {

        public List<Issue> Issue;
    }

    [System.Serializable]
    public class Issue
    {
        public int id;
        public Project project;
        public Tracker tracker;
        public Status status;
        public Priority priority;
        public Author author;
    }

    [System.Serializable]
    public class Project
    {
        public int id;
        public string name;
    }

    [System.Serializable]
    public class Tracker
    {
        public int id;
        public string name;
    }

    [System.Serializable]
    public class Status
    {
        public int id;
        public string name;
    }

    [System.Serializable]
    public class Priority
    {
        public int id;
        public string name;
    }

    [System.Serializable]
    public class Author
    {
        public int id;
        public string name;
    }

    [System.Serializable]
    public class Parent
    {
        public int id;
    }

    [System.Serializable]
    public class Subject
    {
        public int id;
    }

    [System.Serializable]
    public class Description
    {
        public string desc;
    }

    [System.Serializable]
    public class DueDate
    {
        public string date;
    }

    [System.Serializable]
    public class DoneRatio
    {
        public int ratio;
    }

    [System.Serializable]
    public class is_private
    {
        public bool isPrivate;
    }

    [System.Serializable]
    public class EstimatedHours
    {
        public string date;
    }

} // end namespace