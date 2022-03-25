namespace DbPostgreUno
{
    public partial class Form1 : Form
    {
        //Se declara y crea una instancia de la clase DAOPostgres
        DAOPostgres model = new DAOPostgres();

        //Constructor por default llamando al método InitializeComponent();
        public Form1()
        {
            InitializeComponent();
        }

        //Método button1_Click para establecer la conexión a la DB
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                model.establecerConexion();
            }
            else if(radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                model.cerrarConexionADb();
            }
        }

        //Método Cargar permite cargar los elementos de la consulta a un objeto de de la clase List retornando una lista 
        //public List<Modelo> Cargar()
        //{
        //    DAOPostgres daoPost = new DAOPostgres();
        //    List<Modelo> modeloList = daoPost.consultar();
        //    return modeloList;
        //}

        //Metodo CargarId permite cargar los elementos de la busqueda por id a un objeto de la clase List retornando una lista
        public List<Modelo> CargarId()
        {
            DAOPostgres daoPost = new DAOPostgres();
            List<Modelo> modeloList = daoPost.buscarId(int.Parse(textBox1.Text));
            return modeloList;
        }
        //Metodo CargarNombre permite cargar los elementos de la busqueda por id a un objeto de la clase List retornando una lista
        public List<Modelo> CargarNombre()
        {
            DAOPostgres daoPost = new DAOPostgres();
            List<Modelo> modeloList = daoPost.buscarNombre(textBox1.Text);
            return modeloList;
        }


        //Metodo CargarAño permite cargar los elementos de la busqueda por id a un objeto de la clase List retornando una lista
        public List<Modelo> CargarAño()
        {
            DAOPostgres daoPost = new DAOPostgres();
            List<Modelo> modeloList = daoPost.buscarAño(int.Parse(textBox1.Text));
            return modeloList;
        }
        //Método que permite llemar el datagridView con los elementos contenidos en la Lista 
        public void LlenarDataGridView(List<Modelo> modeloList)
        {
            if (modeloList != null)
            {
                dgv_control.DataSource = modeloList;

            }
        }

        //Método que permite mostrar los elementos en el datagridView
        private void button2_Click(object sender, EventArgs e)
        {
            if (btnId.Checked == true)
            {
                try
                {
                    List<Modelo> modeloList = CargarId();
                    LlenarDataGridView(modeloList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex);
                }
            }
            else if (btnNombre.Checked == true)
            {
                try
                {
                    List<Modelo> modeloList = CargarNombre();
                    LlenarDataGridView(modeloList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex);
                }
            }
            else if(btnAnio.Checked == true){
                try
                {
                    List<Modelo> modeloList = CargarAño();
                    LlenarDataGridView(modeloList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex);
                }
            }

        }
    }
}