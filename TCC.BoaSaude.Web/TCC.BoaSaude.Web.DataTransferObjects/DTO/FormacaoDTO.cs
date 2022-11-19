namespace TCC.BoaSaude.Web.Entidades.DTO
{
    public class FormacaoDTO
    {
        public string Instituicao { get; set; }
        public string Curso { get; set; }
        public TipoFormacao TipoFormacao { get; set; }
    }
    public enum TipoFormacao
    {
        FundamentalIncompleto = 0,
        FundamentalCompleto = 1,
        SuperiorCompleto = 2,
        PosGaduacaoCompleta = 3,
        MestradoCompleta = 4,
        DoutouradoCompleto = 5
    }
}
