using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCriaPlanilha.services
{
    class ExcelService
    {
        MovimentacaoModel db = new MovimentacaoModel();

        public void GeraExcel()
        {  
            var workBook = new XLWorkbook();
            var workSheet = workBook.Worksheets.Add("ClientesConta");

            var clientes = db.Cliente.ToList();

            int linha = 1;

            //Cria cabeçalho da Planilha
            workSheet.Cell("A" + linha.ToString()).Value = "ID";
            workSheet.Cell("B" + linha.ToString()).Value = "Nome";
            workSheet.Cell("C" + linha.ToString()).Value = "CPF";
            workSheet.Cell("D" + linha.ToString()).Value = "Numero Conta";

            workSheet.Cells("A1:D1").Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightSteelBlue;

            linha = 2;
            
            //processa enquanto tem valores 
            foreach(Cliente item in clientes)
            {
                workSheet.Cell("A" + linha.ToString()).Value = item.id;
                workSheet.Cell("B" + linha.ToString()).Value = item.Nome;
                workSheet.Cell("C" + linha.ToString()).Value = item.CPF;

                var conta = db.Conta.Find(item.id);

                //Inner Join usando Entity
                //var testeJoinEntity = db.Conta.Where(c => c.IdCliente == item.Id).FirstOrDefault();

                if(conta != null)
                {
                    workSheet.Cell("D" + linha.ToString()).Value = conta.NumeroConta;
                }            
                

                linha++;
            }

            string rotaArquivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
                + "\\ClientesConta" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year 
                + ".xlsx";

            workBook.SaveAs(rotaArquivo);
            workBook.Dispose();
        }

    }
}
