using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class Automobile
    {
        private string _numerotelaio;
        private string _targa;
        private string _produttore;
        private string _modello;
        private int velocita;
        public int contatore;
        private bool guidatore;
        private bool stato;
        private int velocitamax;
        private int passeggeri;
        public int contatoreinfrazioni;
        public string Numerotelaio { get { return _numerotelaio; } private set { _numerotelaio = value; } }
        public string Targa { get { return _targa; } private set { _targa = value; } }
        public string Produttore { get { return _produttore; } private set { _produttore = value; } }
        public string Modello { get { return _modello; } private set { _modello = value; } }
        public int Velocita { get { return velocita; } set { velocita = value; } }
        public bool Guidatore { get { return guidatore; } set { guidatore = value; } }
        public bool Stato { get { return stato; } set { stato = value; } }
        public int Velocitamax { get { return velocitamax; } set { velocitamax = value; } }
        public int Passeggeri { get { return passeggeri; } set { passeggeri = value; } }
        public Automobile(string numerotelaio, string targa, string produttore, string modello)
        {
            this._numerotelaio = numerotelaio;
            this._targa = targa;
            this._produttore = produttore;
            this._modello = modello;
            velocita = Velocita;
            contatore = 0;
            guidatore = Guidatore;
            stato = Stato;
            contatoreinfrazioni = 0;
        }
        public void accendi()
        {
            if (stato == false && guidatore == true)
            {
                stato = true;
                velocita = 0;
            }
            else
                throw new Exception("la macchina è gia accesa");
        }
        public void spegni()
        {
            if (velocita == 0)
            {
                if (stato == true && guidatore == true)
                {
                    stato = false;
                    velocita = 0;
                }
                else
                    throw new Exception("la macchina è gia spenta");
            }
            else
                throw new Exception("la macchina non è ferma");
        }
        public void impostalimite(int v)
        {
            if (v >= 1)
            velocitamax = v;
            else
            throw new Exception("limite minore di 1 perciò non valido");
        }
        public void acceleratore(int v) 
        { 
            if(v >= 1&&guidatore==true)
            {
                if(velocita + v <= velocitamax)
                velocita = velocita + v;
                else
                {
                    velocita = velocita + v;
                    contatoreinfrazioni++;
                }
            }
            else
            {
                throw new Exception("accelerazione impostata non valida");
            }
        }
        public void decelerazione(int v)
        {
            
            if (v >= 1 && velocita - v >= 0 && guidatore == true)
                velocita = velocita - v;
            else
                throw new Exception("velocita impostata non valida");   
        }
        public int ottieniinfrazioni()
        {
            return contatoreinfrazioni;
        }
        public void salitaguidatore()
        {
            if (velocita == 0)
            {
                if (guidatore == false)
                {
                    guidatore = true;
                }
                else
                    throw new Exception("il guidatore è gia in macchina");
            }
            else
                throw new Exception("la macchina non è ferma");
        }
        public void salitapasseggero(int p)
        {
            if (velocita == 0)
            {
                if (p >= 1 && passeggeri + p <= 4)
                    passeggeri = passeggeri + p;
                else
                    throw new Exception("numero di passeggeri non valido");
            }
            else
                throw new Exception("la macchina non è ferma");
        }
        public void discesaguidatore()
        {
            if (velocita == 0)
            {
                if (guidatore == true)
                {
                    guidatore = false;
                }
                else
                    throw new Exception("il guidatore è gia fuori dalla macchina");
            }
            else
                throw new Exception("la macchina non è ferma");
        }
        public void discesapasseggeri(int p)
        {
            if (velocita == 0)
            {
                if (p >= 0 && passeggeri - p >= 0)
                {
                    passeggeri = passeggeri - p;
                }
                else
                    throw new Exception("numero passeggeri in discesa non valido");
            }
            else
                throw new Exception("la macchina non è ferma");
        }
        public void discesapasseggerosingolo()
        {
            if (velocita == 0)
            {
                if (passeggeri > 0)
                {
                    passeggeri--;
                }
                else
                    throw new Exception("non ci sono abbasanza passeggeri");
            }
            else
                throw new Exception("la macchina non è ferma");
        }
        public int ottienipasseggeri()
        {
            return passeggeri;
        }
        public override string ToString()
        {
            return Numerotelaio + ";" + Targa + ";" + Produttore + ";" + Modello + "\n";
        }
    }
}
