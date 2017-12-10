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
        private TGroupContext _context;

        public Form1()
        {
            InitializeComponent();

            //FormClosing += Form1_FormClosing;
            //_context = new TGroupContext("DbConnection");
            //CreateNewTGroupEntity("Имя505");
            //var res = _context.SaveChanges();
            //if (res < 0)
            //    MessageBox.Show(@"Возникли ошибки при создании объекта с названием 'Моя первая сущность'");

            //var idUpdate = 1;
            //UpdateName(idUpdate, "x1");
            //res = _context.SaveChanges();
            //if (res < 0)
            //    MessageBox.Show(@"Возникли ошибки при обновлении объекта с id = " + idUpdate);

            //var idDel = 1;
            //DeleteTGroupEntity(4);
            //res = _context.SaveChanges();
            //if (res < 0)
            //    MessageBox.Show(@"Возникли ошибки при удалении объекта, у которгоid = " + idDel);

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
                TPropertyContext tPropertyContext = new TPropertyContext("DbConnection");

                var tRelationEntity = tRelationContext.TRelationProperty;
                var tGroupEntity = tGroupContext.TGroupProperty;
                var tPropertyEntity = tPropertyContext.TPropertyProperty;

                foreach (TPropertyClass g in tPropertyEntity)
                {
                    Console.WriteLine("{0} {1} {2} {3}", g.id, g.name, g.value, g.group_id);
                }


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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void CreateNewTGroupEntity(string name)
        {
            if (_context == null) return;

            var newEntity = new TGroupClass()
            {
                //id = maxId,
                name = name
            };

            _context.TGroupProperty.Add(newEntity);
        }

        private void UpdateName(int id, string name)
        {
            if (_context == null) return;

            var TGroupEntityForUpdate = _context.TGroupProperty.FirstOrDefault(x => x.id == id);
            if (TGroupEntityForUpdate == null)
            {
                MessageBox.Show(@"Объект, предназначенный для обновления, не найден");
                return;
            }

            TGroupEntityForUpdate.name = name;
        }

        private void DeleteTGroupEntity(int id)
        {
            if (_context == null) return;

            var TGroupEntityForDelete = _context.TGroupProperty.SingleOrDefault(x => x.id == id);
            if (TGroupEntityForDelete == null)
            {
                MessageBox.Show($@"Объект с id = {id}не найден!");
                return;
            }

            _context.TGroupProperty.Remove(TGroupEntityForDelete);
        }
    }
}
