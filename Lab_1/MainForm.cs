using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDS.RDF.Parsing;

namespace Lab_1
{
    public partial class MainForm : Form
    {
        KnowledgeBase k_Base;
        public MainForm()
        {
            InitializeComponent();
        }

        // Подключение к БЗ
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Выбор БЗ и построение дерева
                DataConnection d_DataConnection = new DataConnection();
                if (d_DataConnection.ShowDialog() != DialogResult.Cancel)
                {
                    // Очистка таблицы и заголовка таблицы
                    d_Table.DataSource = null;
                    l_Element.Text = "";
                    // Подключение к БЗ
                    k_Base = new KnowledgeBase(d_DataConnection.GetPath);
                    // Получение дерева
                    t_Tree.Nodes.Clear();
                    t_Tree.Nodes.Add(k_Base.GetTree());
                    t_Tree.SelectedNode = t_Tree.TopNode;
                    if (t_Tree.TopNode != null)
                    {
                        // Заполнение таблицы
                        Table.OutputInfoInTable(t_Tree.SelectedNode, d_Table, k_Base);
                        // Заголовок таблицы
                        l_Element.Text = t_Tree.SelectedNode.Text;
                    }
                }
            }
            catch(RdfParseException ex)
            {
                MessageBox.Show("Ошибка в базе знаний: " + ex.Message);
            }
        }

        // Завершение работы
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            k_Base.Dispose();
            this.Close();
        }

        // Вывод информации в таблицу
        private void t_Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Заполнение таблицы
            Table.OutputInfoInTable(e.Node, d_Table, k_Base);
            // Заголовок таблицы
            l_Element.Text = e.Node.Text;
        }
    }
}
