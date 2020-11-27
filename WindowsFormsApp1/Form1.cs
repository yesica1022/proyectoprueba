using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        ValidarCajas validacion = new ValidarCajas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidacion_Click(object sender, EventArgs e)
        {
            //............Codigo de validacion..................

            if (!validacion.vacio(nombrein, errorm, "El nombre no puede quedar vacio"))
                if (validacion.TipoTexto(nombrein, errorm, "Debe digitar texto"))
                    if (!validacion.vacio(codigoin, errorm, "El codigo no puede quedar vacio"))
                        if (validacion.TipoNumero(codigoin,errorm, "Debe digitar numeros"))
                           if (!validacion.vacio(correoin, errorm, "El correo no puede quedar vacio"))
                                if (validacion.TipoCorreo(correoin,errorm, "El formato del correo no es correcto" ))
                                        {salida.Text = "Todos los campos estan llenos";
                                         limpiarCajas();
                                }
        }

              //......fincion para limpiar cajas de texto
        
        private void limpiarCajas()
        {
            nombrein.Clear();
            codigoin.Clear();
            correoin.Clear();
        }

        private void btnvalpass_Click(object sender, EventArgs e)

        {
            //  Las condiciones son que la cadena debe tener entre 8 y 15 caracteres de longitud.
            //  la cadena debe contener al menos un número. la cadena debe contener al menos una letra mayúscula. 
            //  la cadena debe contener al menos una letra minúscula.yesica1922A

            Regex password = new Regex("({(?=.*[a-z])(?=.*[A-Z]).{8,}}|{(?=.*[A-Z])(?!.*\\s).{8,}})");

            if (password.IsMatch(passwordin.Text)) salida.Text = " El password coincide";
            else salida.Text = "El password no es correcto";
            
            

           // if (validacion.vacio(passwordin, errorm, "El password no puede estar vacio"))

                
           // salida.Text = " Passwortd digitado";
        }
    }
}
