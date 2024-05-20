/*
 * Created by SharpDevelop.
 * User: dfj24
 * Date: 02/05/2023
 * Time: 12:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Civica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
	
		}
		void ConfermaClick(object sender, EventArgs e)
		{
	
			
			if (Box_nome.Text.Length < 2) {
				MessageBox.Show("Il campo Nome non può contenere meno di 2 caratteri!");
				return;
			}
			if (System.Text.RegularExpressions.Regex.IsMatch(Box_nome.Text, @"^[a-zA-Z ]+$") == false) {
				MessageBox.Show("Il campo Nome contiene caratteri non validi!");
				return;
			}
			
			if (Box_cognome.Text.Length < 2) {
				MessageBox.Show("Il campo Cognome non può contenere meno di 2 caratteri!");
				return;
			}
			if (System.Text.RegularExpressions.Regex.IsMatch(Box_cognome.Text, @"^[a-zA-Z ]+$") == false) {
				MessageBox.Show("Il campo Cognome contiene caratteri non validi!");
				return;
			}
			
			if (Box_comuni.Text.Length < 3) {
				MessageBox.Show("Il campo Comune non può contenere meno di 3 caratteri!");
				return;
			}
			if (System.Text.RegularExpressions.Regex.IsMatch(Box_comuni.Text, @"^[a-zA-Z ]+$") == false) {
				MessageBox.Show("Il campo Comune contiene caratteri non validi!");
				return;
			}
			
			if (Box_anno.Text.Length != 4) {
				MessageBox.Show("Il campo Anno non può contenere meno o più di 4 caratteri!");
				return;
			}
			if (System.Text.RegularExpressions.Regex.IsMatch(Box_anno.Text, @"^[0-9()+ ]+$") == false) {
				MessageBox.Show("Il campo Anno contiene caratteri non validi!");
				return;
			}
			
			if (Box_giorno.Text.Length != 1 && Box_giorno.Text.Length != 2) {
				MessageBox.Show("Il campo Giorno è errato!");
				return;
			}
			if (System.Text.RegularExpressions.Regex.IsMatch(Box_giorno.Text, @"^[0-9()+ ]+$") == false) {
				MessageBox.Show("Il campo Giorno contiene caratteri non validi!");
				return;
			}
			
			if (Combo_mese.Text.ToString() == "") {
				MessageBox.Show("Il campo Mese non può essere vuoto!");
			}
			
			if (Combo_sesso.Text.ToString() == "") {
				MessageBox.Show("Il campo Sesso non può essere vuoto!");
			}
			
			
			string codice = "";
			
			/*for (int i = 0; i < Box_cognome.Text.Length; i++) {
				if (Box_cognome.Text.ToUpper()[i] != 'A' && Box_cognome.Text.ToUpper()[i] != 'E' && Box_cognome.Text.ToUpper()[i] != 'I' && Box_cognome.Text.ToUpper()[i] != 'O' && Box_cognome.Text.ToUpper()[i] != 'U') {
					codice = codice + Box_cognome.Text.ToUpper()[i];
					j++;
				}
				if (j == 3) {
					i = Box_cognome.Text.Length + 1;
				}
			}
			
			j = 0;
			
			string consonanti = "";
			
			for (int i = 0; i < Box_nome.Text.Length; i++) {
				if (Box_nome.Text.ToUpper()[i] != 'A' && Box_nome.Text.ToUpper()[i] != 'E' && Box_nome.Text.ToUpper()[i] != 'I' && Box_nome.Text.ToUpper()[i] != 'O' && Box_nome.Text.ToUpper()[i] != 'U') {
					consonanti = consonanti + Box_nome.Text.ToUpper()[i];
				}
			} */
			
			string consonanti = "";
			string vocali = "";
			string aggiunta = "X";

			
			for (int i = 0; i < Box_cognome.Text.Length; i++) {
				if (Box_cognome.Text.ToUpper()[i] != 'A' && Box_cognome.Text.ToUpper()[i] != 'E' && Box_cognome.Text.ToUpper()[i] != 'I' && Box_cognome.Text.ToUpper()[i] != 'O' && Box_cognome.Text.ToUpper()[i] != 'U') {
					consonanti = consonanti + Box_cognome.Text.ToUpper()[i];
				}
				else {
					vocali = vocali + Box_cognome.Text.ToUpper()[i];
				}
			}
			
				
			//cognome

						
			
			if (consonanti.Length >= 3) {
				codice = codice + consonanti.Substring(0, 3);
			}
			else if(consonanti.Length == 2) {
				codice = codice + consonanti + vocali[0]; }
			else if(consonanti.Length == 1) {
				if(vocali.Length > 1) {
					codice = codice + consonanti + vocali.Substring(0,2);
				}
				else if(vocali.Length == 1) {
					codice = codice + consonanti + vocali + aggiunta;
				}
			}
				
			string consonant = "";
			string vocal = "";
			
			for (int y = 0; y < Box_nome.Text.Length; y++) {
				if (Box_nome.Text.ToUpper()[y] != 'A' && Box_nome.Text.ToUpper()[y] != 'E' && Box_nome.Text.ToUpper()[y] != 'I' && Box_nome.Text.ToUpper()[y] != 'O' && Box_nome.Text.ToUpper()[y] != 'U') {
					consonant = consonant + Box_nome.Text.ToUpper()[y];
				}
				else {
					vocal = vocal + Box_nome.Text.ToUpper()[y];
				}
			}
			
			//nome
			
			
			if (consonant.Length >= 4) {
				codice = codice + consonant[0] + consonant[2] + consonant[3] ;
			}
			else if(consonant.Length == 3) {
				codice = codice + consonant;
			}
			else if(consonant.Length == 2) {
				codice = codice + consonant + vocal[0]; }
			else if(consonanti.Length == 1) {
				if(vocal.Length > 1) {
					codice = codice + consonant + vocal.Substring(0,2);
				}
				else if(vocal.Length == 1) {
					codice = codice + consonant + vocal + aggiunta;
				}
			}
			
			
			
			codice = codice + Box_anno.Text[2] + Box_anno.Text[3];
            
			switch (Combo_mese.Text.ToString()) {
				case "Gennaio":
					codice = codice + "A";
					break;
				case "Febbraio":
					codice = codice + "B";
					break;
				case "Marzo":
					codice = codice + "C";
					break;
				case "Aprile":
					codice = codice + "D";
					break;
				case "Maggio":
					codice = codice + "E";
					break;
				case "Giugno":
					codice = codice + "H";
					break;
				case "Luglio":
					codice = codice + "L";
					break;
				case "Agosto":
					codice = codice + "M";
					break;
				case "Settembre":
					codice = codice + "P";
					break;
				case "Ottobre":
					codice = codice + "R";
					break;
				case "Novembre":
					codice = codice + "S";
					break;
				case "Dicembre":
					codice = codice + "T";
					break;
			} 
			
			int giorno = Convert.ToInt32(Box_giorno.Text);
			
			if (Combo_sesso.Text.ToString() == "Maschio")
				codice = codice + giorno.ToString();
			else
				codice = codice + (giorno + 40).ToString();
			
			
			string Comuni = "C:/Users/dfj24/OneDrive/Documenti/SharpDevelop Projects/Civica/Comuni.txt";  
			string Dispari = "C:/Users/dfj24/OneDrive/Documenti/SharpDevelop Projects/Civica/Dispari.txt";  
			string Pari = "C:/Users/dfj24/OneDrive/Documenti/SharpDevelop Projects/Civica/Pari.txt"; 
			string Resto = "C:/Users/dfj24/OneDrive/Documenti/SharpDevelop Projects/Civica/Resto.txt";  
			
			if (!File.Exists(Comuni)) {
				MessageBox.Show("Non è possibile concludere con il codice fiscale per mancanza di dati", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();
			}
			if (!File.Exists(Dispari)) {
				MessageBox.Show("Non è possibile concludere con il codice fiscale per mancanza di dati", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();
			}
			if (!File.Exists(Pari)) {
				MessageBox.Show("Non è possibile concludere con il codice fiscale per mancanza di dati", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();
			}
			if (!File.Exists(Resto)) {
				MessageBox.Show("Non è possibile concludere con il codice fiscale per mancanza di dati", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();
			}
         
			foreach (string line in File.ReadLines(Comuni)) {

				string[] parts = line.Split('\t');

				if (parts[1] == Box_comuni.Text.ToUpper()) {

					codice = codice + parts[0];
					break;
				}
			}
			
			
			int fine = 0;
			
			for (int f = 0; f < codice.Length; f++) {
				if (f % 2 == 0) {
					foreach (string line in File.ReadLines(Dispari)) {
	
						string[] parte = line.Split(' ');
		                
						if (Convert.ToChar(parte[0]) == codice.ToUpper()[f]) {
		
							fine = fine + Convert.ToInt32(parte[1]);
							break;
						}
					}	
				} 
				else {
					foreach (string line in File.ReadLines(Pari)) {
	
						string[] linea = line.Split(' ');
		                
						if (Convert.ToChar(linea[0]) == codice.ToUpper()[f]) {
		
							fine = fine + Convert.ToInt32(linea[1]);
							break;
						}
					}
				}
			}
			
			int diff = fine;
			
			fine = fine / 26;
			fine = fine * 26;
			
			diff = diff - fine;
			
			foreach (string line in File.ReadLines(Resto)) {

				string[] riga = line.Split(' ');
                
				if (Convert.ToInt32(riga[0]) == diff) {

					codice = codice + riga[1];
					break;
				}
			}	
           
			
			MessageBox.Show("il tuo codice fiscale è:" + codice, "Finito", MessageBoxButtons.OK);
			
			
		}
		void AnnullaClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
	