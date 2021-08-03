using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol.AddDicandCol
{   public enum Combustibil
    { 
    benzina,
    motorina,
    gaz,
    ce,
    gazSiBenzina
    }
    class Masina
    {
        private readonly string serieSasiu;
        private int? nrKm = 0;
        private readonly string marca;
        private readonly string model;
        private Combustibil combustibil;
        private Dictionary<string, string> reparatii;
        public Masina(string serieSasiu, string marca, string model)
        {
            this.reparatii = new Dictionary<string, string> { };
            this.serieSasiu = serieSasiu;
            this.marca = marca;
            this.model = model;
        }
        public Masina(string serieSasiu, string marca, string model, int nrKm, Combustibil combustibil) : this(serieSasiu, marca, model)
        {
            this.nrKm = nrKm;
            this.combustibil = combustibil;

        }
        public void addReparatie(string mecanic , string reparatia)
        {

            DateTime datareparatie = DateTime.Now;
            if (reparatii.ContainsKey(mecanic))
            {
                reparatii[mecanic] = reparatii[mecanic] + $" {datareparatie} ::{reparatia} ";
            }
            else
            {
                reparatii.Add(mecanic, $"la data de:: {datareparatie} :: {reparatia} ");
            }
        }


        public Combustibil Combustibil
        {
            set
            {
                this.combustibil = value;
            }
            get
            {

                return combustibil;
            }
        }
        public string NrKMVerificare => $"Masina a efectuat {nrKm} km.";
        public string addKmParcursi(int nrKmparcursi)
        {
            if (nrKmparcursi < 0)
            {
                return $"Nr de km nu poate sa fie negativ";

            }
            nrKm += nrKmparcursi;
            return $"Km au fost adaugati cu succes, iar masina dvs a efecutat: {nrKm} km.";


        }
        public override string ToString()
        {
            string ret= $@"Serie masina:{serieSasiu};
Marca:{marca};
Model:{model};
NrKm:{nrKm};
Combustibil:{combustibil}
Reparatii:
";
            foreach (KeyValuePair<string, string> k in reparatii)
            {
                ret = ret + $"nume mecanic: {k.Key} reparatii:  {k.Value}";
            }
            return ret;
        }
    }
    abstract class Animal
    {
        public abstract string poateSaZboare();
    }
    class Lebada : Animal
    {
        private int ani;
        public Lebada(int ani)
        {
            this.ani = ani;
        }
        public override string poateSaZboare()
        {
            return $"Poate sa zboare in orice conditii";
        }
    }
}
