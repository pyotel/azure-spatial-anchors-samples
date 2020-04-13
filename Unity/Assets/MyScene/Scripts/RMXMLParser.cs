using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.Networking;

namespace Redmine
{
    public class RMXMLParser : MonoBehaviour
    {
        public static RMXMLParser instance = null; 
        void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }
        void Start()
        {
            string url = "http://192.168.14.15:8080/redmine/issues.xml?key=1265c48123078667f3e94a8224796f30fe4df4ef";

            StartCoroutine(WebRequest(url));
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
                    LoadXML(request.downloadHandler.text);
                }
            }
        }

        private void LoadXML(string data)
        {
            XmlDocument xmlDoc = new XmlDocument();
            Debug.Log(data);
            xmlDoc.LoadXml(data);

            // 하나씩 가져오기 테스트 예제.
            XmlNodeList cost_Table = xmlDoc.GetElementsByTagName("issue");
            foreach (XmlNode cost in cost_Table)
            {
                Debug.Log("[one by one] cost : " + cost.InnerText);
            }

            // 전체 아이템 가져오기 예제.
            XmlNodeList all_nodes = xmlDoc.SelectNodes("issues/issue");
            foreach (XmlNode node in all_nodes)
            {
                // 수량이 많으면 반복문 사용.
                Debug.Log("[at once] id :" + node.SelectSingleNode("id").InnerText); // 이너텍스트 얻기
                Debug.Log("[at once] subject : " + node.SelectSingleNode("subject").InnerText);

                XmlNode node_project = node.SelectSingleNode("project"); //속성값 얻기
                Debug.Log("[at once] project name : " + node_project.Attributes["name"].Value);
                Debug.Log("[at once] project id : " + node_project.Attributes["id"].Value);

            }
        }
    }

} // end namespace