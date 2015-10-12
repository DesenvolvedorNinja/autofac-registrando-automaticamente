namespace AutofacDemoWCF
{
    public class Service1 : IService1
    {
        private ICalculo _calculo;

        public Service1(ICalculo calculo)
        {
            this._calculo = calculo;
        }

        public string GetTeste() => "Desenvolvedor Ninja - Autofac com WCF";

        public double GetSoma(double a, double b) => _calculo.Calcular(a, b);
    }
}
