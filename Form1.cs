using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TestWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Пробуем подключиться к серверу...";
                TGroupContext tGroupContext = new TGroupContext("DbConnection");
                TRelationContext tRelationContext = new TRelationContext("DbConnection");
                var tRelationEntity = tRelationContext.TRelationProperty;
                var tGroupEntity = tGroupContext.TGroupProperty;
                foreach (TGroupClass g in tGroupEntity)
                {
                    Console.WriteLine("{0} {1}", g.id, g.name);
                }

                foreach (TRelationClass g in tRelationEntity)
                {
                    Console.WriteLine("{0} {1}", g.idPparent, g.idChild);
                }
                label1.Text = "Подключение прошло успешно!";
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); label1.Text = "Не удалось подключиться. Проверьте, правильно ли указано имя подключения."; }
        }
    }
}
