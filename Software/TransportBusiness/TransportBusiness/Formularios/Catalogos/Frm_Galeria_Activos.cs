using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using CapaDeDatos;
using System.IO;

namespace TransportBusiness
{
    public partial class Frm_Galeria_Activos : DevExpress.XtraEditors.XtraForm
    {
        GalleryItemGroup group1 = new GalleryItemGroup();

        public string Valor { get;  set; }
        public string Descripction { get;  set; }
        public string vId_Activo { get; set; }
        public int Serie { get; set; }

        public Frm_Galeria_Activos()
        {
            InitializeComponent();
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenDialog.Filter = "Formato de imagen PNG (*.png)|*.png |Formato de imagen JPEG (*.jpg)|*.jpg|La extensión de imagen .gif (*.gif)|*.gif";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); ;
            OpenDialog.Title = "Cargar Imagenes";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if( result == DialogResult.OK )
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                args.Caption = "Ingrese la descripcion de la imagen";
                args.Prompt = "Descripción";
                args.DefaultButtonIndex = 0;
                //args.Showing += Args_Showing;
                // initialize a DateEdit editor with custom settings 
                TextEdit editor = new TextEdit();
                args.Editor = editor;
                // a default DateEdit value 
                args.DefaultResponse = "Descripcion de la Imagen";
                // display an Input Box with the custom editor
                args.Editor = textEdit;
                var result2 = XtraInputBox.Show(args).ToString();
                if (result2 != null)
                {
                    Descripction = result2;
                    gc.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
                    gc.Gallery.ImageSize = new Size(120, 90);
                    gc.Gallery.ShowItemText = true;
                    Serie++;
                    Valor = Serie.ToString();
                    Image im1 = Image.FromFile(OpenDialog.FileName);
                    byte[] arr = null;
                    arr = ImageAArray(im1);
                    group1.Items.Add(new GalleryItem(im1, Valor, Descripction));
                    CLS_Activos ins = new CLS_Activos();
                    ins.Id_Activo = vId_Activo;
                    ins.SerieImagen = Serie;
                    ins.Descripcion = Descripction;
                    ins.Imagen = arr;
                    ins.MtdInsertarActivoImagen();
                    if (!ins.Exito)
                    {
                        XtraMessageBox.Show(ins.Mensaje);
                    }
                }
            }
        }
        public byte[] ImageAArray(Image Imagen)
        {
            MemoryStream ms = new MemoryStream();
            Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void Frm_Galeria_Activos_Shown(object sender, EventArgs e)
        {
            group1.Caption = "Imagenes Activos";
            gc.Gallery.Groups.Add(group1);
            Serie = 0;
            //vId_Activo = "00000001";
            Cargar_Imagenes_Existentes(vId_Activo);
        }
        private void Cargar_Imagenes_Existentes(string vActivo)
        {
            CLS_Activos ins = new CLS_Activos();
            ins.Id_Activo = vId_Activo;
            ins.MtdSeleccionarActivoImagen();
            if(ins.Exito)
            {
                Serie = 0;
                for (int i = 0; i < ins.Datos.Rows.Count; i++)
                {
                    gc.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
                    gc.Gallery.ImageSize = new Size(120, 90);
                    gc.Gallery.ShowItemText = true;
                    
                    Valor = Serie.ToString();
                    Valor=ins.Datos.Rows[i]["Serie"].ToString();
                    Descripction = ins.Datos.Rows[i]["Descripcion"].ToString();
                    byte[] arr = (byte[])ins.Datos.Rows[i]["Imagen"];
                    Image im1 = byteArrayToImage(arr);
                    group1.Items.Add(new GalleryItem(im1, Valor, Descripction));
                    Serie = Convert.ToInt32(Valor);
                }
            }
        }
        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = XtraMessageBox.Show("¿Desea eliminar la imagen?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult == DialogResult.Yes)
            {
                GalleryItem item = gc.Gallery.GetCheckedItem();
                if (item != null)
                {
                    int vSerie = Convert.ToInt32(item.Caption);
                    CLS_Activos ins = new CLS_Activos();
                    ins.Id_Activo = vId_Activo;
                    ins.SerieImagen = vSerie;
                    ins.MtdEliminarActivoImagen();
                    if (!ins.Exito)
                    {
                        XtraMessageBox.Show(ins.Mensaje);
                    }
                    else
                    {
                        gc.Gallery.Groups[0].Items.Remove(item);
                    }
                }
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}