using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebGrease.Css.Ast.Selectors;

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

            listButtons = AddButtons();
            
            DataBind();
        }

        private string GenerarPalabra()
        {
            string[] palabras = { "ABANDONO", "BANANERO", "CALAVERA", "DELFINES", "EJERCITO", "FANTASMA", "GASOLINA", "HARDWARE", "IMPRIMIR", "MILLONES", "LEYENDAS", "XILOFONO" };
            
            Random rnd = new Random();
            int index = rnd.Next(palabras.Length);

            return palabras[index];
        }

        private List<Button> AddButtons()
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
                            chars[i] = letra;
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