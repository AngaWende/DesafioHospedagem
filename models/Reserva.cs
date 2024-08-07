using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagem.models
{
    public class Reserva
    {
        private List<Pessoa> _novoshospedes = new List<Pessoa>();
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){}

        public Reserva(List<Pessoa> hospedes, Suite suite, int dias){
            Suite = suite;
            this.CadastrarHospedes(hospedes);
            DiasReservados = dias;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes){
            int qtdeVagas;
            try
            {
            
                qtdeVagas = Suite.Capacidade;

                if(qtdeVagas >= hospedes.Count){
                    _novoshospedes.AddRange(hospedes);
                }else{
                    System.Console.WriteLine("A suíte não suporta essa capacidade.");
                }
            }catch(Exception e){
                System.Console.WriteLine("Suíte não cadastrada. Adicione uma suíte antes.");
            }            
            
        }

        public void CadastrarSuite(Suite suite){
            // System.Console.WriteLine("suite cadastrada");            
            Suite = suite;
        }

        public List<Pessoa> mostrarReserva() => _novoshospedes;

        public int ObterQuantidadeHospedes(){
            return _novoshospedes.Count;
        }

        public decimal CalcularValorTotal() => DiasReservados * Suite.ValorDiaria;
           

        public string ListarHospedes(){
            string h = "";
            foreach(Pessoa p in _novoshospedes){
                h += $"  {p.Nome} {p.Sobrenome}\n";
            }
            return h;
        }

        public void Resumo()
        {
            if (_novoshospedes.Count > 0 && Suite.Capacidade > 0 && DiasReservados > 0)
            {
                System.Console.WriteLine($"Suíte: {Suite.TipoSuite}\nHóspedes:\n{this.ListarHospedes()}Estadia: {this.DiasReservados} dias\nValor Total: {this.CalcularValorTotal()}\n");
            }else{
                System.Console.WriteLine("Reserva não efetuada. Por favor, revise os dados.");
            }
        }

    }
}