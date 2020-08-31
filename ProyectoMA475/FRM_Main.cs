using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;

namespace ProyectoMA475
{
    /*  
             * ------------------------------------------------------------ TO DO ------------------------------------------------------------ *
             *
             *------------------------------------------------ Proceso de abrir archivo ------------------------------------------------ *
             * Abrir una imagen primero
             * Primero copiamos la ruta de la imagen
             * Esta imagen que se ha abierto se le asigna al Bitmap inicial
             * Se establece el ancho y alto de la imagen
             * Se hace una copia del bitmap inicial al final
             * Finalmente se le asigna al pictureBox el bitmap final
             *
             *
             * ------------------------------------------------ Mostrar el histograma del archivo abierto ------------------------------------------------ *
             * Al abrir el archivo se debe verificar si esta en escala de grises o a color
             * Si esta a color se calculan los histogramas para cada color y se muestran las graficas RGB
             * Si esta en escala de grises se muestra solo la grafica de GRISES
             *
             *
             * ------------------------------------------------ Proceso de ecualizacion de histograma ------------------------------------------------ *
             * Si la imagen esta a color se lleva a escala de grises
             * Si la imagen ya esta en escala de grises, entonces se calcula el histograma
             * Una vez calculado el histograma se procede a ecualizar a imagen
             *
             *
             *
             * SIEMPRE QUE SE HAGA UN CAMBIO EN LA IMAGEN SE DEBE LIMPIAR, CALCULAR Y MOSTRAR HISTOGRAMA
    */

    public partial class FRM_Main : Form
    {
        private Bitmap bitInicio;
        private Bitmap bitFinal;
        private int ancho, alto;
        private string path = "";
        bool yaEcualizado = false; // Se utiliza para saber si ya se ha ecualizado una imagen
        private int[,] histograma = new int[3, 256]; // El arreglo es de (3 x 256), el tamaño de 3 se debe a que existen tres colores basicos RGB
                                                     // el tamaño de 256 representa el nivel de estos del 0 al 255
                                                     // Si una imagen esta en escala de grises los 3 colores basicos por pixel son iguales
                                                     // En una imagen en escala de grises el valor de ROJO, VERDE, AZUL son iguales
                                                     // Por eso para hallar el histograma en escala de grises solo debemos coger uno de los valores basicos y evaluar

        public FRM_Main()
        {
            InitializeComponent();
            InicializarPaneles();
            InicializarGraficas();
        }

        #region Basicos

        private void InicializarPaneles()
        {
            panelArchivo.Visible = false;
            panelOperaciones.Visible = false;
        } 
        private void EsconderSubMenu()
        {
            if (panelArchivo.Visible == true)
                panelArchivo.Visible = false;
            if (panelOperaciones.Visible == true)
                panelOperaciones.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void InicializarGraficas()
        {
            chartGrises.BackColor = Color.FromArgb(80, 80, 80); // Inicializa la grafica del histograma con color GRIS
            chartRojo.BackColor = Color.FromArgb(251, 118, 118); // Inicializa la grafica del histograma con color ROJO
            chartVerde.BackColor = Color.FromArgb(33, 163, 102); // Inicializa la grafica del histograma con color VERDE
            chartAzul.BackColor = Color.FromArgb(33, 102, 163); // Inicializa la grafica del histograma con color AZUL

            chartGrises.ChartAreas[0].BackColor = Color.FromArgb(80, 80, 80);
            chartRojo.ChartAreas[0].BackColor = Color.FromArgb(251, 118, 118);
            chartVerde.ChartAreas[0].BackColor = Color.FromArgb(33, 163, 102);
            chartAzul.ChartAreas[0].BackColor = Color.FromArgb(33, 102, 163);

            chartGrises.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(80, 80, 80);
            chartRojo.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(251, 118, 118);
            chartVerde.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(33, 163, 102);
            chartAzul.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(33, 102, 163);

            chartGrises.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartRojo.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartVerde.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartAzul.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartGrises.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartRojo.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartVerde.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartAzul.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void PanelOpciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelArchivo); 
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelOperaciones);
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void close_pic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void min_pic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FRM_Main_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Utilidades

        private void ConversionEscalaDeGrises()
        {
            // Esta funcion convierte una imagen a color a escala de grises
            float G = 0;
            int RED = 0, GREEN = 0, BLUE = 0;

            for (int x = 0; x < ancho; x++)
                for (int y = 0; y < alto; y++)
                {
                    RED = bitInicio.GetPixel(x, y).R;
                    GREEN = bitInicio.GetPixel(x, y).G;
                    BLUE = bitInicio.GetPixel(x, y).B;
                    G = RED * 0.299f + GREEN * 0.587f + BLUE * 0.114f;

                    bitFinal.SetPixel(x, y, Color.FromArgb((int)G, (int)G, (int)G));
                }

            imgPic.Image = bitFinal;
        }
        private bool VerificarImagen()
        {
            int cantPixeles = 0;

            for (int x = 0; x < ancho; x++)
                for (int y = 0; y < alto; y++)
                {
                    int R = bitFinal.GetPixel(x, y).R, G = bitFinal.GetPixel(x, y).G, B = bitFinal.GetPixel(x, y).B;
                    if (R == G && G == B)
                        cantPixeles++;
                    else
                        cantPixeles--;
                }

            if (cantPixeles == ancho * alto)
                // Imagen en escala de grises
                return true;
            else
                // Imagen a color
                return false;
        }
        private void LimpiarHistograma()
        {
            // Cada vez que abrimos un archivo o le hacemos algun cambio a la imagen debemos limpiar el arreglo histograma con 0s
            for (int rgb = 0; rgb < 3; rgb++)
                for (int i = 0; i < 256; i++)
                    histograma[rgb, i] = 0;
        }
        public void CalcularHistograma(int op)
        {
            // Al ser una imagen en escala de grises
            // El color rojo, verde, azul tienen el mismo valor
            for (int x = 0; x < ancho; x++)
                for (int y = 0; y < alto; y++)
                {
                    /*
                        bmp.GetPixel(x, y).R => consigue el valor de un pixel en una posicion (x, y) de la imagen
                        Nos colocamos en el arreglo histoGris[valor del pixel]
                        Por ejemplo si en la imagen hay 50 pixeles de valor 84
                        Entonces en histoGris[0, 84] = 50
                        Otro ejemplo si en la imagen hay 850 pixeles de valor 255
                        Entonces en histoGris[0, 255] = 850
                     */
                    if (op == 0)
                        histograma[0, bitFinal.GetPixel(x, y).R]++;
                    if (op == 1)
                    {
                        histograma[0, bitFinal.GetPixel(x, y).R]++;
                        histograma[1, bitFinal.GetPixel(x, y).G]++;
                        histograma[2, bitFinal.GetPixel(x, y).B]++;
                    }

                }

        }
        private void MostrarHistogramas(int op)
        {
            if (bitFinal != null)
            {
                chartGrises.Series["Series1"].Points.Clear();
                chartGrises.Series["Series1"].Color = Color.White;
                chartRojo.Series["Series1"].Points.Clear();
                chartRojo.Series["Series1"].Color = Color.White;
                chartVerde.Series["Series1"].Points.Clear();
                chartVerde.Series["Series1"].Color = Color.White;
                chartAzul.Series["Series1"].Points.Clear();
                chartAzul.Series["Series1"].Color = Color.White;

                for (int i = 0; i < 256; i++)
                {
                    if (op == 0)
                    {
                        chartGrises.Visible = true;

                        label2.Visible = true;

                        chartGrises.Series["Series1"].Points.AddXY(i + 1, histograma[0, i]);

                        chartRojo.Visible = false;
                        chartVerde.Visible = false;
                        chartAzul.Visible = false;

                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    if (op == 1)
                    {
                        chartRojo.Visible = true;
                        chartVerde.Visible = true;
                        chartAzul.Visible = true;

                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;

                        chartRojo.Series["Series1"].Points.AddXY(i + 1, histograma[0, i]);
                        chartVerde.Series["Series1"].Points.AddXY(i + 1, histograma[1, i]);
                        chartAzul.Series["Series1"].Points.AddXY(i + 1, histograma[2, i]);

                        chartGrises.Visible = false;

                        label2.Visible = false;
                    }
                }
            }
        }
        private void EcualizarHistograma()
        {
            int[] acumulado = new int[256];
            acumulado[0] = histograma[0, 0];

            // Calculo de arreglo acumulado
            for (int i = 1; i < 256; i++)
                acumulado[i] = histograma[0, i] + acumulado[i - 1];

            // Aqui se calcula el nuevo histograma ecualizado 
            // Cada valor del arreglo "resultado" representa un nivel de gris
            // Se multiplica el acumulado * ((2 ^ 8) - 1) esto dividido entre la cantidad total de pixeles
            // La operacion en si bota un numero decimal pero se redondea con Math.Floor();
            // Una vez hecha la operacion se guarda en el arreglo resultado[i] = nivel de gris

            int[] resultado = new int[256];
            for (int i = 0; i < 256; i++)
                resultado[i] = (int)Math.Floor(Convert.ToDecimal(255 * (acumulado[i]) / (ancho * alto)));

            
            // Se recorre la imagen
            for (int x = 0; x < ancho; x++)
                for (int y = 0; y < alto; y++)
                {
                    // Aqui se consigue de resultado el nivel de gris de un pixel en una determinada posicion
                    int nivelGris = resultado[bitFinal.GetPixel(x, y).R];
                    // En caso de que el nivel de gris es mayor a 255 entonces toma el valor de 255
                    if (nivelGris > 255) nivelGris = 255;
                    // Finalmente se hace set en cada pixel el nivel de gris calculado anteriormente
                    bitFinal.SetPixel(x, y, Color.FromArgb(nivelGris, nivelGris, nivelGris));
                }

            // Se copia en el pictureBox todos los cambios que se han hecho en bitFinal
            imgPic.Image = bitFinal;
        }
        
        #endregion

        #region PanelArchivos

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                if (path.Contains(".png") || path.Contains(".jpg") || path.Contains(".jpeg"))
                {
                    LimpiarHistograma();

                    yaEcualizado = false;

                    bitInicio = new Bitmap(path);
                    ancho = bitInicio.Width;
                    alto = bitInicio.Height;
                    
                    bitFinal = bitInicio;
                    
                    if(VerificarImagen())
                    {
                        CalcularHistograma(0);
                        MostrarHistogramas(0);
                    }
                    else
                    {
                        CalcularHistograma(1);
                        MostrarHistogramas(1);
                    }

                    imgPic.Image = bitFinal;
                }
                else
                    MessageBox.Show("Este archivo no es una imagen: " + path);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Guardar archivo
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitFinal.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        
        #endregion

        #region PanelOperaciones

        private void btnGrises_Click(object sender, EventArgs e)
        {
            // Aqui convertimos a escala de grises
            if (bitFinal != null)
            {
                LimpiarHistograma();
                ConversionEscalaDeGrises();
                CalcularHistograma(0);
                MostrarHistogramas(0);
            }
            else
                MessageBox.Show("Hey! Carga una imagen");
        }
        private void btnEcualizar_Click(object sender, EventArgs e)
        {
            // Aqui se debe ecualizar y dar una vista del histograma
            if (bitFinal != null)
            {
                if (yaEcualizado == false)
                {
                    bitFinal = bitInicio;
                    LimpiarHistograma(); // Se limpia el histograma ya que al abrir la imagen el histograma ya esta calculado
                    ConversionEscalaDeGrises(); // Para ecualizar primero pasamos la imagen a escala de grises
                    CalcularHistograma(0); // Calculamos el histograma de la imagen en escala de grises
                    EcualizarHistograma(); // Se aplica el algoritmo de ecualizacion
                    LimpiarHistograma(); // Ya que la imagen fue ecualizada ahora el debemos limpiar el histograma
                    CalcularHistograma(0); // Se debe volver a calcular para sacar el histograma de la imagen ecualizada
                    MostrarHistogramas(0); // Se muestra el histograma para escala de grises e imagen ecualizada
                    //Init();
                    yaEcualizado = true;
                }

            }
            else
                MessageBox.Show("Hey! Carga una imagen");
        }
        private void btnExpansion_Click(object sender, EventArgs e)
        {
            // Aqui se debe abrir un form que permite editar el rango de expansion y dar una vista del histograma
            if (bitFinal != null)
            {

            }
            else
                MessageBox.Show("Hey! Carga una imagen");
        }

        #endregion
    }
}
