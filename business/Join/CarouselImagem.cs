using business.business.carousel;
using business.business.Elementos;
using business.business.Elementos.imagem;

namespace business.Join
{
    public class CarouselImagem
    {
        public ulong? CarouselId { get; set; }
        public ulong? ImagemId { get; set; }
        public CarouselImg Carousel { get; set; }
        public Imagem Imagem { get; set; }
    }
}
