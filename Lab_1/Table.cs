using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab_1
{
    // Работа с таблицей
    public static class Table
    {
        // Вывод данных в таблицу
        public static void OutputInfoInTable(TreeNode t_Node,DataGridView d_Table, KnowledgeBase k_Base)
        {
            // Получение данных в таблицу
            d_Table.DataSource = k_Base.GetNodeData(t_Node);
            // Настройка внешнего вида таблицы
            d_Table.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            d_Table.DefaultCellStyle.Font = new Font("Times New Roman", 12);
        }
    }
}
