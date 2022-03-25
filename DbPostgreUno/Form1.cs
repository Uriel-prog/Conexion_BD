namespace DbPostgreUno
{
    public partial class Form1 : Form
    {
        //Se declara y crea una instancia de la clase DAOPostgres
        DAOPostgres model = new DAOPostgres();

        //Constructor por default llamando al m�todo InitializeComponent();
        public Form1()
        {
            InitializeComponent();
        }

        //M�todo button1_Click para establecer la conexi�n a la DB
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

        //M�todo Cargar permite cargar los elementos de la consulta a un objeto de de la clase List retornando una lista 
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


        //Metodo CargarA�o permite cargar los elementos de la busqueda por id a un objeto de la clase List retornando una lista
        public List<Modelo> CargarA�o()
        {
            DAOPostgres daoPost = new DAOPostgres();
            List<Modelo> modeloList = daoPost.buscarA�o(int.Parse(textBox1.Text));
            return modeloList;
        }
        //M�todo que permite llemar el datagridView con los elementos contenidos en la Lista 
        public void LlenarDataGridView(List<Modelo> modeloList)
        {
            if (modeloList != null)
            {
                dgv_control.DataSource = modeloList;

            }
        }

        //M�todo que permite mostrar los elementos en el datagridView
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
                    List<Modelo> modeloList = CargarA�o();
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