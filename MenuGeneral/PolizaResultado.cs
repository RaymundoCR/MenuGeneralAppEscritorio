using System;

namespace MenuGeneral
{
    public struct PolizaResultado
    {
        public PolizaResultado(DateTime FechaTermino, decimal Prima)
        {
            this.FechaTermino = FechaTermino;
            this.Prima = Prima;
        }
        public DateTime FechaTermino { get; set; }
        public decimal Prima { get; set; }
    }
}
