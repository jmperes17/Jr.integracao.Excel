using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using Jr.Integracao.Excel.Model.Base;
using Jr.Integracao.Excel.Model.Contexto;
using Jr.Integracao.Excel.Repositorio;
 
Context contexto = new Context();
ProducaoRepositorio _producaoRepositorio = new ProducaoRepositorio(contexto);


var xls = new XLWorkbook(@"C:\Temp\database.xlsx");
var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
var totalLinhas = planilha.Rows().Count();


// primeira linha é o cabecalho
for (int l = 2; l <= totalLinhas; l++)
{
    var date =     planilha.Cell($"A{l}").Value.ToString();
  

    //Metodo
    _producaoRepositorio.Insert(new Producao() {Date = date });

}






