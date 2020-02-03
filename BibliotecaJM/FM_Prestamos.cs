using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Prestamos : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
        }
        
        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            int id;
            lectoresTableAdapter.FillByID(dS_Lectores, int.TryParse(tbIdentificador.Text, out id) ? id : 0);

            if (dS_Lectores.lectores.Count > 0)
                librosPrestadosTableAdapter.FillByLectores_IDS(dS_LibrosPrestados, dS_Lectores.lectores[0].id_lec);



        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByNombre(lectoresDS.lectores, tbNombre.Text);
        }

        private void lectoresDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int position = lectoresBindingSource.Position;
            librosPrestadosTableAdapter.FillByLectores_IDS(prestamosDS.LibrosPrestados, lectoresDS.lectores[position].id_lec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            librosTableAdapter.FillByID(librosDS.libros, int.TryParse(tbBuscarIDLibro.Text, out id) ? id : 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByTitulo(librosDS.libros, tbBuscarTitulo.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByAutor(librosDS.libros, tbBuscarAutor.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            // TODO: esta línea de código carga datos en la tabla 'dS_LibrosPrestados.LibrosPrestados' Puede moverla o quitarla según sea necesario.
            this.librosPrestadosTableAdapter.Fill(this.dS_LibrosPrestados.LibrosPrestados);
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);

        }
    }
}
