using System;
using System.Globalization;


namespace CSharpPOO
{
   public class Aluno
    {
        public string Nome;
        public double Nota1,Nota2,Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public override string ToString()
        {
          return  "NOTA FINAL = " +
         NotaFinal().ToString("F2", CultureInfo.InvariantCulture); 
        }




    }
    
}
