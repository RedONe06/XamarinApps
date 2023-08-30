using Newtonsoft.Json;

namespace XAMLApp.Models
{
    public class Veiculo
    {
        public const int FREIO_ABS = 800;
        public const int AR_CONDICIONADO = 1000;
        public const int MP3_PLAYER = 500;
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("valor")]
        public decimal Preco { get; set; }
        [JsonIgnore]
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", Preco);
            }
        }
        [JsonIgnore]
        public bool TemFreioABS { get; set; }
        [JsonIgnore]
        public bool TemArCondicionado { get; set; }
        [JsonIgnore]
        public bool TemMP3Player { get; set; }
        [JsonIgnore]
        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Valor total: R$ {0}",
                    Preco +
                    (TemFreioABS ? FREIO_ABS : 0) +
                    (TemArCondicionado ? AR_CONDICIONADO : 0) +
                    (TemMP3Player ? MP3_PLAYER : 0));
            }
        }
    }
}
