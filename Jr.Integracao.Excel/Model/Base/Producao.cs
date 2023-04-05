
using DocumentFormat.OpenXml.InkML;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jr.Integracao.Excel.Model.Base
{
    public class Producao : BaseEntity
    {
        //Nome das colunas da tabela PROD_DATABASE_030423_VF

        [Column("date")]
        public Timestamp Date { get; set; }

        [Column("anp_well_name")]
        public string AnpWellName { get; set; }

        [Column("uwi")]
        public string Uwi { get; set; }

        [Column("field")]
        public string Field { get; set; }

        [Column("well_test_date")]
        public Timestamp WellTestDate { get; set; }

        [Column("data_aplicacao_potencial")]
        public string DataAplicacaoPotencial { get; set; }

        [Column("oil_pot_wt")]
        public decimal OilPotWt { get; set; }

        [Column("water_pot_wt")]
        public decimal WaterPotWt { get; set; }

        [Column("liq_pot_wt")]
        public decimal LiqPotWt { get; set; }

        [Column("bsw")]
        public decimal Bsw { get; set; }

        [Column("gl_pot_wt")]
        public decimal GlPotWt { get; set; }

        [Column("gas_pot_wt")]
        public decimal GasPotWt { get; set; }

        [Column("wellhead_pressure_wt")]
        public decimal WellheadPressureWt { get; set; }

        [Column("choke_wt")]
        public decimal ChokeWt { get; set; }

        [Column("metodo_elevacao")]
        public string MetodoElevacao { get; set; }

        [Column("well_runtime")]
        public decimal WellRuntime { get; set; }

        [Column("well_fluid")]
        public string WellFluid { get; set; }

        [Column("wellhead_pressure")]
        public decimal WellheadPressure { get; set; }

        [Column("comentarios_wellhead_pressure")]
        public string ComentariosWellheadPressure { get; set; }

        [Column("line_pressure")]
        public string LinePressure { get; set; }

        [Column("choke")]
        public decimal Choke { get; set; }

        [Column("oil_pot_day")]
        public decimal OilPotDay { get; set; }

        [Column("gas_pot_day")]
        public double GasPotDay { get; set; }

        [Column("gl_pot_day")]
        public double GlPotDay { get; set; }

        [Column("gas_prod_well_aloc")]
        public double GasProdWellAloc { get; set; }

        [Column("oil_prod_well_aloc")]
        public double OilProdWellAloc { get; set; }

        [Column("gl_prod_well_aloc")]
        public double GlProdWellAloc { get; set; }

        [Column("campo28")]
        public string Campo28 { get; set; }

        [Column("water_pot_day")]
        public double WaterPotDay { get; set; }

        [Column("wt_prod_well_alloc")]
        public decimal WtProdWellAlloc { get; set; }

        [Column("liq_pote")]
        public decimal LiqPote { get; set; }

        [Column("well_classif")]
        public string WellClassif { get; set; }

        [Column("downtime")]
        public double DownTime { get; set; }



    }

}
