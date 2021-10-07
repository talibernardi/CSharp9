using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace ByteBankImportacaoExportacao

{
    partial class Program
    {
        static void Main(string[] args)
        {

            CriarArquivoComWriter();
            Console.WriteLine("Aplicação finalizada. . .");


            Console.ReadLine();
        }
    }
}