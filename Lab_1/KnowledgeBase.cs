using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using System.Windows.Forms;
using System.Data;

namespace Lab_1
{
    // Работа с базой знаний
    public partial class KnowledgeBase:IDisposable
    {
        // Переменная для хранения БЗ
        Graph g_Graph;
        // Переменная для получения БЗ
        Notation3Parser n_Parser;
        // Строка подключения к БЗ
        string s_Path;

        public KnowledgeBase(string s_Path)
        {
            g_Graph = new Graph();
            n_Parser = new Notation3Parser();
            this.s_Path = s_Path;
        }

        // Получение дерева из БЗ
        public TreeNode GetTree()
        {

            // Получение БЗ из файла
            n_Parser.Load(g_Graph, s_Path);

            // Получение корневого узла
            TreeNode t_Node = GetRootTree();

            // Получение остальных узлов
            GetChildNodes(t_Node);

            return t_Node;
        }

        // Получение остальных узлов дерева
        private void GetChildNodes(TreeNode t_Node)
        {
            // Получение подпроцессов
            SparqlResultSet s_ChildNodes = GetSubprocess(t_Node.Name);
            if (s_ChildNodes.Count == 0)
            { return; }
            foreach (SparqlResult s_ChildNode in s_ChildNodes)
            {
                TreeNode t_ChildNode = new TreeNode(s_ChildNode["label"].ToString());
                t_ChildNode.Name = GetName(s_ChildNode["process"]);
                t_Node.Nodes.Add(t_ChildNode);
                GetChildNodes(t_ChildNode);
            }
        }

        // Получение подпроцессов
        private SparqlResultSet GetSubprocess(string s_Name)
        {
            return (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getsubprocess",s_Name));
        }

        // Получение корневого узла
        private TreeNode GetRootTree()
        {
            SparqlResultSet r_ResultSet = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getrootnode"));
            TreeNode t_Node = new TreeNode(r_ResultSet[0]["label"].ToString());
            t_Node.Name = GetName(r_ResultSet[0]["process"]);
            return t_Node;
        }

        // Получение имени из узла
        private string GetName(INode i_Node, string s_Prefix = "ins:")
        {
            string s_String = i_Node.ToString();
            string[] s_Mass = s_String.Split(':');
            return s_Prefix + s_Mass[s_Mass.Length - 1].Replace("stock", "");
        }

        // Получение данных узла (KPI и тд)
        public DataTable GetNodeData(TreeNode t_Node)
        {
            // Получение информации узлов
            string[] s_KPIs = GetNodeDataArray("getkpi",t_Node.Name);
            string[] s_Executors = GetNodeDataArray("getexecutors", t_Node.Name);
            string[] s_Inputs = GetNodeDataArray("getinputs", t_Node.Name);
            string[] s_Outputs = GetNodeDataArray("getoutputs", t_Node.Name);

            // Заполнение DataTable
            DataTable d_Table = new DataTable();
            // Добавление столбцов
            d_Table.Columns.Add("KPI");
            d_Table.Columns.Add("Исполнитель");
            d_Table.Columns.Add("Вход");
            d_Table.Columns.Add("Выход");

            // Получение количества строк таблицы
            List<string[]> s_Data = new List<string[]>() { s_KPIs, s_Executors, s_Inputs, s_Outputs };
            int i_CountRows =  s_Data.Aggregate((s, a) => a.Length > s.Length ? a : s).Length;
            // Добавление строк со значениями
            for (int i=0;i< i_CountRows; i++)
            {
                // Получение значений для каждой строки
                string[] s_Values = new string[s_Data.Count];
                for (int j=0;j<s_Data.Count;j++)
                {
                    if (i<s_Data[j].Length)
                    {
                        s_Values[j] = s_Data[j][i];
                    }
                    else
                    {
                        s_Values[j] = "";
                    }
                }
                // Добавление строки в таблицу
                d_Table.Rows.Add(s_Values);
            }

            return d_Table;
        }

        // Получение массивов KPI, исполнителей и тд
        private string[] GetNodeDataArray(string s_Key,string s_Name)
        {
            // Получение информации и запись в массив
            SparqlResultSet s_Result = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests(s_Key, s_Name));
            string[] s_ResultArray = new string[s_Result.Count];
            for (int i=0;i<s_Result.Count;i++)
            {
                s_ResultArray[i] = s_Result[i]["label"].ToString();
            }

            return s_ResultArray;
        }

        // Освобождение ресурсов
        public void Dispose()
        {
            g_Graph.Dispose();
            n_Parser = null;
        }
    }
}
