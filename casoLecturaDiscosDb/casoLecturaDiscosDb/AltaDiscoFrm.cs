using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace casoLecturaDiscosDb
{
    public partial class AltaDiscoFrm : Form
    {
        private Disco disco = null;
        private OpenFileDialog archivo = null;
        
        public AltaDiscoFrm()
        {
            InitializeComponent();
        }

        public AltaDiscoFrm(Disco disco)
        {
            this.disco = disco;
            InitializeComponent();
            Text = "Modificar Disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarForm()
        {
            if(string.IsNullOrEmpty(tbxTitulo.Text)) {
                MessageBox.Show("Por favor, complete el título del álbum para continuar.");
                return true;
            }
            if (string.IsNullOrEmpty(tbxCantidadCanciones.Text))
            {
                MessageBox.Show("Por favor, complete la cantidad de canciones del álbum para continuar.");
                return true;
            }
            if (!(soloNumeros(tbxCantidadCanciones.Text)))
            {
                MessageBox.Show("Por favor, ingrese solo números en Cantidad de canciones.");
                return true;
            }
            if(cbEstilo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un estilo musical para el álbum.");
                return true;
            }
            if(cbTipoEdicion.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el tipo de edición del álbum.");
                return true;
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {   
                if(disco == null)
                {
                    disco = new Disco();
                }
                if (validarForm())
                    return;
                
                disco.Titulo = tbxTitulo.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.CantidadCanciones = int.Parse(tbxCantidadCanciones.Text);
                disco.UrlImagenTapa = tbxUrlImagen.Text;
                disco.Estilo = (Estilo)cbEstilo.SelectedItem;
                disco.Edicion = (TipoEdicion)cbTipoEdicion.SelectedItem;

                if(disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");
                }

                if(archivo != null && !(tbxUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName,ConfigurationManager.AppSettings["discos-images"] + archivo.SafeFileName);


                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaDiscoFrm_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio edicioNegocio = new TipoEdicionNegocio();

            try
            {
                cbEstilo.DataSource = estiloNegocio.listar();
                cbEstilo.ValueMember = "Id";
                cbEstilo.DisplayMember = "Descripcion";
                cbEstilo.SelectedItem = null;
                cbTipoEdicion.DataSource = edicioNegocio.listar();
                cbTipoEdicion.ValueMember = "Id";
                cbTipoEdicion.DisplayMember = "Descripcion";
                cbTipoEdicion.SelectedItem = null;

                if(disco != null )
                {
                    tbxTitulo.Text = disco.Titulo;
                    dtpFechaLanzamiento.Value = disco.FechaLanzamiento;
                    tbxCantidadCanciones.Text = disco.CantidadCanciones.ToString();
                    tbxUrlImagen.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cbEstilo.SelectedValue = disco.Estilo.Id;
                    cbTipoEdicion.SelectedValue = disco.Edicion.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxUrlImagen.Load(imagen);

            }
            catch (Exception)
            {

                pbxUrlImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8TrfhVXyRtTKud_EqvLkVVInC76ZdnCz4OwTxOiyXyA&s");
            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                tbxUrlImagen.Text =archivo.FileName;
                cargarImagen(archivo.FileName);

            }

        }
    }
}
