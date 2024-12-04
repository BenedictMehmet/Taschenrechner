using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        // Variable, die die Eingabe speichert
        private string eingabe = "";
        private bool punktHinzugefügt = false;  // Zeigt an, ob ein Punkt in der aktuellen Zahl ist

        public Taschenrechner()
        {
            InitializeComponent();
        }

        // Methode, die die Zahlentasten behandelt
        private void Zahl_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                eingabe += button.Text;
                Anzeigefeld.Text = eingabe;  // Eingabe im Display aktualisieren
            }
        }

        // Methode, um den Punkt (Komma) zu behandeln
        private void Punkt_Click(object sender, EventArgs e)
        {
            // Punkt nur hinzufügen, wenn er noch nicht in der aktuellen Zahl enthalten ist
            if (!punktHinzugefügt && !string.IsNullOrEmpty(eingabe) &&
                (char.IsDigit(eingabe[eingabe.Length - 1]) || eingabe[eingabe.Length - 1] == '.'))
            {
                eingabe += ".";
                punktHinzugefügt = true; // Punkt hinzugefügt
                Anzeigefeld.Text = eingabe;  // Eingabe im Display aktualisieren
            }
        }

        // Methode für die mathematischen Operationen
        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Vor dem Hinzufügen der Operation prüfen, ob die Eingabe gültig ist
                if (eingabe.Length > 0 && char.IsDigit(eingabe[eingabe.Length - 1]))
                {
                    eingabe += " " + button.Text + " ";
                    punktHinzugefügt = false;  // Punkt für die neue Zahl zurücksetzen
                    Anzeigefeld.Text = eingabe;  // Eingabe im Display aktualisieren
                }
            }
        }

        // Berechnung durchführen, wenn "Gleich" gedrückt wird
        private void Gleich_Click(object sender, EventArgs e)
        {
            try
            {
                // Schritt 1: Eingabe prüfen
                if (string.IsNullOrWhiteSpace(eingabe) || eingabe.EndsWith(" ") || eingabe.Contains("  "))
                {
                    throw new Exception("Ungültiger Ausdruck");
                }

                // Schritt 2: Dezimal-Komma zu Punkt konvertieren
                eingabe = eingabe.Replace(',', '.');

                // Schritt 3: Multiplikationszeichen `x` durch `*` ersetzen
                eingabe = eingabe.Replace('x', '*');

                // Schritt 4: Bereinigung von Leerzeichen und Operatoren
                eingabe = System.Text.RegularExpressions.Regex.Replace(eingabe, @"([+\-*/()])", " $1 ");
                eingabe = System.Text.RegularExpressions.Regex.Replace(eingabe, @"\s+", " ").Trim();

                // Schritt 5: Dezimalpunkt am Ende entfernen
                if (eingabe.EndsWith("."))
                {
                    eingabe = eingabe.TrimEnd('.');
                }

                // Schritt 6: Ausdruck überprüfen
                eingabe = NormalizeExpression(eingabe);

                // Schritt 7: Berechnung durchführen
                var result = new System.Data.DataTable().Compute(eingabe, null);
                string ergebnis = result.ToString();

                // Schritt 8: Ergebnis anzeigen
                Anzeigefeld.Text = eingabe + " = " + ergebnis;

                // Eingabe zurücksetzen
                eingabe = "";
                punktHinzugefügt = false;
            }
            catch (Exception ex)
            {
                // Fehler anzeigen
                Anzeigefeld.Text = "Fehler: " + ex.Message;
                eingabe = "";
                punktHinzugefügt = false;
            }
        }



        // Methode, um den Ausdruck zu bereinigen
        private string NormalizeExpression(string expression)
        {
            // Entferne doppelte Leerzeichen
            expression = System.Text.RegularExpressions.Regex.Replace(expression, @"\s+", " ");

            // Entferne führende und abschließende Leerzeichen
            expression = expression.Trim();

            // Optional: Überprüfen, ob der Ausdruck gültige Zeichen enthält
            if (!System.Text.RegularExpressions.Regex.IsMatch(expression, @"^[0-9+\-*/.() ]+$"))
            {
                throw new Exception("Ungültiger Ausdruck: Zeichen nicht erlaubt");
            }

            return expression;
        }

        // Methode, um den Bildschirm zu löschen
        private void Clear_Click(object sender, EventArgs e)
        {
            eingabe = "";
            punktHinzugefügt = false; // Punkt zurücksetzen
            Anzeigefeld.Text = "";  // Display löschen
        }
    }
}
