using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using Jr.Integracao.Excel.Model.Base;
using Jr.Integracao.Excel.Model.Contexto;
using Jr.Integracao.Excel.Repositorio;
 
Context contexto = new Context();
ProducaoRepositorio _producaoRepositorio = new ProducaoRepositorio(contexto);


var xls = new XLWorkbook(@"C:\Temp\Usuario.xlsx");
var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
var totalLinhas = planilha.Rows().Count();


// primeira linha é o cabecalho
for (int l = 2; l <= totalLinhas; l++)
{
    var nome =     planilha.Cell($"A{l}").Value.ToString();
    var endereco = planilha.Cell($"B{l}").Value.ToString();
    var email =    planilha.Cell($"C{l}").Value.ToString();


    _producaoRepositorio.Criar(new Producao() {Email = email,Endereco = endereco , Name = nome });

}






