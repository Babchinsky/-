using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Drawing;
namespace Explorer
{
    public partial class Form1 : Form
    {


        ImageList image_list1 = new ImageList(); // список изображений для хранения малых значков
        ImageList image_list2 = new ImageList(); // список изображений для хранения больших значков
        ImageList image_list3 = new ImageList(); // список изображений для хранения больших значков


        string[] files;// = Directory.GetFiles(pathToFolder);
        string[] directories;// = Directory.GetDirectories(pathToFolder);
        string pathToFolder;
        public Form1()
        {
            InitializeComponent();
            Bitmap icon3 = new Bitmap(@"../../icons/back.png");
            toolStripButton1.Image = icon3;

             icon3 = new Bitmap(@"../../icons/forward.png");
            toolStripButton2.Image = icon3;
            icon3 = new Bitmap(@"../../icons/up.png");
            toolStripButton3.Image = icon3;
            icon3 = new Bitmap(@"../../icons/refresh.png");
            toolStripButton4.Image = icon3;

            icon3 = new Bitmap(@"../../icons/view.png");
            toolStripDropDownButton1.Image = icon3;


            string[] astrLogicalDrives = System.IO.Directory.GetLogicalDrives(); // System.Environment.GetLogicalDrives();

            foreach (string disk in astrLogicalDrives)
            {
                treeView1.Nodes.Add(disk);
            }
            Bitmap icon = new Bitmap(@"../../icons/hdd.png");
            Bitmap icon2 = new Bitmap(@"../../icons/folder.png");
            image_list3.Images.Add(icon);
            image_list3.Images.Add(icon2);
            treeView1.ImageList= image_list3;


            int i = 0;



            foreach (TreeNode item in treeView1.Nodes)
            {
               
              
                pathToFolder = astrLogicalDrives[i];
                directories = Directory.GetDirectories(pathToFolder);
                files = Directory.GetFiles(pathToFolder);
               
               
                foreach (var file in directories)
                    {
                  
                    item.Nodes.Add(file);
                    }

                foreach (var file in files)
                {

                    item.Nodes.Add(file);
                }

                i++;


               
            }


        }


       private void ShowFolder()
        {
            image_list1.ColorDepth = ColorDepth.Depth32Bit;

            // установим размер изображения
            image_list1.ImageSize = new Size(16, 16);

            // ассоциируем список маленьких изображений с ListView
            listView1.SmallImageList = image_list1;

            // глубина цвета изображений
            image_list2.ColorDepth = ColorDepth.Depth32Bit;

            // установим размер изображения
            image_list2.ImageSize = new Size(32, 32);

            // ассоциируем список маленьких изображений с ListView
            listView1.LargeImageList = image_list2;

           
            Icon icon = new Icon(@"../../CLSDFOLD.ICO");
            image_list1.Images.Add(icon);
            image_list2.Images.Add(icon);
            foreach (string dir in directories)
            {
                listView1.Items.Add(dir, 0);
            }
            int index = 1;
            foreach (string file in files)
            {
                icon = Icon.ExtractAssociatedIcon(file);
                image_list1.Images.Add(icon);
                image_list2.Images.Add(icon);
                listView1.Items.Add(file, index++);
            }
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {


            foreach (TreeNode item in e.Node.Nodes)
            {

                item.ImageIndex = 1;

                pathToFolder = item.Text;
                        try
                        {
                            directories = Directory.GetDirectories(pathToFolder);
                    files = Directory.GetFiles(pathToFolder);
                        }
                        catch
                        {
                            
                        }


                        foreach (var file in directories)
                        {
                            item.Nodes.Add(file);
                        }
                        foreach (var file in files)
                        {

                            item.Nodes.Add(file);
                        }



            }





        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
           
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            listView1.Clear();
            

         
           

            Icon icon = new Icon(@"../../CLSDFOLD.ICO");

      
            image_list1.Images.Add(icon);
            image_list2.Images.Add(icon);
            listView1.LargeImageList = image_list1;

            try
            {
                string[] directories = Directory.GetDirectories(e.Node.Text);
                foreach (string dir in directories)
                {
                    listView1.Items.Add(dir, 0);
                }
                int index = 1;
                foreach (string file in files)
                {
                    icon = Icon.ExtractAssociatedIcon(file);
                    image_list1.Images.Add(icon);
                    image_list2.Images.Add(icon);
                    listView1.Items.Add(file, index++);
                }
            }
            catch
            {

            }


        }
        TreeNode treeNodeForward;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            treeNodeForward = treeView1.SelectedNode;
            treeView1.SelectedNode = treeView1.SelectedNode.Parent;
       
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            treeView1.SelectedNode = treeNodeForward;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Index > 0)
            {
                treeView1.SelectedNode = treeView1.SelectedNode.PrevNode;
            }
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
    }
}
