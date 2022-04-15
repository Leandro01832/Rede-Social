using business.business.carousel;
using business.business.Elementos;
using business.business.Elementos.imagem;
using System;

namespace business.Join
{
    public class CarouselImagem
    {
        public Int64? CarouselId { get; set; }
        public Int64? ImagemId { get; set; }
        public CarouselImg Carousel { get; set; }
        public Imagem Imagem { get; set; }
    }
}
