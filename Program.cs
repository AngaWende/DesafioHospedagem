using DesafioHospedagem.models;


Pessoa p1 = new Pessoa("ned", "flanders");
Pessoa p2 = new Pessoa("todd", "flanders");
Pessoa p3 = new Pessoa("rod", "flanders");

Pessoa p4 = new Pessoa("apu", "nahasapeemapetilon");
Pessoa p5 = new Pessoa("manjula", "Nahasapeemapetilon");

Pessoa p6 = new Pessoa("homer", "simpson");
Pessoa p7 = new Pessoa("marge", "simpson");
Pessoa p8 = new Pessoa("bart", "simpson");
Pessoa p9 = new Pessoa("lisa", "simpson");
Pessoa p10 = new Pessoa("maggie", "simpson");

//pessoas cadastradas foram separadas em familias
List<Pessoa> f1 = new List<Pessoa>([p1, p2, p3]);
List<Pessoa> f2 = new List<Pessoa>([p4,p5]);
List<Pessoa> f3 = new List<Pessoa>([p6,p7,p8,p9, p10]);


//cadastro das suites
Suite casal = new Suite("Casal", 2, 190.50M);
Suite standard = new Suite("Standard", 3, 100.50M);
Suite familia = new Suite("Família", 6, 200.00M);
Suite luxo= new Suite("Luxo", 6, 450.50M);

Reserva r1 = new Reserva();
Reserva r2 = new Reserva(f2, casal, 5);
Reserva r3 = new Reserva(f3, familia, 5);


r1.CadastrarSuite(standard);
r1.CadastrarHospedes(f1);
r1.DiasReservados = 7;


r1.Resumo();
r2.Resumo();
r3.Resumo();




// foreach(Pessoa p in r1.mostrarReserva()){
//     System.Console.WriteLine(p.Nome);
// }

