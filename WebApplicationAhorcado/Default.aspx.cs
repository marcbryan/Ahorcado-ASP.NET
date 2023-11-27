using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplicationAhorcado
{
    public partial class _Default : Page
    {
        private string palabra;
        private const int MaxVidas = 7;
        private char[] chars;
        private int vidas;

        private List<Button> listButtons;

        public char[] Chars { get { return chars; } set { chars = value; } }
        public int Vidas { get { return vidas; } set { vidas = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Generamos palabra
            if (ViewState["palabra"] == null)
                ViewState["palabra"] = GenerarPalabra();

            palabra = ViewState["palabra"].ToString();

            // Generamos array caracteres palabra
            if (ViewState["charsPalabra"] == null)
                ViewState["charsPalabra"] = new char[] { '_', '_', '_', '_', '_', '_', '_' , '_'};

            chars = (char []) ViewState["charsPalabra"];
            
            // Asignamos las vidas
            if (ViewState["vidas"] == null)
                ViewState["vidas"] = MaxVidas;

            vidas = (int) ViewState["vidas"];

            CreateLabelsLetter();
            
            //listButtons = AddButtons();
            listButtons = new List<Button>();
            CreateButtons();
            
            DataBind();
        }

        private string GenerarPalabra()
        {
            string[] palabras = { "ABANDONO", "BANANERO", "CALAVERA", "DELFINES", "EJERCITO", "FANTASMA", "GASOLINA", "HARDWARE", "IMPRIMIR", "MILLONES", "LEYENDAS", "XILOFONO" };
            
            Random rnd = new Random();
            int index = rnd.Next(palabras.Length);

            return palabras[index];
        }

        /*private List<Button> AddButtons()
        {
            List<Button> buttons = new List<Button>();
            
            buttons.Add(ButtonA);
            buttons.Add(ButtonB);
            buttons.Add(ButtonC);
            buttons.Add(ButtonD);
            buttons.Add(ButtonE);
            buttons.Add(ButtonF);
            buttons.Add(ButtonG);
            buttons.Add(ButtonH);
            buttons.Add(ButtonI);
            buttons.Add(ButtonJ);
            buttons.Add(ButtonK);
            buttons.Add(ButtonL);
            buttons.Add(ButtonM);
            buttons.Add(ButtonN);
            buttons.Add(ButtonO);
            buttons.Add(ButtonP);
            buttons.Add(ButtonQ);
            buttons.Add(ButtonR);
            buttons.Add(ButtonS);
            buttons.Add(ButtonT);
            buttons.Add(ButtonU);
            buttons.Add(ButtonV);
            buttons.Add(ButtonW);
            buttons.Add(ButtonX);
            buttons.Add(ButtonY);
            buttons.Add(ButtonZ);

            return buttons;
        }*/

        private void CreateLabelsLetter()
        {
            for (int i = 0; i < 8; i++)
            {
                Label label = new Label();
                label.ID = "LabelLetter" + (i + 1);
                label.Text = chars[i].ToString();
                
                Letters.Controls.Add(label);
            }
        }

        private void CreateButtons()
        {
            string lettersTop = "ABCDEFGHIJKLM";
            AddButtonsTo(ButtonsTop, lettersTop);

            string lettersBottom = "NOPQRSTUVWXYZ";
            AddButtonsTo(ButtonsBottom, lettersBottom);
        }

        private void AddButtonsTo(HtmlGenericControl control, string letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                Button btn = new Button();
                btn.ID = "Button" + letters[i];
                btn.Text = letters[i].ToString();
                btn.CssClass = "btn btn-secondary";
                btn.Click += new EventHandler(ButtonLetter_Click);
                
                control.Controls.Add(btn);
                listButtons.Add(btn);
            }
        }

        protected void ButtonLetter_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (IsPostBack)
            {
                char letra = button.Text[0];
                if (palabra.Contains(letra))
                {
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabra[i] == letra)
                        {
                            chars[i] = letra;

                            // Obtenemos una lista solo con los labels y buscamos por el índice
                            Label label = (Label) Letters.Controls.OfType<Label>().ToList()[i];
                            label.Text = chars[i].ToString();
                        }
                    }

                    // Desactivamos el botón y lo ponemos de color verde
                    button.Enabled = false;
                    button.CssClass = "btn btn-success";


                    // Si la cadena no contiene el caracter '_', entonces ha ganado
                    string cadena = new string(chars);
                    if (!cadena.Contains("_"))
                    {
                        DisableButtons();
                        LabelTitle.Text = "Has ganado!!";
                    }

                    DataBind();
                }
                else
                {                   
                    vidas--;
                    ViewState["vidas"] = vidas;

                    int numArchivo = MaxVidas - vidas;
                    // Cambiar url imagen
                    ImageAhorcado.ImageUrl = "~/Images/ahorcado_img" + numArchivo + ".png";

                    // Desactivamos el botón y lo ponemos de color rojo
                    button.Enabled = false;
                    button.CssClass = "btn btn-danger";

                    // Se ha quedado sin vidas
                    if (vidas == 0)
                    {
                        DisableButtons();
                        LabelTitle.Text = "Has perdido!! La palabra era: " + palabra;
                    }

                    DataBind();
                }
            }
        }

        private void DisableButtons()
        {
            // Desactivamos todos los botones que esten activados
            foreach (Button btn in listButtons)
            {
                if (btn.Enabled)
                {
                    btn.Enabled = false;
                    btn.CssClass = "btn btn-secondary";
                }
            }
        }
    }
}