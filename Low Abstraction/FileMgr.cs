using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WiW
{
    public class FileMgr
    {
        private Form bringToFront = new Form();
        private static FileMgr? instance;
        private string imgPath = "\\imgs";
        
        private string dataset { get; set; }
        private string queryPath { get { return dataset + "\\preguntas.csv"; } }

        private FileMgr()
        {
            dataset = Directory.GetCurrentDirectory();
            DirectoryInfo? d = Directory.GetParent(dataset);
            d = d.Parent!.Parent;
            dataset = d.FullName + "\\datasets";
        }

        public static FileMgr Instance()
        {
            if (instance == null)
                return instance = new FileMgr();
            return instance;
        }

        public void SetPath(string path)
        {
            dataset = path;
        }

        public Image Img(string nombre)
        {
            int err = 0;
            Func<Object> f = () => {
                if (err++ > 0)
                    imgPath = "";
                string path = dataset + imgPath + "\\" + nombre + ".png";
                return Image.FromFile(@path); 
            };
            return (Image)SecureRead(f, nombre + ".png");
        }

        public FileStream QueryFile()
        {
            Func<Object> f = () => { return File.OpenRead(queryPath); };
            return (FileStream) SecureRead(f, "preguntas.csv");
        }

        private Object SecureRead(Func<Object> f, string fileName)
        {
            bool noPath = true;
            while (noPath)
            {
                try
                {
                    return f.Invoke();
                }
                catch (Exception)
                {
                    DialogResult dr = MessageBox.Show("No se encontro la ubicacion del archivo "
                                    + fileName + ", \n\n¿ Desea buscarlo manualmente ?", 
                                    "Error", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes: noPath = ReadDatasetPath(); break;
                        case DialogResult.No: noPath = false; break;
                    }
                }
            }
            throw new Exception("No se pudo cargar el archivo");
        }

        private bool ReadDatasetPath()
        {
            OpenFileDialog folder = new OpenFileDialog();
            folder.CheckPathExists = true;
            bringToFront.TopMost= true;
            if (folder.ShowDialog(bringToFront) == DialogResult.OK)
            {
                string? path = Path.GetDirectoryName(folder.FileName);
                if (path != null)
                    dataset = path;
                else
                    return false;
            }
            return true;
        }
    }
}
