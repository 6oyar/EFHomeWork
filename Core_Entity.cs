using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinApp
{
    public partial class Core_Entity : Form
    {
        TGroupContext tGroupContext;
        DbSet<TGroupClass> tGroupEntities;
        TPropertyContext tPropertyContext;
        DbSet<TPropertyClass> tPropertyEntities;
        TRelationContext tRelationContext;
        DbSet<TRelationClass> tRelationEntities;

        private string workMode = "";

        public Core_Entity()
        {
            tGroupContext = new TGroupContext("DbConnection");
            tGroupEntities = tGroupContext.TGroupProperty;
            tPropertyContext = new TPropertyContext("DbConnection");
            tPropertyEntities = tPropertyContext.TPropertyProperty;
            tRelationContext = new TRelationContext("DbConnection");
            tRelationEntities = tRelationContext.TRelationProperty;

            InitializeComponent();
            this.InitRootGroup();

        }

        private void groupName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveGroup_Button_Click(object sender, EventArgs e)
        {
            if (workMode.Equals("Edit"))
            {
                TreeNode currentNode = treeView1.SelectedNode;

                if (tGroupContext == null) return;

                int id = Convert.ToInt32(groupId_TextBox.Text);
                string name = groupName_TextBox.Text;

                var TGroupEntityForUpdate = tGroupContext.TGroupProperty.FirstOrDefault(x => x.id == id);
                if (TGroupEntityForUpdate == null)
                {
                    MessageBox.Show(@"Объект, предназначенный для обновления, не найден");
                    return;
                }

                TGroupEntityForUpdate.name = name;
                groupEditing_GroupBox.Enabled = false;
                tGroupContext.SaveChanges();
            }
            else if (workMode == "Add")
            {
                TreeNode currentNode = treeView1.SelectedNode;

                if (currentNode.Name.Contains("TProperty")) return;
                var name = currentNode.Name;
                int parentId = Convert.ToInt32(Regex.Replace(name, @"[^\d]+", ""));

                //find maxId in group
                int maxId = -1;
                foreach (var entity in tGroupEntities)
                {
                    if (entity.id > maxId) maxId = entity.id;
                }
                maxId++;


                if (!groupName_TextBox.Text.Equals(""))
                {
                    var groupEntity = new TGroupClass()
                    {
                        id = maxId,
                        name = groupName_TextBox.Text
                    };
                    tGroupEntities.Add(groupEntity);

                    TreeNode newNode = new TreeNode()
                    {
                        Text = groupName_TextBox.Text,
                        Name = maxId + "|Group"
                    };

                    var relationEntity = new TRelationClass()
                    {
                        idPparent = parentId,
                        idChild = maxId
                    };


                    TreeNode tech = new TreeNode()
                    {
                        Text = "TechnicalGroup",
                        Name = "TechnicalGroup"
                    };
                    newNode.Nodes.Add(tech);
                    currentNode.Nodes.Add(newNode);
                    tGroupContext.SaveChanges();

                    tRelationEntities.Add(relationEntity);
                    tRelationContext.SaveChanges();
                }
                groupId_TextBox.Enabled = true;
                groupId_TextBox.Text = "";
                groupEditing_GroupBox.Enabled = false;

            }
        }

        private void groupAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workMode = "Add";
            this.groupEditing_GroupBox.Enabled = true;
            this.propertyEditing_GroupBox.Enabled = false;
            groupId_TextBox.Enabled = false;




        }

        private void propertyAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workMode = "Add";
            this.groupEditing_GroupBox.Enabled = false;
            this.propertyEditing_GroupBox.Enabled = true;
            propertyId_TextBox.Enabled = false;
        }


        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            workMode = "Add";
            var expandedNode = e.Node;
            if (expandedNode == null)
            {
                this.statusLabel.Text = "Ошибка при открытии элемента";
                return;
            }

            e.Node.Nodes.Remove(e.Node.Nodes[0]);


            string name = expandedNode.Name;
            int parentId = Convert.ToInt32(Regex.Replace(name, @"[^\d]+", ""));
            foreach (var entity in tPropertyEntities)
            {
                if (entity.group_id == parentId)
                {
                    TreeNode propertyNode = new TreeNode()
                    {
                        Text = entity.name,
                        Name = entity.id + "|Property"
                    };
                    e.Node.Nodes.Add(propertyNode);
                }
            }

            foreach (var entity in tRelationEntities)
            {
                if (entity.idPparent == parentId)
                {
                    var childEntity = tGroupEntities.Find(entity.idChild);
                    TreeNode childNode = new TreeNode()
                    {
                        Text = childEntity.name,
                        Name = childEntity.id + "|Group"
                    };
                    TreeNode tech = new TreeNode()
                    {
                        Text = "TechnicalGroup",
                        Name = "TechnicalGroup"
                    };

                    childNode.Nodes.Add(tech);
                    e.Node.Nodes.Add(childNode);
                }
            }



        }

        private void Core_Entity_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void InitRootGroup()
        {


            var tGroupEntity = tGroupEntities.Find(1);
            if (tGroupEntity == null)
            {
                this.statusLabel.Text = "Корневой элемент не найден";
                return;
            }
            
            TreeNode root = new TreeNode()
            {
                Text = tGroupEntity.name,
                Name = tGroupEntity.id + "|Group"
            };
            


            TreeNode tech = new TreeNode()
            {
                Text = "TechnicalGroup",
                Name = "TechnicalGroup"
            };
            root.Nodes.Add(tech);
            treeView1.Nodes.Add(root);

        }

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            while (true)
            {
                try
                {
                    var node = e.Node.Nodes[0];
                }
                catch (Exception ex)
                {
                    break;
                }
                e.Node.Nodes.Remove(e.Node.Nodes[0]);
            }

            TreeNode tech = new TreeNode()
            {
                Text = "TechnicalGroup",
                Name = "TechnicalGroup"
            };
            e.Node.Nodes.Add(tech);


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workMode = "Edit";
            TreeNode currentNode = treeView1.SelectedNode;
            string currentNodeName = currentNode.Name;

            if (currentNodeName.Contains("Group"))
            {
                groupEditing_GroupBox.Enabled = true;
                propertyEditing_GroupBox.Enabled = false;
                string currentNodeNameId = Regex.Replace(currentNodeName, @"[^\d]+", "");
                groupId_TextBox.Text = currentNodeNameId;
                groupName_TextBox.Text = currentNode.Text;
            }
            else if (currentNodeName.Contains("Property"))
            {
                propertyEditing_GroupBox.Enabled = true;
                groupEditing_GroupBox.Enabled = false;
                string currentNodeNameId = Regex.Replace(currentNodeName, @"[^\d]+", "");
                var TPropertyEntity = tPropertyContext.TPropertyProperty.Find(Convert.ToInt32(currentNodeNameId));
                propertyId_TextBox.Text = currentNodeNameId;
                propertyValue_TextBox.Text = TPropertyEntity.value;
                propertyName_TextBox.Text = currentNode.Text;
            }
            string currentNodeNext = currentNode.Text;
        }

        private void cancelGroup_Button_Click(object sender, EventArgs e)
        {
            groupId_TextBox.Text = "";
            groupName_TextBox.Text = "";

            propertyId_TextBox.Text = "";
            propertyName_TextBox.Text = "";
            propertyValue_TextBox.Text = "";

            groupEditing_GroupBox.Enabled = false;
        }

        private void cancelProperty_Button_Click(object sender, EventArgs e)
        {
            propertyId_TextBox.Text = "";
            propertyName_TextBox.Text = "";
            propertyValue_TextBox.Text = "";

            groupId_TextBox.Text = "";
            groupName_TextBox.Text = "";

            propertyEditing_GroupBox.Enabled = false;
        }

        private void saveProperty_Button_Click(object sender, EventArgs e)
        {
            if (workMode == "Edit")
            {
                TreeNode currentNode = treeView1.SelectedNode;

                if (tGroupContext == null) return;

                int id = Convert.ToInt32(propertyId_TextBox.Text);
                string name = propertyName_TextBox.Text;
                string value = propertyValue_TextBox.Text;

                var TPropertyEntityForUpdate = tPropertyContext.TPropertyProperty.FirstOrDefault(x => x.id == id);
                if (TPropertyEntityForUpdate == null)
                {
                    MessageBox.Show(@"Объект, предназначенный для обновления, не найден");
                    return;
                }

                TPropertyEntityForUpdate.name = name;
                TPropertyEntityForUpdate.value = value;
                propertyEditing_GroupBox.Enabled = false;

                tPropertyContext.SaveChanges();
            }
            else if (workMode == "Add")
            {
                TreeNode currentNode = treeView1.SelectedNode;
                var name = currentNode.Name;
                int parentId = Convert.ToInt32(Regex.Replace(name, @"[^\d]+", ""));

                //find maxId in property
                int maxId = -1;
                foreach (var entity in tPropertyEntities)
                {
                    if (entity.id > maxId) maxId = entity.id;
                }
                maxId++;


                if ( !propertyName_TextBox.Text.Equals("") )
                {
                    var propertyEntity = new TPropertyClass()
                    {
                        id = maxId,
                        name = propertyName_TextBox.Text,
                        value = propertyValue_TextBox.Text,
                        group_id = parentId
                    };
                    tPropertyEntities.Add(propertyEntity);

                    TreeNode newNode = new TreeNode()
                    {
                        Text = propertyName_TextBox.Text,
                        Name = maxId + "|Property"
                    };
                    


                   
                    currentNode.Nodes.Add(newNode);
                    tPropertyContext.SaveChanges();
                }
                propertyId_TextBox.Enabled = true;
                propertyId_TextBox.Text = "";
                propertyValue_TextBox.Text = "";
                propertyName_TextBox.Text = "";
                groupEditing_GroupBox.Enabled = false;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode currentNode = treeView1.SelectedNode;
            
            if (currentNode.Name.Contains("Group"))
            {
                int currentNodeId = Convert.ToInt32(Regex.Replace(currentNode.Name, @"[^\d]+", ""));

                var tPropertyEntities = tPropertyContext.TPropertyProperty;

                foreach (var entity in tPropertyEntities)
                {
                    if (entity.group_id == currentNodeId)
                    {
                        tPropertyEntities.Remove(entity);
                    }
                }

                var tRelationEntities = tRelationContext.TRelationProperty;

                foreach (var entity in tRelationEntities)
                {
                    if (entity.idPparent == currentNodeId || entity.idChild == currentNodeId )
                    {
                        tRelationEntities.Remove(entity);
                    }
                }

                var tGroupEntities = tGroupContext.TGroupProperty;
                foreach (var entity in tGroupEntities)
                {
                    if ( entity.id == currentNodeId)
                    {
                        tGroupEntities.Remove(entity);
                    }
                }
                currentNode.Remove();
                var s = tPropertyContext.SaveChanges();
                s = tRelationContext.SaveChanges();
                s = tGroupContext.SaveChanges();
            }
            else if (currentNode.Name.Contains("Property"))
            {
                int currentNodeId = Convert.ToInt32(Regex.Replace(currentNode.Name, @"[^\d]+", ""));

                var tPropertyEntities = tPropertyContext.TPropertyProperty;

                foreach (var entity in tPropertyEntities)
                {
                    if (entity.group_id == currentNodeId)
                    {
                        tPropertyEntities.Remove(entity);
                    }
                }
                currentNode.Remove();
                tPropertyContext.SaveChanges();
            }
        }
    }
}
